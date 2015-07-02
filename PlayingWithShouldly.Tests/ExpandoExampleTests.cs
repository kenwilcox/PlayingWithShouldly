using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace PlayingWithShouldly.Tests
{
    public class ExpandoExampleTests
    {
        public void ShouldHaveProperty()
        {
            dynamic person = new ExpandoObject();
            person.Name = "Sarah";
            person.Age = 27;

            DynamicShould.HaveProperty(person, "Name");
            DynamicShould.HaveProperty(person, "Age");
        }
    }
}
