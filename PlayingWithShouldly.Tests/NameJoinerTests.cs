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

    }
}
