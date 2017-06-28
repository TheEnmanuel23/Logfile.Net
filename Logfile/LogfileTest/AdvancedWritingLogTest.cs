using Logfile;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace LogfileTest
{
    [TestClass]
    public class AdvancedWritingLogTest
    {
        [TestMethod]
        public void TestWhenIsNull()
        {
            var writeLog = new WriteInDiskLogfile();
            Loginfo info = null;
            writeLog.Log(info);
            Assert.AreNotEqual(StreamWriter.Null, writeLog.Logfile);
        } 

        [TestMethod]
        public void TestSuccess()
        {
            var writeLog = new WriteInDiskLogfile();
            Loginfo info = new Loginfo();
            info.ControlName = "Mi control";
            info.ErrorLineNum = 12;
            info.ExceptionName = "Error de division entre cero";
            info.MainName = "Oficina virtual";
            info.EventName = "Main oficina virtual";
            writeLog.Log(info);
            Assert.AreNotEqual(StreamWriter.Null, writeLog.Logfile);
        }
    }
}
