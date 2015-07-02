using Shouldly;

namespace PlayingWithShouldly.Tests
{
    class FixiePlayerCharacterTests
    {
        public FixiePlayerCharacterTests()
        {
            ShouldlyConfiguration.DefaultFloatingPointTolerance = 0.001;
        }

        public void ShouldHaveASmallShield()
        {
            var playerCharacter = new PlayerCharacter();
            playerCharacter.Weapons.ShouldContain("Small Shield");
        }

        public void DamageShouldTakeAwayHitPoints()
        {
            var playerCharacter = new PlayerCharacter();
            var currentHitPoints = playerCharacter.HitPoints;
            const int damage = 5;
            playerCharacter.TakeDamage(damage).ShouldBe(currentHitPoints - damage);
            playerCharacter.HitPoints.ShouldBe(currentHitPoints - damage);
        }

        public void PotionsShouldAddHitPoints()
        {
            var playerCharacter = new PlayerCharacter();
            var currentHitPoints = playerCharacter.HitPoints;
            const int potion = 5;
            playerCharacter.TakePotion(potion).ShouldBe(currentHitPoints + potion);
            playerCharacter.HitPoints.ShouldBe(currentHitPoints + potion);
        }

        public void MagicDamageTakesAPercentageOfHitPoints()
        {
            var playerCharacter = new PlayerCharacter();
            var currentHitPoints = playerCharacter.HitPoints;
            var percent = 10;
            var percentage = currentHitPoints * (percent / 100.0);
            playerCharacter.MagicDamage(percent).ShouldBe(currentHitPoints - percentage);
        }

        public void ShouldBeNoobByDefault()
        {
            var playerCharacter = new PlayerCharacter();
            playerCharacter.IsNoob.ShouldBe(true);
        }

        public void ShouldHaveADefaultName()
        {
            var playerCharacter = new PlayerCharacter();
            playerCharacter.Name.ShouldNotBe(null);
        }

        public void ShouldNotHaveANullName()
        {
            var playerCharacter = new PlayerCharacter {Name = null};
            playerCharacter.Name.ShouldNotBe(null);
        }

        public void ShouldNotHaveAnEmptyName()
        {
            var playerCharacter = new PlayerCharacter { Name = "" };
            playerCharacter.Name.ShouldNotBeNullOrEmpty();
        }

        public void JustTestingOutDoublesWithShouldly()
        {
            var playerCharacter = new PlayerCharacter();
            // The additional parameter is a floating point tolerance
            // This uses the configured tolerance assigned in the constructor
            playerCharacter.AddDoubles(1.1, 2.2).ShouldBe(3.3);
            // This tolerance is to high, it passes
            playerCharacter.AddDoubles(1.1, 2.2).ShouldBe(3.4, 0.1);
        }

        public void JustTestingOutDoublesWithShouldlyAgain()
        {
            var playerCharacter = new PlayerCharacter();
            // The additional parameter is a floating point tolerance
            // This uses the configured tolerance assigned in the constructor
            playerCharacter.AddDoubles(1.1, 2.2).ShouldNotBe(0);
        }
    }
}
