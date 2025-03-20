using System;

namespace tpmodul6_2311104049
{
    class Program
    {
        static void Main()
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [Nama Praktikan]");
            video.PrintVideoDetails();
            Console.ReadLine();
        }
    }
}