using Xunit;
using Radio_Room.UI;

namespace Radio_Room.Tests
{
    public class Radio_Room_IsWorkingShould
    {
        [Fact]
        public void IsWorking_InputIs1_ReturnFalse()
        {
            var dialogueResponse = new TestClass();
            bool result = dialogueResponse.IsWorking(1);

            Assert.False(result, "1 should not be the response");
        }
    }
}