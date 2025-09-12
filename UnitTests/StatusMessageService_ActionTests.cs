using DataLogicLibrary.Services;
using Xunit;

namespace UnitTests
{
     public class StatusMessageService_ActionTests
     {
         private readonly StatusMessageService _svc = new();

         // STYRTESTER: gas > 0 och ej refuel (6) -> ska INTE visa refuel
         [Theory]
         [InlineData(1)] // left
         [InlineData(2)] // right
         [InlineData(3)] // forward
         [InlineData(4)] // backward
         [InlineData(5)] // rest
         [InlineData(7)] // abort
         public void Test_WithGas_NotRefuel_Actions_Should_Return_NonRefuel_Message(int userInput)
         {
             // Arrange
             var gas = 10;
             var driverName = "Alex";

             // Act
             var msg = _svc.GetCurrentActionMessage(userInput, gas, driverName);

             // Assert
             Assert.False(string.IsNullOrWhiteSpace(msg));
             Assert.DoesNotContain("refuel", msg, StringComparison.OrdinalIgnoreCase);
         }

         // TEST: gas är 0 och ej refuel (6) -> SKA visa refuel
         [Theory]
         [InlineData(1)] // left
         [InlineData(2)] // right
         [InlineData(3)] // forward
         [InlineData(4)] // backward
         [InlineData(5)] // rest
         [InlineData(7)] // abort
         public void Test_ZeroGas_NotRefuel_Actions_Should_Show_Refuel(int userInput)
         {
             // Arrange
             var gas = 0;
             var driverName = "Alex";

             // Act
             var msg = _svc.GetCurrentActionMessage(userInput, gas, driverName);

             // Assert
             Assert.Contains("refuel", msg, StringComparison.OrdinalIgnoreCase);
         }

         // 1 TEST: refuel (6) -> ska visa att bilen tankar
         [Fact]
         public void Test_Refuel_Action_Should_Show_Refuels()
         {
             // Arrange
             var userInput = 6;
             var gas = 0;
             var driverName = "Alex";

             // Act
             var msg = _svc.GetCurrentActionMessage(userInput, gas, driverName);

             // Assert
             Assert.Contains("refuel", msg, StringComparison.OrdinalIgnoreCase);
         }
     }
}


