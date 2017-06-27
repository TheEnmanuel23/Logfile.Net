using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logfile
{
    public class Loginfo
    {
        public string ExceptionName { get; set; }
        public string EventName { get; set; }
        public string ControlName { get; set; }
        public int ErrorLineNum { get; set; }
        public string MainName { get; set; }
    }
}
