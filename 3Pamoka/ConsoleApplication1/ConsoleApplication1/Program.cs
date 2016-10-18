using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {

            decimal sum = 0;
            string a = "value";


            string variable = Console.ReadLine();
            int count = int.Parse(variable);

            decimal[] numbers = new decimal[count];

            for (int i = 0; i < count; i++)
            {
                string h = Console.ReadLine();
                int d = int.Parse(h);
                numbers[0] = d;

            }
            decimal vidurkis = CalculateAverage(numbers, count);
            Console.WriteLine(vidurkis);
            Console.ReadKey();
        }

        private static decimal CalculateAverage(decimal[] numbers, int count)
        {
            decimal suma = 0;
            decimal vidurkis = 0;
            for (int i = 0; i < count; i++)
            {

                suma += numbers[0];
                 

            }
            vidurkis = suma / count;
            return vidurkis;
        }
    }
}
