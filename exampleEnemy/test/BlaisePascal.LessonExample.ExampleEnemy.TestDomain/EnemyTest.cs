using Xunit;
using BlaisePascal.LessonExample.ExampleEnemy.Domain;

namespace BlaisePascal.LessonExample.ExampleEnemy.TestDomain
{
    public class EnemyTest
    {
        [Fact]
        public void Enemy_ShouldStartWithGivenHealth()
        {
            
            Enemy enemy = new Enemy("Goblin", 80, 10);
            
            int health = enemy.Health;
            
            Assert.Equal(80, health);
        }

        [Fact]
        public void Enemy_ShouldStartWithGivenDamage()
        {

            Enemy enemy = new Enemy("Goblin", 80, 10);

            int damage = enemy.Damage;

            Assert.Equal(10, damage);
        }

        [Fact]
        public void Enemy_ShouldNotHaveNegativeHealth()
        {
            
            Enemy enemy = new Enemy("Goblin", 80, 10);
            
            enemy.Health = -50;
            
            Assert.Equal(0, enemy.Health);
        }

        [Fact]
        public void Enemy_ShouldNotExceedMaxHealth()
        {
            
            Enemy enemy = new Enemy("Goblin", 80, 10);
            
            enemy.Health = 150;
            
            Assert.Equal(100, enemy.Health);
        }

        [Fact]
        public void Enemy_ShouldTakeDamage()
        {
            
            Enemy enemy = new Enemy("Goblin", 80, 10);
            
            enemy.Health -= 30;
            
            Assert.Equal(50, enemy.Health);
        }

        [Fact]
        public void Enemy_ShouldNotTakeNegativeDamage()
        {
            
            Enemy enemy = new Enemy("Goblin", 80, 10);
            
            enemy.Health -= -30;
            
            Assert.Equal(80, enemy.Health);
        }

        [Fact]
        public void Enemy_ShouldNotExceedMaxHealthWhenHealing()
        {
            
            Enemy enemy = new Enemy("Goblin", 80, 10);
            
            enemy.Health += 30;
            
            Assert.Equal(100, enemy.Health);
        }


    }
}
