using System;

namespace tpmodul6_2311104049 {

    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999); // ID 5 digit
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID Video: {id}");
            Console.WriteLine($"Judul Video: {title}");
            Console.WriteLine($"Jumlah Play: {playCount}");
        }
    }

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