using System;

namespace BackUpAlghoritm
{
    internal class DVD : Storage, IStorage
    {
        public double ReadAndWriteSpeed { get => 9.0; }

        public string Type { set; get; }

        public double Memory { set; get; }
        public DVD(string mediaName, string modelName,
            string Type, double memory) : base(mediaName, modelName)
        {
            this.Type = Type;
            Memory = memory;
        }

        public void Copy(double data)
        {
            if (data * 1024 < Memory)
            {
                Memory -= data * 1024;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Data Copied succesfully");
                Console.ResetColor();
            }
            else
            {
                throw new Exception("Data flows Flash Cards Size");
            }
        }
        public void FreeMemory()
        {
            Console.WriteLine($"{Memory} of Free Memory");
        }

        public void PrintDeviceInfo()
        {
            base.Printdeviceinfo();
            Console.WriteLine($"Read And Write Speed : {ReadAndWriteSpeed}");
        }

        public void SizeOfMedia()
        {
            Console.WriteLine($"{Memory} GB of Media");
        }
    }
}
