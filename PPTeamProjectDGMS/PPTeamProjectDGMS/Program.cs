using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTeamProjectDGMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"So {name}, What brings you in today?");
            string answer1 = Console.ReadLine().ToLower();
            if (answer1.Contains("family") || answer1.Contains("parent") || answer1.Contains("sibling"))
            {
                Glen();
            }
            else if(answer1.Contains("friends") || answer1.Contains("friend") || answer1.Contains(""))
            {
                Saniya();
            }
            else if (answer1.Contains("relationships") || answer1.Contains("relationship") || answer1.Contains("partner"))
            {
                Mathew();
            }
            else
            {
                Dhugald();
            }


            
        }
        static void Glen()
        {

            Console.WriteLine("Test family");
            Console.ReadLine();

        }

        static void Saniya()
        {

            Console.WriteLine("Test friends");
            Console.ReadLine();




        }

        static void Mathew()
        {

            Console.WriteLine("Test relationship");
            Console.ReadLine();

        }

        static void Dhugald()
        {

           Console.WriteLine("Test other");
           Console.ReadLine();

        }


    }
}
