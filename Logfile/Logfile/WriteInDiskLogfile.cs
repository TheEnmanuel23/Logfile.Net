using System;
using Logfile.Interfaces;
using System.IO;
using System.Reflection;

namespace Logfile
{
    public class WriteInDiskLogfile : IAdvancedLog, ISimpleLog
    {
        public StreamWriter Logfile { get; set; }
        public void Log(string logMessage)
        {
            var projectDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var fileDir = string.Format("{0}\\log.txt", projectDirectory);
            using (Logfile = !File.Exists("log.txt") ? new StreamWriter(fileDir) : File.AppendText("log.txt"))
            {
                Logfile.Write("\r\nLog Entry");
                Logfile.WriteLine("Data Time:" + DateTime.Now);
                Logfile.WriteLine("  :");
                Logfile.WriteLine("  :{0}", logMessage);
                Logfile.WriteLine("-------------------------------");
            }
        }

        public void Log(Loginfo _logInfo)
        {
            try
            {
                if (!File.Exists("log.txt"))
                    Logfile = new StreamWriter("log.txt");
                else
                    Logfile = File.AppendText("log.txt");

                Logfile.Write("\r\nLog Entry");
                Logfile.WriteLine("Data Time:" + DateTime.Now);
                Logfile.WriteLine("Exception Name:" + _logInfo.ExceptionName);
                Logfile.WriteLine("Event Name:" + _logInfo.EventName);
                Logfile.WriteLine("Control Name:" + _logInfo.ControlName);
                Logfile.WriteLine("Error Line No.:" + _logInfo.ErrorLineNum);
                Logfile.WriteLine("Form Name:" + _logInfo.MainName);
                Logfile.WriteLine("-------------------------------");
                Logfile.Close();
            }
            catch(Exception ex)
            {
                Logfile.Dispose();
                this.Log(ex.Message);
            }
        }
    }
}
