namespace BackUpAlghoritm
{
    internal class HDD : Storage, IStorage
    {
        public double Memory { set; get; }
        public HDD(string mediaName, string modelName, double memory) : base(mediaName, modelName)
        {
            Memory = memory;
        }

        public double USBSpeed { get => 2.0; }

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
            Console.WriteLine($"USB Speed : {USBSpeed}");
        }

        public void SizeOfMedia()
        {
            Console.WriteLine($"{Memory} GB of Media");
        }


    }
}
