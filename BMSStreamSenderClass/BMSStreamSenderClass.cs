using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;

namespace BMSStreamSenderClass
{
    public class SensorData
    {
        public int Timestamp { get; set; }
        public float Temperature { get; set; }
        public float StateOfCharge { get; set; }
        public float ChargeRate { get; set; }
        
    }

    public class BMSStreamSender
    {
        public string getCSVWriteLine(SensorData sensorData)
        {
            return $"{sensorData.Timestamp},{sensorData.Temperature},{sensorData.StateOfCharge},{sensorData.ChargeRate}";
        }

        public SensorData setSensorDataFromCSV(string CSVData)
        {
            if(!string.IsNullOrEmpty(CSVData))
            {
                //Put more Conditions here
                var splitdata = CSVData.Trim().Split(',').ToList();
                    return new SensorData()
                    {
                        Timestamp = Convert.ToInt32(splitdata[0]),
                        Temperature = Convert.ToInt32(splitdata[1]),
                        StateOfCharge = Convert.ToInt32(splitdata[2]),
                        ChargeRate = Convert.ToSingle(splitdata[3]),
                    }; 
                
            }
            else
            {
                return null;
            }
        }

        public void PipeCSVFileData(string path)
        {
            foreach(string data in File.ReadAllLines(path))
            {
                Console.WriteLine(getCSVWriteLine(setSensorDataFromCSV(data)));
            }
        }
    }
}
