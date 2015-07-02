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

    }
}
