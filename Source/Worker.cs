using ExifLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ImageSort {
    class Worker : IDisposable {
        public BackgroundWorker thread;     // The worker thread object
        public workerState state;           // Structure to pass the state of the worker thread to the caller
        public userSelection user;          // The option selections made by the user
        public IEnumerable<string> files;   // The enumerated list of files
        public string currentSource;        // Current source file path (for logging)
        public string currentDest;          // Current destination file path (for logging)

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="sender">BackgroundWorker thread object</param>
        /// <param name="e">BackgroundEvent arguments object</param>
        public Worker(object sender, DoWorkEventArgs e) {
            thread = sender as BackgroundWorker;
            user = (userSelection)e.Argument;
            Initialise();
        }

        /// <summary>
        /// Initialises the class, creating the worker state structure
        /// and getting/counting files in the source directory
        /// </summary>
        private void Initialise() {
            int numFiles = 0;

            ReportProgress("Finding files...");

            try {
                files = GetFiles(user.source, @".*\.NEF|.*\.nef|.*\.jpg|.*\.JPG|.*\.cr2|.*\.CR2|.*\.jpeg|.*\.JPEG",
                    user.recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                numFiles = files.Count();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

            ReportProgress("Processing Files...", 0, numFiles);
        }

        /// <summary>
        /// Returns an enumerated list of files in the specified source directory.
        /// </summary>
        private IEnumerable<string> GetFiles(string path, string searchPatternExpression = "", SearchOption searchOption = SearchOption.TopDirectoryOnly) {
            Regex reSearchPattern = new Regex(searchPatternExpression);
            return Directory.EnumerateFiles(path, "*", searchOption).Where(file => reSearchPattern.IsMatch(Path.GetExtension(file)));
        }

        /// <summary>
        /// Processes the file at index `i` and reports the success of the operation
        /// </summary>
        /// <param name="itterator">Index of the file to process</param>
        /// <returns>True if the operation succeeded</returns>
        public bool ProcessFile(int i, int progress) {
            string sourcePath;
            string fileName;
            DateTime fileDateTaken;
            string directoryFormat;
            string destinationPath;
            FileInfo sourceFile;
            FileInfo destinationFile;
            try {
                // Construct the destination path
                sourcePath = files.ElementAt<string>(i);
                fileName = Path.GetFileName(sourcePath);
                fileDateTaken = GetDateTakenFromImage(sourcePath);
                directoryFormat = user.directoryFormat.Replace(
                            String.Format("{0}", DirOpt.DAY), String.Format("{0:00}", fileDateTaken.Day)).Replace(
                            String.Format("{0}", DirOpt.MONTH), String.Format("{0:00}", fileDateTaken.Month)).Replace(
                            String.Format("{0}", DirOpt.YEAR), String.Format("{0:0000}", fileDateTaken.Year));
                destinationPath = String.Format(@"{0}{1}{2}", user.destination, directoryFormat, fileName);
                sourceFile = new FileInfo(sourcePath);
                ReportProgress(String.Format("Processing File: {0}", fileName), progress);

                currentSource = sourcePath;
                currentDest = destinationPath;

                if (File.Exists(destinationPath)) {
                    destinationFile = new FileInfo(destinationPath);

                    if (user.fileRule == FileRule.ORIGINAL) {
                        return true;
                    } else if (user.fileRule == FileRule.INCREMENT) {
                        if ((sourceFile.Length == destinationFile.Length) && (fileDateTaken == GetDateTakenFromImage(destinationPath))) {
                            DialogResult result = user.remove ? DialogResult.No : DialogResult.Yes;

                            if (user.pause) {
                                result = MessageBox.Show(String.Format("A conflict occurred with the file {0}. Do you still want to {1} the duplicate to the destination directory?",
                                    fileName, user.move ? "move" : "copy"), "File conflict", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            }

                            if (result != DialogResult.Yes) {
                                if (user.move || user.remove)
                                    File.Delete(sourcePath);
                                return false;
                            }
                        }
                        for (int j = 1; File.Exists(destinationPath); j++) {
                            destinationPath = String.Format(@"{0}{1}{2}",
                                user.destination, directoryFormat, fileName.Insert(fileName.LastIndexOf('.'), String.Format("_{0}", j)));
                        }
                    } else if (sourceFile.Length == destinationFile.Length && (user.remove)) {
                        return true;
                    }
                }

                Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));

                switch (user.move) {
                    case true:
                        File.Move(sourcePath, destinationPath);
                        break;
                    case false:
                        File.Copy(sourcePath, destinationPath);
                        break;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return false;
            }

            return true;
        }

        private void ReportProgress(string processLabel = "", int filesProcessed = -1, int numFiles = -1) {
            if (processLabel != "")
                state.progressLabel = processLabel;
            if (numFiles != -1)
                state.numFiles = numFiles;
            if (filesProcessed != -1)
                state.filesProcessed = filesProcessed;

            thread.ReportProgress(0, state);
        }

        private DateTime GetDateTakenFromImage(string path) {
            ImageFile file = ImageFile.FromFile(path);
            ExifProperty val;
            file.Properties.TryGetValue(ExifTag.DateTime, out val);
            DateTime dt = DateTime.Parse(val.Value.ToString());
            return dt;
        }

        void IDisposable.Dispose() {
            state.progressLabel = "Finished";
            thread.ReportProgress(100, state);
        }
    }
}