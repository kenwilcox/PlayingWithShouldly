using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithShouldly
{
    public class NameJoiner
    {
        public string JoinUpper(string firstName, string lastName)
        {
            return firstName.ToUpperInvariant() + " " + lastName.ToUpperInvariant();
        }

    }
}
