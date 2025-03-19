using System;
using System.Diagnostics;

namespace tpmodul6_2311104049
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private long playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title.Length <= 100, "Judul video tidak boleh kosong atau lebih dari 100 karakter");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 10000000)
            {
                Console.WriteLine("Error: Maksimal penambahan play count adalah 10.000.000");
                return;
            }

            try
            {
                checked
                {
                    if (playCount + count > int.MaxValue)
                    {
                        Console.WriteLine("Error: Play count akan melebihi batas maksimum integer.");
                        return;
                    }
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count melebihi batas integer.");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }

    class Program
    {
        static void Main()
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [Nama Praktikan]");

            // Uji normal
            video.IncreasePlayCount(5000000);
            video.PrintVideoDetails();

            // Uji batas maksimum
            video.IncreasePlayCount(10000000);

            // Uji overflow
            for (int i = 0; i < 3; i++)
            {
                video.IncreasePlayCount(int.MaxValue / 2); // Mengurangi risiko langsung overflow
            }
            Console.ReadLine();
        }
    }
}
