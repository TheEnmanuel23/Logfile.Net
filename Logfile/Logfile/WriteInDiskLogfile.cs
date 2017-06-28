using System;
using Logfile.Interfaces;
using System.IO;
using System.Reflection;

namespace Logfile
{
    public class WriteInDiskLogfile : IAdvancedLog, ISimpleLog
    {
        public StreamWriter Logfile { get; set; }
        private string projectDirectory {
            get
            {
                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            }
        }
        private string FileDir {
            get
            {
                return string.Format("{0}\\log.txt", this.projectDirectory);
            }
        }
        public void Log(string logMessage)
        {
            using (Logfile = !File.Exists("log.txt") ? new StreamWriter(this.FileDir) : File.AppendText("log.txt"))
            {
                Logfile.WriteLine("\r\n>>Log Entry");
                Logfile.WriteLine("Data Time: {0}", DateTime.Now);
                Logfile.WriteLine("Message: {0}", logMessage);
                Logfile.WriteLine("-------------------------------");
            }
        }

        public void Log(Loginfo _logInfo)
        {
            if (_logInfo == null)
            {
                Loginfo info = new Loginfo();
                Log(info);
                return;
            }

            using (Logfile = !File.Exists("log.txt") ? new StreamWriter(this.FileDir) : File.AppendText("log.txt"))
            {
                Logfile.WriteLine("\r\n>>Log Entry");
                Logfile.WriteLine("Data Time: {0}", DateTime.Now);
                Logfile.WriteLine("Exception Name: {0}", _logInfo.ExceptionName);
                Logfile.WriteLine("Event Name: {0}", _logInfo.EventName);
                Logfile.WriteLine("Control Name: {0}", _logInfo.ControlName);
                Logfile.WriteLine("Error Line No.: {0}", _logInfo.ErrorLineNum);
                Logfile.WriteLine("Form Name: {0}", _logInfo.MainName);
                Logfile.WriteLine("-------------------------------");
            }
        }
    }
}
