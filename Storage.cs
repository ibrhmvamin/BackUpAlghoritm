namespace BackUpAlghoritm
{
    internal abstract class Storage
    {
        public string MediaName { get; set; }
        public string ModelName { get; set; }

        public Storage(string mediaName, string modelName)
        {
            MediaName = mediaName;
            ModelName = modelName;
        }

        public virtual void Printdeviceinfo()
        {
            Console.WriteLine($"Media Name : {MediaName}");
            Console.WriteLine($"Model Name : {ModelName}");
        }
    }
}
