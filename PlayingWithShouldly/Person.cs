using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithShouldly
{
    public class Person
    {
        public DateTime DateOfBirth { get; private set; }

        public Person(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }
    }
}
