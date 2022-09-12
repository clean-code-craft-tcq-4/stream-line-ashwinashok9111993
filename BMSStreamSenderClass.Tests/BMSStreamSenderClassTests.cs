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
            Assert.Equal(obj_under_test.Timestamp,0);
            Assert.Equal(obj_under_test.ChargeRate, 0.4f);
            Assert.Equal(obj_under_test.StateOfCharge, 23);
            Assert.Equal(obj_under_test.Temperature, 2);
        }
    }
}
