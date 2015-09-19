using System;
using System.IO;

namespace IoC_Learning
{
    public class FileLogger : Interfaces.ILogger
    {
        /// <summary>
        /// The stream writer
        /// </summary>
        private StreamWriter streamWriter = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileLogger"/> class.
        /// </summary>
        /// <param name="loggerFileName">Name of the logger file.</param>
        public FileLogger(string loggerFileName = default(string))
        {
            if (!string.IsNullOrEmpty(loggerFileName))
            {
                FileName = loggerFileName;
            }
        }

        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; private set; } = Environment.CurrentDirectory + @"/tmp/fileLog.txt";

        /// <summary>
        /// Closes the log.
        /// </summary>
        public void CloseLog()
        {
            if (streamWriter != null)
            {
                streamWriter.Close();
                streamWriter.Dispose();
                streamWriter = null;
            }
        }

        /// <summary>
        /// Logs the specified log MSG.
        /// </summary>
        /// <param name="logMsg">The log MSG.</param>
        public void Log(string logMsg)
        {
            if (streamWriter != null)
            {
                streamWriter.WriteLine(
                    string.Format("{0:dd}/{0:MM}/{0:yyyy} ", DateTime.Now)
                    + string.Format("{0:hh}:{0:mm}:{0:ss} {0:tt} ", DateTime.Now)
                    + string.Format($"Log message : {logMsg}"));
                streamWriter.WriteLine("-------------------------------------------"
                                     + "-------------------------------------------");
            }
        }

        /// <summary>
        /// Opens the log.
        /// </summary>
        public void OpenLog()
        {
            DirectoryInfo loggerDirInfo;
            var loggerFilePath = Path.GetDirectoryName(FileName);

            if (!Directory.Exists(loggerFilePath))
            {
                loggerDirInfo = Directory.CreateDirectory(loggerFilePath);
            }
            else
            {
                loggerDirInfo = new DirectoryInfo(loggerFilePath);
            }

            if ((loggerDirInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                loggerDirInfo.Attributes &= ~FileAttributes.ReadOnly;
            }
            streamWriter = new StreamWriter(File.Open(FileName, FileMode.Append));
            streamWriter.AutoFlush = true;
        }
    }
}