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
    }
}
