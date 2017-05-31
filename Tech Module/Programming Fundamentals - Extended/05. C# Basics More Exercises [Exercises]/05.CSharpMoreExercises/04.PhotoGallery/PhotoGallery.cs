using System;

namespace _04.PhotoGallery
{
    class PhotoGallery
    {
        static void Main()
        {
            ushort photoNumber = ushort.Parse(Console.ReadLine());
            byte day = byte.Parse(Console.ReadLine());
            byte month = byte.Parse(Console.ReadLine());
            ushort year = ushort.Parse(Console.ReadLine());
            byte hour = byte.Parse(Console.ReadLine());
            byte minute = byte.Parse(Console.ReadLine());
            ulong sizeInBytes = ulong.Parse(Console.ReadLine());
            ushort width = ushort.Parse(Console.ReadLine());
            ushort height = ushort.Parse(Console.ReadLine());

            string orientation = "";
            string sizeUnit = "";
            double size;

            //SIZE
            if (sizeInBytes >= 0 && sizeInBytes < 1000)
            {
                size = sizeInBytes;
                sizeUnit = "B";
            }
            else if (sizeInBytes > 1000 & sizeInBytes < 1000000)
            {
                size = (sizeInBytes * 1.0) / 1000;
                sizeUnit = "KB";
            }
            else
            {
                size = (sizeInBytes * 1.0) / 1000000;
                sizeUnit = "MB";
            }

            //ORIENTATION
            if(width == height)
            {
                orientation = "square";
            }
            else if(width > height)
            {
                orientation = "landscape";
            }
            else
            {
                orientation = "portrait";
            }

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2} {3:d2}:{4:d2}", day, month,year, hour, minute);
            Console.WriteLine("Size: {0}{1}", Math.Round(size,1), sizeUnit);
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
