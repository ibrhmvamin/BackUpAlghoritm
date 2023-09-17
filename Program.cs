// See https://aka.ms/new-console-template for more information

using BackUpAlghoritm;
FlashCard fs=new FlashCard("Photo","IDK",256);
HDD hdd=new HDD("Video","idk",512);
DVD dvd = new DVD("VoiceRecord","idK","Quick",1024);

fs.Printdeviceinfo();
hdd.Printdeviceinfo();
dvd.Printdeviceinfo();

fs.FreeMemory();
hdd.FreeMemory();
dvd.FreeMemory();

fs.SizeOfMedia();
hdd.SizeOfMedia();
dvd.SizeOfMedia();