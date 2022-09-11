using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using BMSStreamSenderClass;


namespace SenderCLI
{
    class Program
    {

        public static void Main(string[] args)
        {
            
            BMSStreamSender sender = new BMSStreamSender();         
           
            try
            {
                var CommandLineDict = JsonSerializer.Deserialize<Dictionary<string, string>>(
                    String.Join(' ', args)
                    .Replace('\'', '\"'));

                
                
                    if (CommandLineDict["method"].Equals("mock") && Int16.Parse(CommandLineDict["numElements"]) < 200)
                    {
                        sender.generateMockSequence(Int16.Parse(CommandLineDict["numElements"])).ForEach(x => Console.WriteLine(sender.getCSVWriteLine(x)));
                    }
                    if (CommandLineDict["method"].Equals("file") && File.Exists("SampleTestData.txt"))
                    {
                            sender.PipeCSVFileData("SampleTestData.txt");
                    }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
