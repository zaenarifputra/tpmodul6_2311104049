using System;
using System.Diagnostics;

namespace tpmodul6_2311104049
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            // Prekondisi: Judul tidak boleh null atau lebih dari 100 karakter
            if (string.IsNullOrEmpty(title) || title.Length > 100)
            {
                throw new ArgumentException("Judul video tidak boleh kosong atau lebih dari 100 karakter");
            }

            Random rand = new Random();
            this.id = rand.Next(10000, 99999); // ID 5 digit
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 10000000)
            {
                throw new ArgumentOutOfRangeException(nameof(count),
                    "Maksimal penambahan play count adalah 10.000.000");
            }

            try
            {
                checked
                {
                    if (playCount + count < 0) // Antisipasi overflow
                    {
                        throw new OverflowException("Play count melebihi batas maksimum integer.");
                    }
                    playCount += count;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID Video: {id}");
            Console.WriteLine($"Judul Video: {title}");
            Console.WriteLine($"Jumlah Play: {playCount}");
        }
    }
}