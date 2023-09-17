namespace BackUpAlghoritm
{
    internal interface IStorage
    {
        void SizeOfMedia();

        void Copy(double data);
        void FreeMemory();
        void PrintDeviceInfo();
    }
}
