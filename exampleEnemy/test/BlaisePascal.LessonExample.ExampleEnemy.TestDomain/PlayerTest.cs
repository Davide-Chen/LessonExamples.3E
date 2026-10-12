using BlaisePascal.LessonExample.ExampleEnemy.Domain;

namespace BlaisePascal.LessonExample.ExampleEnemy.TestDomain
{
    public class PlayerTest
    {
        [Fact]
        public void Player_ShouldStartAtLevelOne()
        {
            //Arrange - Act (chiamata del costruttore in questo caso)
            Player player = new Player("Mario");

            
            Assert.Equal(1, player.Level);
        }

        [Fact]
        public void Player_ShouldGainExperienceAndLevelUp()
        {
            
            Player player = new Player("Mario");
            
            player.AddExperience(150);
            
            Assert.Equal(2, player.Level);
            Assert.Equal(50, player.Experience);
        }

        [Fact]
        public void Player_ShouldNotHaveNegativeExperience()
        {
            
            Player player = new Player("Mario");
            
            player.AddExperience(-50);
            
            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void Player_ShouldStartAt100HP()
        {
            
            Player player = new Player("Mario");
            
            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void Player_shouldAtStartBeALive()
        {
            Player player = new Player("Mario");

            Assert.True(player.IsAlive);
        }

        [Fact]
        public void Player_ShouldTakeDamageAndDie()
        {
            
            Player player = new Player("Mario");

            player.TakeDamage(120);

            Assert.Equal(0, player.Health);
            Assert.False(player.IsAlive);
        }

        [Fact]
        public void Player_ShouldBeAliveAfterHealing()
        {
            Player player = new Player("Mario");

            player.TakeDamage(100);
            Assert.False(player.IsAlive);

            player.Heal(50);
            Assert.True(player.IsAlive);
        }

        [Fact]
        public void Player_ShouldNotTakeNegativeOrZeroDamage()
        {
            Player player = new Player("Mario");
            
            player.TakeDamage(-50);
            Assert.Equal(100, player.Health);
            
            player.TakeDamage(0);
            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void Player_ShouldHealAndNotExceedMaxHealth()
        {
            Player player = new Player("Mario");
            
            player.TakeDamage(50);
            player.Heal(30);
            Assert.Equal(80, player.Health);
            
            player.Heal(50);
            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void Player_ShouldNotHealNegativeAmount()
        {
            Player player = new Player("Mario");

            player.TakeDamage(50);
            player.Heal(-30);

            Assert.Equal(50, player.Health);
        }

        [Fact]
        public void Player_ShouldStartWithZeroGold()
        {
            Player player = new Player("Mario");
            
            Assert.Equal(0, player.Gold);
        }

        [Fact]
        public void Player_ShouldAddGold()
        {
            Player player = new Player("Mario");
            
            player.AddGold(100);
            Assert.Equal(100, player.Gold);
        }

        [Fact]
        public void Player_shouldNotHaveNegativeGold()
        {
            Player player = new Player("Mario");
            
            player.AddGold(-50);
            Assert.Equal(0, player.Gold);
        }

        [Fact]
        public void Player_ShouldResetExperience()
        {
            Player player = new Player("Mario");
            
            player.AddExperience(50);
            player.ResetExperience();
            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void Player_ShouldResetHealth()
        {
            Player player = new Player("Mario");
            
            player.TakeDamage(50);
            player.ResetHealth();
            
            Assert.Equal(100, player.Health);
            Assert.True(player.IsAlive);
        }
        
    }
}
