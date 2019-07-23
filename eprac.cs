using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3enums
{
    class eprac
    {
        List<string> behaviors;
        List<string> behaviors2;

        public eprac()
        {
            behaviors = new List<string>();
            behaviors2 = new List<string>();
        }
        public void NaughtyNice(categories jak)
        {
            if (jak == categories.nice)
            {
                Console.WriteLine("Add names to the nice list:");
                try
                {
                    string nice = Console.ReadLine();
                    behaviors.Add(nice);
                }
                catch
                {
                    Console.WriteLine("Enter in something valid");
                }
            }

            if (jak == categories.naughty)
            {
                    Console.WriteLine("Add names to the naughty list:");
                    try
                    {
                        string naughty = Console.ReadLine();
                        behaviors2.Add(naughty);
                    }
                    catch
                    {
                        Console.WriteLine("Enter in something valid");
                    }
                }
            }
        
        public void ShowNiceKids()
        {
            foreach(string nice in behaviors)
            {
                Console.Write($"{nice}");
            }
        }
        public void ShowNauhghtyKids()
        {
            foreach(string naughty in behaviors2 )
            {
                Console.Write($"{naughty}");
            }
        }
    }
}
