using Shouldly;

namespace PlayingWithShouldly.Tests
{
    class FixiePlayerCharacterTests
    {
        public void ShouldHaveASmallShield()
        {
            var playerCharacter = new PlayerCharacter();
            playerCharacter.Weapons.ShouldContain("Small Shield");
        }
    }
}
