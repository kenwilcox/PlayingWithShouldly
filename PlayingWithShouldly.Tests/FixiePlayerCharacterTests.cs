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
    }
}
