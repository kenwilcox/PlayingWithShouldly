using PlayingWithShouldly.EnemyObjects;
using Shouldly;

namespace PlayingWithShouldly.Tests
{
    public class EnemyFactoryTests
    {
        public void ShouldCreateBoxxEnemy()
        {
            var factory = new EnemyFactory();
            var boss = factory.Create(true);
            boss.ShouldBeOfType<BossEnemy>();
            // This fails, has to be exact, not inherited
            //boss.ShouldBeOfType<Enemy>();

            boss.ShouldBeAssignableTo<Enemy>();
        }

        public void ShouldCreateBossEnemyWithCorrectPower()
        {
            var factory = new EnemyFactory();
            var boss = factory.Create(true);
            var bossEnemy = boss.ShouldBeOfType<BossEnemy>();
            bossEnemy.ExtraPower.ShouldBe(42);
        }
    }
}
