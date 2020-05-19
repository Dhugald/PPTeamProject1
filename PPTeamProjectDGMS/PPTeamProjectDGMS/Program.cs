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
        public static string answer1;

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
            Console.Write($"{name}: ");
            answer1 = Console.ReadLine().ToLower();
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
            int yearsTogether;
            Console.WriteLine("Therapist: Ok so you have relationship issues, tell me are you married/in a civil union? (yes/no)");
            string relationshipLength = Console.ReadLine().ToLower();

            if (relationshipLength == "yes")
            {
                Console.WriteLine("Therapist: And how many years have you been together?");
                yearsTogether = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                yearsTogether = 0;
            }

            Console.WriteLine("Theripist: Ok, so what is the issue you have with the relationship?");
            string relationshipIssue = Console.ReadLine().ToLower();

            if (relationshipIssue.Contains("money") || relationshipIssue.Contains("financial") || relationshipIssue.Contains("bank account"))
            {
                Money(yearsTogether);
            }
            else if (relationshipIssue.Contains("communcation") || relationshipIssue.Contains("talking"))
            {
                //Communication();
            }
            else if (relationshipIssue.Contains("fight") || relationshipIssue.Contains("fighting") || relationshipIssue.Contains("contest"))
            {
                //Fight()
            }
            else
            {
                //enter default message here
            }
        }

        static void Money(int yearsMarried)
        {
            Console.WriteLine("Therapist: How many years has this been an issue?");
            int problemLength = Convert.ToInt32(Console.ReadLine());

            if(yearsMarried < problemLength)
            {
                Console.WriteLine("Therapist: So this has been an issue for longer than you have been married.");
            }

            Console.WriteLine("Therapist: What spesificly is the issue with money");
            string moneyIssue = Console.ReadLine().ToLower().Trim();

            if(moneyIssue.Contains("not enough") || moneyIssue.Contains("poor") || moneyIssue.Contains("need more") || moneyIssue.Contains("saving"))
            {
                Console.WriteLine("Therapist: I suggest setting up a savings plan or possibly talking to your bank aboput your options");
            }
            else if(moneyIssue.Contains("spends too much") || moneyIssue.Contains("dosent allow me to spend") || moneyIssue.Contains("restrictive") || moneyIssue.Contains("No acsess"))
            {
                Console.WriteLine("Therapist: I think you need to talk to your partner about being more fair with money");
            }
            else
            {
                Console.WriteLine("Therapist: Im sorry, I dont think i can help you with that");
            }
        }

        static void Dhugald()
        {
            Console.WriteLine("Therapist: Have you ever seen a counselor before? (Y/N)");
            Console.Write($"{name}: ");
            string beenBefore = Console.ReadLine().ToLower();

            if (beenBefore.Contains("y") || beenBefore.Contains("yes") || beenBefore.Contains("ye"))
            {
                Console.WriteLine("Therapist: Well then, what is the problem from your viewpoint");
                Console.Write($"{name}: ");
                string answer = Console.ReadLine().ToLower();
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
            }
            else
            {
                Console.WriteLine($"Therapist: Well, {name}, on a scale of 0-10 how content are you with life?");
                int scale = Convert.ToInt32(Console.ReadLine());
                switch (scale)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine($"Therapist: This isnt ideal, your going to need more help, I reccommend you come and see me once a week.");
                        defaultConverstion();
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine($"Therapist: So this issue is affecting you and I can see you need help.");
                        defaultConverstion();
                        break;
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine($"Therapist: So I can see the issue isnt huge but you obviously still want help.");
                        defaultConverstion();
                        break;
                    case 10:
                        Console.WriteLine($"Therapist: Okay {name}, you sound pretty content with life, whats the point of going to a therapist?");

                        break;
                    default:
                        Console.WriteLine($"Therapist: Are you going to answer me?");
                        break;
                }
            }
    


        }

        public static void defaultConverstion()
        {
            Console.WriteLine($"Therapist: So {name} how often do you have your issue?");
            Console.Write($"{name}: ");
            Console.ReadLine();
            Console.WriteLine($"Therapist: and what makes the problem better for you?");
            Console.Write($"{name}: ");
            Console.ReadLine();
            Console.WriteLine($"Therapist: Is your mood like a roller coaster, or is it pretty steady?");
            Console.Write($"{name}: ");
            Console.ReadLine();


        }

    }
}
