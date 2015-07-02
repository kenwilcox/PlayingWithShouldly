using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithShouldly
{
    public class LogMessageEntry
    {
        public string Message { get; private set; }
        public DateTime MessageSavedTime { get; set; }

        public LogMessageEntry(string message)
        {
            Message = message;
        }
    }
}
