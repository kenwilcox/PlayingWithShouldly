using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace PlayingWithShouldly.Tests
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        [Test]
        public void ShouldNotHaveAStaffOfWonder()
        {
            var playerCharacter = new PlayerCharacter();
            // NUnit
            //Assert.That(playerCharacter.Weapons, Has.No.Member("Staff of Wonder"));
            // Shouldly
            playerCharacter.Weapons.ShouldNotContain("Staff of Wonder");
        }

       [Test]
        public void ShouldHaveALongBow()
        {
            var playerCharacter = new PlayerCharacter();
            // NUnit
            //Assert.That(playerCharacter.Weapons, Has.Member("Long Bow"));
            //Shouldly
            playerCharacter.Weapons.ShouldContain("Long Bow");
        }

        [Test]
        public void ShouldHaveAtLeaseOneKindOfSword()
        {
            var playerCharacter = new PlayerCharacter();
            // NUnit
            //Assert.That(playerCharacter.Weapons, Has.Some.Contains("Sword"));
            // Shouldly
            playerCharacter.Weapons.ShouldContain(p => p.Contains("Sword"));
        }
    }
}
