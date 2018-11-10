using System;
using System.Text;

namespace CalculatingName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("");

            string[] lines = System.IO.File.ReadAllLines(@"D:\VS_works\PU-IntroCSharp-2018-1801681064\PUIntroHomeworks\StudentsNames.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of StudentsNames.txt = ");

            int tStudents = 0;

            foreach (string line in lines)
            {
                string[] elements = line.Split(' ');
                string firstName = elements[1];
                string name = $"{firstName}{elements[3]}";
                // Use a tab to indent each line of the file.
                //Console.WriteLine("\t" + line);

                int sum = 0;
                for (int i = 0; i < firstName.Length; i++)
                {
                    sum += (int)firstName[i];
                }

                if (sum > 10000)
                {
                    tStudents += 1;
                    Console.WriteLine($"{firstName} {elements[3]} => {firstName.Length} => {(char)0x263A}");
                }
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
