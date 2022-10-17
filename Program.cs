using System;

namespace akrepyelkovan
{
    class Program
    {
        static void Main(string[] args)
        {
            

            {
                Console.WriteLine("saati giriniz:");

                int saat = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("dakika giriniz");

                int dakika = Convert.ToInt32(Console.ReadLine());

                double açı = (11 * dakika - 60 * saat) / 2;

                Math.Abs(açı);

                Console.WriteLine("açı:" + açı);

            }
        }
    }
}
