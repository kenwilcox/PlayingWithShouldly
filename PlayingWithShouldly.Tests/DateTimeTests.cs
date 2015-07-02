using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace PlayingWithShouldly.Tests
{
    public class DateTimeTests
    {
        public void ShouldSetPersonDateOfBirth()
        {
            var birthdate = new DateTime(1900, 1, 25);
            var person = new Person(birthdate);
            person.DateOfBirth.ShouldBe(birthdate);
        }

        public void ShouldSetSavedTime()
        {
            var logMessageEntry = new LogMessageEntry("Test message");
            LogMessageWriter.Write(logMessageEntry);

            // The additional argument is the tolerance
            logMessageEntry.MessageSavedTime.ShouldBe(DateTime.Now, TimeSpan.FromMilliseconds(150));
        }
    }
}
