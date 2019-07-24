using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3enums
{
    class eprac
    {   
        #below two new lists that are made of strings are created for the naughty and nice list 
        List<string> behaviors;
        List<string> behaviors2;

        public eprac()
        {   
            # behaviors and behaviors2 are assinged to the new lists
            behaviors = new List<string>();
            behaviors2 = new List<string>();
        }
        public void NaughtyNice(categories jak) #method for the adding names to each of the lists
        {
            if (jak == categories.nice)# if the user choice is nice code runs a try catch to add names to the nice list

            {                
                Console.WriteLine("Add names to the nice list:"); #prints statement to the console for user to add names

                try
                {
                    string nice = Console.ReadLine();#uses the enums from categories as a string 
                    behaviors.Add(nice); #adds the user input to the nice list 
                }
                catch
                {
                    Console.WriteLine("Enter in something valid"); #runs in case the user input is invalid 
                }
            }

            if (jak == categories.naughty) # if the user choice is naughty, code runs a try catch to add names to the naughty list

            {
                    Console.WriteLine("Add names to the naughty list:");
                    try
                    {
                        string naughty = Console.ReadLine(); #uses the enums from categories as a string 
                        behaviors2.Add(naughty);#adds the user input to the naughty list 
                    }
                    catch
                    {
                        Console.WriteLine("Enter in something valid");#runs in case the user input is invalid 
                    }
                }
            }
        
        public void ShowNiceKids() #method for showing the strings in the nice list
        {
            foreach(string nice in behaviors) #loops through the list using foreach 
            {
                Console.Write($"{nice}"); #writes out each of the string to the console
            }
        }
        public void ShowNauhghtyKids()#method for showing the strings in the naughty list
        {
            foreach(string naughty in behaviors2 )#loops through the list using foreach 
            {
                Console.Write($"{naughty}");#writes out each of the string to the console
            }
        }
    }
}
