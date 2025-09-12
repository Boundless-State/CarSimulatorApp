using DataLogicLibrary.DirectionStrategies;
using DataLogicLibrary.DirectionStrategies.Interfaces;
using DataLogicLibrary.DTO;
using DataLogicLibrary.Infrastructure.Enums;
using DataLogicLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class DirectionStrategyTests
    {
        // 4 TESTER: varje strategi sätter rätt MovementAction
        [Theory]
        [InlineData("forward",  MovementAction.Forward)]
        [InlineData("left",     MovementAction.Left)]
        [InlineData("right",    MovementAction.Right)]
        [InlineData("backward", MovementAction.Backward)]
        public void Strategy_Should_Set_Expected_MovementAction(string strategyName, MovementAction expected)
        {
            // Arrange
            IDirectionStrategy strategy = CreateStrategy(strategyName);
            IDirectionContext ctx = new DirectionContext();
            ctx.SetStrategy(strategy);

            var status = new StatusDTO
            {
                CardinalDirection = CardinalDirection.North,
                GasValue = 10,
                EnergyValue = 50
            };

            // Act
            var next = ctx.ExecuteStrategy(status);

            // Assert
            Assert.Equal(expected, next.MovementAction);
        }

        
    }
}
