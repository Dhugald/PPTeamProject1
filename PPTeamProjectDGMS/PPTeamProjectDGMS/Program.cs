using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTeamProjectDGMS
{
    class Program
    {
        public static string name;
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Clear();

            Opener();


            
        }

        static void Opener()
        {
            Console.WriteLine($"Therapist: Hello {name}, my name is Judy and I'm a therapist specializing in relatioships, What brings you in today?");
            string answer1 = Console.ReadLine().ToLower();
            if (answer1.Contains("family") || answer1.Contains("parent") || answer1.Contains("sibling"))
            {
                Glen();
            }
            else if (answer1.Contains("friends") || answer1.Contains("friend"))
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

            Console.WriteLine("Therapist: I see, Is there a particular member of you're family that is on you're mind today?");
            string family1 = Console.ReadLine().ToLower();
            if (family1.Contains("mother") || family1.Contains("mom") || family1.Contains("mum"))
            {
                Mother();
            }
            else if (family1.Contains("father") || family1.Contains("dad"))
            {
                Father();
            }
            else if (family1.Contains("sister"))
            {
                Sister();
            }
            else if (family1.Contains("brother"))
            {
                Brother();
            }
            else
            {
                FamilyOther();
            }

           
         
        }

        static void Mother()
        {
            Console.WriteLine("Therapist: Do you have a good relationship with you're Mother?");
            Console.ReadLine();


        }
        
        static void Father()
        {
            Console.WriteLine("Therapist: Do you have a good relationship with you're Mother?");
            string father1 = Console.ReadLine().ToLower();

        }

        static void Brother()
        {
            Console.WriteLine("Therapist: Do you have a good relationship with you're Mother?");
            string brother1 = Console.ReadLine().ToLower();

        }

        static void Sister()
        {
            Console.WriteLine("Therapist: Do you have a good relationship with you're Sister?");
            string sister1 = Console.ReadLine().ToLower();

        }

        static void FamilyOther()
        {
            Console.WriteLine("Therapist: Do you consider this person a family member?");
            string familyOther1 = Console.ReadLine().ToLower();
            if (familyOther1.Contains("yes") || familyOther1.Contains("yeah"))
                {
                FamilyOtherYes();
            }
            else
            {
                Opener();
            }

        }

        
        static void FamilyOtherYes()
        {
            Console.WriteLine("Therapist: TO BE ADDED TOO");
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
