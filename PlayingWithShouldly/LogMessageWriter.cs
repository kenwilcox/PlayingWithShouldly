using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlayingWithShouldly
{
    public static class LogMessageWriter
    {
        public static void Write(LogMessageEntry message)
        {
            message.MessageSavedTime = DateTime.Now;
            // simulate writing message to log store
            Thread.Sleep(100);
        }
    }
}
