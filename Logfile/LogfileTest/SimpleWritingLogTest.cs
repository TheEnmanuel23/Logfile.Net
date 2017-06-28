using Logfile;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace LogfileTest
{
    [TestClass]
    public class SimpleWritingLogTest
    {
        [TestMethod]
        public void TestLog()
        {
            var writeLog = new WriteInDiskLogfile();
            writeLog.Log("Error to run application");
            Assert.AreNotEqual(StreamWriter.Null, writeLog.Logfile);
        }
        public void TestWhenIsNull()
        {
            var writeLog = new WriteInDiskLogfile();
            string varNull = null;
            writeLog.Log(varNull);
            Assert.AreNotEqual(StreamWriter.Null, writeLog.Logfile);
        }
    }
}
