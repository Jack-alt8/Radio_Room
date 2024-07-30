using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radio_Room.UI;
using Radio_Room.UI.Components.Pages;


namespace Radio_Room.Tests
{
    public class OpenWebApi_IsWorkingShould
    {
        [Fact]
        public void IsWorking_InputIsWeather_ReturnFalse()
        {
            var apiCall = new ApiTestClass();
            bool result = apiCall.IsWorking("");

            Assert.False(result, "The OpenWeather API is not working, please check that you have the correct" +
                " api key and api call code. And restart.");
        }
    }
}
