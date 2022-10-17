using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите показания температуры");
            int[] temperature = new int [1];
            int i = 0;
            while(int.TryParse(Console.ReadLine(), out temperature[i]))
            {
                Array.Resize(ref temperature, temperature.Length + 1);
                i++;
            }
            Console.Clear();
            for (int k = 0; k < temperature.Length; k++)
            {
                if (temperature[k] > 0)
                {
                    Console.WriteLine($"{k}. (+){temperature[k]}");
                }

                if (temperature[k] < 0)
                {
                    Console.WriteLine($"{k}. (-){Math.Abs(temperature[k])}");
                }

            }
        }
    }
}
