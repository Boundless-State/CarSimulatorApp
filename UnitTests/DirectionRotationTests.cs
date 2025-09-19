using DataLogicLibrary.DirectionStrategies;
using DataLogicLibrary.DirectionStrategies.Interfaces;
using DataLogicLibrary.DTO;
using DataLogicLibrary.Infrastructure.Enums;

namespace UnitTests
{
    public class DirectionRotationTests
    {

        [Fact]
        public void Left_From_North_Should_Be_West()
        {
            // Arrange
            IDirectionContext ctx = new DirectionContext();
            ctx.SetStrategy(new TurnLeftStrategy());
            var status = new StatusDTO { CardinalDirection = CardinalDirection.North, GasValue = 10, EnergyValue = 50 };

            // Act
            var next = ctx.ExecuteStrategy(status);

            // Assert
            Assert.Equal(CardinalDirection.West, next.CardinalDirection);
        }

        [Fact]
        public void Left_From_West_Should_Be_South()
        {
            // Arrange
            IDirectionContext ctx = new DirectionContext();
            ctx.SetStrategy(new TurnLeftStrategy());
            var status = new StatusDTO { CardinalDirection = CardinalDirection.West, GasValue = 10, EnergyValue = 50 };

            // Act
            var next = ctx.ExecuteStrategy(status);

            // Assert
            Assert.Equal(CardinalDirection.South, next.CardinalDirection);
        }

        [Fact]
        public void Left_From_South_Should_Be_East()
        {
            // Arrange
            IDirectionContext ctx = new DirectionContext();
            ctx.SetStrategy(new TurnLeftStrategy());
            var status = new StatusDTO { CardinalDirection = CardinalDirection.South, GasValue = 10, EnergyValue = 50 };

            // Act
            var next = ctx.ExecuteStrategy(status);

            // Assert
            Assert.Equal(CardinalDirection.East, next.CardinalDirection);
        }

        [Fact]
        public void Left_From_East_Should_Be_North()
        {
            // Arrange
            IDirectionContext ctx = new DirectionContext();
            ctx.SetStrategy(new TurnLeftStrategy());
            var status = new StatusDTO { CardinalDirection = CardinalDirection.East, GasValue = 10, EnergyValue = 50 };

            // Act
            var next = ctx.ExecuteStrategy(status);

            // Assert
            Assert.Equal(CardinalDirection.North, next.CardinalDirection);
        }

        [Fact]
        public void Right_From_North_Should_Be_East()
        {
            // Arrange
            IDirectionContext ctx = new DirectionContext();
            ctx.SetStrategy(new TurnRightStrategy());
            var status = new StatusDTO { CardinalDirection = CardinalDirection.North, GasValue = 10, EnergyValue = 50 };

            // Act
            var next = ctx.ExecuteStrategy(status);

            // Assert
            Assert.Equal(CardinalDirection.East, next.CardinalDirection);
        }

        [Fact]
        public void Right_From_East_Should_Be_South()
        {
            // Arrange
            IDirectionContext ctx = new DirectionContext();
            ctx.SetStrategy(new TurnRightStrategy());
            var status = new StatusDTO { CardinalDirection = CardinalDirection.East, GasValue = 10, EnergyValue = 50 };

            // Act
            var next = ctx.ExecuteStrategy(status);

            // Assert
            Assert.Equal(CardinalDirection.South, next.CardinalDirection);
        }

        [Fact]
        public void Right_From_South_Should_Be_West()
        {
            // Arrange
            IDirectionContext ctx = new DirectionContext();
            ctx.SetStrategy(new TurnRightStrategy());
            var status = new StatusDTO { CardinalDirection = CardinalDirection.South, GasValue = 10, EnergyValue = 50 };

            // Act
            var next = ctx.ExecuteStrategy(status);

            // Assert
            Assert.Equal(CardinalDirection.West, next.CardinalDirection);
        }

        [Fact]
        public void Right_From_West_Should_Be_North()
        {
            // Arrange
            IDirectionContext ctx = new DirectionContext();
            ctx.SetStrategy(new TurnRightStrategy());
            var status = new StatusDTO { CardinalDirection = CardinalDirection.West, GasValue = 10, EnergyValue = 50 };

            // Act
            var next = ctx.ExecuteStrategy(status);

            // Assert
            Assert.Equal(CardinalDirection.North, next.CardinalDirection);
        }

        [Fact]
        public void Forward_Should_Not_Change_CardinalDirection()
        {
            // Arrange
            IDirectionContext ctx = new DirectionContext();
            ctx.SetStrategy(new DriveForwardStrategy());
            var status = new StatusDTO { CardinalDirection = CardinalDirection.South, GasValue = 10, EnergyValue = 50 };

            // Act
            var next = ctx.ExecuteStrategy(status);

            // Assert
            Assert.Equal(CardinalDirection.South, next.CardinalDirection);
        }

    }
}
