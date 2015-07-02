using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PlayingWithShouldly.Tests
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        [Test]
        public void ShouldNotHaveAStaffOfWonder()
        {
            var playerCharacter = new PlayerCharacter();
            Assert.That(playerCharacter.Weapons, Has.No.Member("Staff of Wonder"));
        }
    }
}
