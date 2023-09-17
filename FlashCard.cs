namespace BackUpAlghoritm
{
    internal class FlashCard : Storage, IStorage
    {
        private double usbSpeed;
        public double USBSpeed
        {
            set
            {
                if (value > 0)
                {
                    usbSpeed = value;
                }
            }
            get => 3;
        }

        public double Memory { set; get; }

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

        public FlashCard(string mediaName, string modelName,  double memory)
         : base(mediaName, modelName)
        {
            Memory = memory;
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
