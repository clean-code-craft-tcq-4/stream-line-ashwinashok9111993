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
            sender.PipeCSVFileData("SampleTestData.txt");
        }
    }
}
