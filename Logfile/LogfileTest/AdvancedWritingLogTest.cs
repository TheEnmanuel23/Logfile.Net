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
    }
}
