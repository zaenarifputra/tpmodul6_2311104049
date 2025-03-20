using System;

namespace tpmodul6_2311104049
{
    class Program
    {
        static void Main()
        {
            try
            {
                // 1️⃣ Uji Prekondisi: Judul video yang valid
                SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract – [Nama Praktikan]");
                video1.PrintVideoDetails();

                // 2️⃣ Uji Prekondisi: Judul video yang tidak valid (lebih dari 100 karakter)
                try
                {
                    SayaTubeVideo videoInvalid = new SayaTubeVideo(new string('A', 101)); // 101 karakter
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error saat membuat video: {e.Message}");
                }

                // 3️⃣ Uji batas maksimal play count (harus berhasil)
                video1.IncreasePlayCount(5000000);
                video1.PrintVideoDetails();

                // 4️⃣ Uji play count melebihi batas maksimal (harus gagal)
                video1.IncreasePlayCount(15000000); // Melebihi 10.000.000

                // 5️⃣ Uji Overflow dengan Loop
                for (int i = 0; i < 3; i++)
                {
                    video1.IncreasePlayCount(int.MaxValue / 2);
                }

                Console.WriteLine("\n=== Program Selesai ===");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi error di program utama: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
