using System;
using Xunit;

namespace GameModel.Tests
{
    public class HeroTest
    {
        [Fact]
        public void IsAlive_HitPointsAreAboveZero_ShouldReturnTrue()
        {
            // Arrange
            var hero = new Hero {HitPoints = 1 };
            // Act
            var result=hero.IsAlive();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAlive_HitPointsAreZero_ShouldReturnFalse()
        {
            // Arrange
            var hero = new Hero {HitPoints = 0 };
            // Act
            var result=hero.IsAlive();

            // Assert
            Assert.False(result);
        }
        
        [Fact]
        public void IsAlive_HitPointsAreBelowZero_ShouldReturnFalse()
        {
            // Arrange
            var hero = new Hero {HitPoints = -1 };
            // Act
            var result=hero.IsAlive();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Attack_NotAlive_ShouldReturnZero()
        {
            // Arrange
            var hero = new Hero {HitPoints = 0, Strength=6 };
            // Act
            var result=hero.Attack();

            // Assert
            Assert.True(result==0);
        }

        [Fact]
        public void Attack_WithoutWeapon_ShouldReturnAttackValueFromStrengthOnly()
        {
            // Arrange
            var hero = new Hero {HitPoints = 1, Strength=6 };
        
            // Act
            var result=hero.Attack();

            // Assert
            Assert.Equal(3,result);
        }

        [Fact]
        public void Attack_WithWeaponWithAttackOne_ShouldReturnAttackValue()
        {
            // Arrange
            var sword = new Weapon{Attack=1};
            var hero = new Hero {HitPoints = 1, Strength =  6, MainHandWeapon = sword };
           
            // Act
            var result=hero.Attack();

            // Assert
            Assert.Equal((sword.Attack*hero.Strength)/2,result);
        }

        [Fact]
        public void Attack_WithWeapon_ShouldReturnAttackValue()
        {
            
        }

        [Fact]
        public void Defend_WithDefenceZero_ShouldSubtractFromHitPoints()
        {

        }

        [Fact]
        public void Defend_WithDefenceAboveZero_ShouldSubtractFromHitpoints()
        {

        }

        [Fact]
        public void Defend_IsKilledFromAttack_HitPointsShouldNotGoBelowZero()
        {

        }

        [Fact]
        public void Defend_OpponentIsNull_ShouldThrowArgumentNullException()
        {

        }
    }
}
