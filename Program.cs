using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3enums
{
    class Program
    {
        static void Main(string[] args)
        {
            eprac b = new eprac();
            {
                bool keepGoing = true;
                while (keepGoing == true)
                {
                    Console.WriteLine("\n1) Add Nice Names");
                    Console.WriteLine("2) Add Naughty Names");
                    Console.WriteLine("3) Show Nice Names");
                    Console.WriteLine("4) Show Naughty Names");
                    Console.WriteLine("0) Exit");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        b.NaughtyNice(categories.nice);
                    }
                    else if (choice == "2")
                    {
                        b.NaughtyNice(categories.naughty);
                    }
                    else if (choice == "3")
                    {
                        b.ShowNiceKids();
                    }
                    else if (choice == "4")
                    {
                        b.ShowNauhghtyKids();

                    }
                    else if (choice == "0")
                    {
                        keepGoing = false;
                    }
                    else
                    {
                        Console.WriteLine("Your choice is not valid");
                    }

                }
                //Console.ReadKey();
            }
        }
    }
}
    

