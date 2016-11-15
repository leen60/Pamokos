using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Klase Temp = new Klase();
            string j = Console.ReadLine();
            
            Console.WriteLine(Temp.metod(j));
            Console.ReadKey();

        }
    }
    
}
