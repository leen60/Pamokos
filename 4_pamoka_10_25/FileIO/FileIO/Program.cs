using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"D:\SAUGYKLA\Laura Žilinskaitė\Pamokos\4_pamoka_10_25\FileIO\FileIO\longestNameInput.txt"); // nuskaityk failą į input kintamąjį

            FindSportsmenWithLongestFullname(input);
            FindSportsmenWithLongestFullnameLikeAPro(input);

            SortSportsmenByFullnameLength(input);
        }

        public static void FindSportsmenWithLongestFullname(string input)
        {
            string longestn = "";
            string[] longestname = input.Split(',');
            for (int i = 0; i < longestname.Length; i++)
            {
                string currentname = longestname[i];
                if (currentname.Length > longestn.Length)
                {
                    longestn = currentname;
                }

            }
            File.WriteAllText(@"D:\SAUGYKLA\Laura Žilinskaitė\Pamokos\4_pamoka_10_25\FileIO\FileIO\longestNameV1.txt", longestn);
            //sukarpyk input į string[]
            //surask ilgiausią vardą
            //išvesk į failą longestNameV1.txt
        }

        public static void FindSportsmenWithLongestFullnameLikeAPro(string input)
        {
            string[] longestname = input.Split(',');
            List<string> names = longestname.ToList();
            String firstNameInList = names.First();
            List<String> orderedList = names.OrderByDescending(x => x.Length).ToList();
            File.WriteAllLines(@"D:\SAUGYKLA\Laura Žilinskaitė\Pamokos\4_pamoka_10_25\FileIO\FileIO\longestNameV2.txt", orderedList.ToArray());
            //sukarpyk input į List<string>
            //surask ilgiausią vardą
            //išvesk į failą longestNameV2.txt
        }
        
        public static void SortSportsmenByFullnameLength(string input)
        {

            //sukarpyk input į List<string>
            //surūšiuok pagal vardo ilgį
            //išvesk į failą sortedNames.txt
        }
    }
}
