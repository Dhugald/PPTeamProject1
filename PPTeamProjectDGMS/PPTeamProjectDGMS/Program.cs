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

            }
            else if(answer1.Contains("friends"))
            {

            }
            else if (answer1.Contains("relationships"))
            {

            }
            else
            {
                Dhugald();
            }


            
        }
        static void Glen()
        {

            //test 123

        }

        static void Saniya()
        {





        }

        static void Mathew()
        {

            //Mathew test

        }

        static void Dhugald()
        {

            Console.WriteLine("Test");
            Console.ReadLine();

        }


    }
}
