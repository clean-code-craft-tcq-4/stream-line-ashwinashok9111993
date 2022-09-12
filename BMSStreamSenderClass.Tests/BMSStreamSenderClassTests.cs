using System;
using Xunit;
using BMSStreamSenderClass;

namespace BMSStreamSenderClass.Tests
{
    public class BMSStreamSenderClassTests
    {
        
        BMSStreamSender sender = new BMSStreamSender();

        [Fact]
        public void TestgetCSVWriteLine()
        {
            Assert.Equal
            ("0,2,23,0.4",
              sender.getCSVWriteLine(new SensorData()
                {
                    Timestamp = 0,
                    Temperature = 2,
                    StateOfCharge = 23,
                    ChargeRate = 0.4F,
                }
            ));   
        }

        [Fact]
        public void TestsetSensorDataFromCSV()
        {
            var obj_under_test = sender.setSensorDataFromCSV("0,2,23,0.4");
            Assert.Equal(0,obj_under_test.Timestamp);
            Assert.Equal(0.4f, obj_under_test.ChargeRate);
            Assert.Equal(23,obj_under_test.StateOfCharge);
            Assert.Equal(2, obj_under_test.Temperature);
        }
    }
}
