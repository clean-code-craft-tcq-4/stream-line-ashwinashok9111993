using System;
using Xunit;
using BMSStreamSenderClass;

namespace BMSStreamSenderClass.Tests
{
    public class BMSStreamSenderClassTests
    {
        
        BMSStreamSender sender = new BMSStreamSender();

        [Fact]
        public void TestGetSensorReading()
        {
            Assert.Equal("{\"Temperature\":10,\"StateOfCharge\":20,\"ChargeRate\":0.1}",
                sender.getSensorReading(new SensorData() { StateOfCharge = 20, ChargeRate = 0.1f, Temperature = 10 }));
        }
    }
}
