using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logfile
{
    public class Loginfo
    {
        private string exceptionName = "Instance is null";
        private string eventName = "Writing in logfile for implement class";
        private string controlName = "Client";
        private int errorLineNum = 37;
        private string mainName = "Loginfo";

        public string ExceptionName
        {
            get
            {
                return exceptionName;
            }
            set
            {
                exceptionName = value;
            }
        }
        public string EventName
        {
            get
            {
                return eventName;
            }
            set
            {
                eventName = value;
            }
        }
        public string ControlName
        {
            get
            {
                return controlName;
            }
            set
            {
                controlName = value;
            }
        }
        public int ErrorLineNum
        {
            get
            {
                return errorLineNum;
            }
            set
            {
                errorLineNum = value;
            }
        }
        public string MainName
        {
            get
            {
                return mainName;
            }
            set
            {
                mainName = value;
            }
        }
    }
}
