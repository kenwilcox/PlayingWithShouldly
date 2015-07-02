using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace PlayingWithShouldly.Tests
{
    public class NameJoinerTests
    {
        public void ShouldJoinNamesCaseInsensitive()
        {
            var nameJoiner = new NameJoiner();
            nameJoiner.JoinUpper("Sarah", "Connor").ShouldBe("Sarah Connor", Case.Insensitive);
        }

        public void ShouldJoinNamesCaseSensitive()
        {
            var nameJoiner = new NameJoiner();
            nameJoiner.JoinUpper("Sarah", "Connor").ShouldBe("SARAH CONNOR", Case.Sensitive);
        }

        public void ShouldJoinNamesNotAMatch()
        {
            var nameJoiner = new NameJoiner();
            nameJoiner.JoinUpper("Sarah", "Connor").ShouldNotBe("Sarah O'Connor");
        }
        public void ShouldJoinNamesNotAMatchCustomMessage()
        {
            var nameJoiner = new NameJoiner();
            nameJoiner.JoinUpper("Sarah", "Connor").ShouldNotBe("SARAH O'CONNOR", "Just checking out custom messages");
        }

        public void ShouldContainFirstName()
        {
            var nameJoiner = new NameJoiner();
            nameJoiner.Join("Sarah", "Connor").ShouldContain("Sarah");
        }

        public void ShouldNotContain()
        {
            var nameJoiner = new NameJoiner();
            nameJoiner.Join("Sarah", "Connor").ShouldNotContain("Ken");
        }

        public void ShouldStartWithFirstName()
        {
            var nameJoiner = new NameJoiner();
            nameJoiner.Join("Sarah", "Connor").ShouldStartWith("Sarah");
        }

        public void ShouldNotContainFirstName()
        {
            var nameJoiner = new NameJoiner();
            nameJoiner.Join("Sarah", "Connor").ShouldNotStartWith("Ken");
        }

        public void ShouldEndWithLastName()
        {
            var nameJoiner = new NameJoiner();
            nameJoiner.Join("Sarah", "Connor").ShouldEndWith("Connor");
        }

        public void ShouldNotEndWithLastName()
        {
            var nameJoiner = new NameJoiner();
            nameJoiner.Join("Sarah", "Connor").ShouldNotEndWith("Reese");
        }

        public void ShouldMatchRegularExpression()
        {
            var nameJoiner = new NameJoiner();
            nameJoiner.Join("Sarah", "Connor").ShouldMatch("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+");
        }

    }
}
