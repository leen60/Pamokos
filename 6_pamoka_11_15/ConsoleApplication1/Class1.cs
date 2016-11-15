using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    public class Klase
    {

        private Dictionary<string, string> Temp;
        public Klase()
        {
            string[] input = File.ReadAllLines(@"c:\users\mok\documents\visual studio 2015\Projects\ConsoleApplication3\ConsoleApplication1\chatBot.txt");
            Temp = new Dictionary<string, string>();
            foreach (var Element in input)
            {
                Temp.Add(Element.Split('~')[0], Element.Split('~')[1]);
            }
        }

        public string metod(string x)
        {
            if (Temp.ContainsKey(x))
            {
                return Temp[x];
            }
            else
                return "n";

        }
    }
}
