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
                bool keepGoing = true; #assings the boolean value to true 
                while (keepGoing == true) #while loop utilizing the boolean value 
                {   
                    # choices for the user to choose from when using the program or to exit the while loop
                    Console.WriteLine("\n1) Add Nice Names");
                    Console.WriteLine("2) Add Naughty Names");
                    Console.WriteLine("3) Show Nice Names");
                    Console.WriteLine("4) Show Naughty Names");
                    Console.WriteLine("0) Exit");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        b.NaughtyNice(categories.nice); #runs this line of code if user choice is "one"
                    }
                    else if (choice == "2")
                    {
                        b.NaughtyNice(categories.naughty); #runs this line of code if user choice is "two"
                    }
                    else if (choice == "3")
                    {
                        b.ShowNiceKids(); #runs this line of code if user choice is "three"
                    }
                    else if (choice == "4")
                    {
                        b.ShowNauhghtyKids(); #runs this line of code if user choice is "four"

                    }
                    else if (choice == "0")
                    {
                        keepGoing = false; #runs this line of code if user choice is "zero"
                    }
                    else
                    {
                        Console.WriteLine("Your choice is not valid"); # runs this line of code if the user choice is invalid 
                    }

                }
                //Console.ReadKey();
            }
        }
    }
}
    

