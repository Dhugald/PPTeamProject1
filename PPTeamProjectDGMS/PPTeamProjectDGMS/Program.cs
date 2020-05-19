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
        // Glen's Code Beginning
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
                Opener();
            }



        }

        static void Mother()
        {
            Console.WriteLine("Therapist: Answering with a yes or no, do you have a good relationship with you're Mother?");
            string mother1 = Console.ReadLine().ToLower();
            if (mother1.Contains("yes"))
            {
                Mother1Yes();
            }
            else
            {
                Mother1No();
            }

        }


        static void Mother1Yes()
        {
            Console.WriteLine("Therapist: So you have a good relationship with you're mother thats good to hear");
            Console.WriteLine("Therapist: Is there any other family member you wish to talk about today?");
            string motherYes = Console.ReadLine().ToLower();
            if (motherYes.Contains("No"))
            {

            }
            else if (motherYes.Contains("father") || motherYes.Contains("dad"))
            {
                Father();
            }
            else if (motherYes.Contains("sister"))
            {
                Sister();
            }
            else if (motherYes.Contains("brother"))
            {
                Brother();
            }
            else if (motherYes.Contains("No"))
            {
                EndingNo();
            }

        }

        static void EndingNo()
        {
            Console.WriteLine("");
        }

        static void Mother1No()
        {
            Console.WriteLine("Therapist: And from your viewpoint what is the problem with you're current relationship?");
        }








        static void Father()
        {
            Console.WriteLine("Therapist: And do you have a good relationship with you're Mother?");
            string father1 = Console.ReadLine().ToLower();

        }

        static void Brother()
        {
            Console.WriteLine("Therapist: And do you have a good relationship with you're Mother?");
            string brother1 = Console.ReadLine().ToLower();

        }

        static void Sister()
        {
            Console.WriteLine("Therapist: And do you have a good relationship with you're Sister?");
            string sister1 = Console.ReadLine().ToLower();

        }

        static void endingNo()
        {

            Console.WriteLine("Therapist: I'm afraid thats all the time we have for today");
            Console.ReadLine();
        }
        // Glen's Code End

        static void Saniya()
        {

            Console.WriteLine("");
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

            Console.WriteLine("Therapist: Ok, so what is the issue you have with the relationship?");
            string relationshipIssue = Console.ReadLine().ToLower();
            if (relationshipIssue.Contains("money") || relationshipIssue.Contains("financial") || relationshipIssue.Contains("bank account"))
            {
                Money(yearsTogether);
            }
            else if (relationshipIssue.Contains("communication") || relationshipIssue.Contains("talking") || relationshipIssue.Contains("communicating"))
            {
                Communication(yearsTogether);
            }
            else if (relationshipIssue.Contains("fight") || relationshipIssue.Contains("fighting") || relationshipIssue.Contains("contest") || relationshipIssue.Contains("argue") || relationshipIssue.Contains("arguing"))
            {
                Fight(yearsTogether);
            }
            else
            {
                Console.WriteLine("Therapist: Im sorry, I dont think I can help you with that");
            }

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }

        static void Money(int yearsMarried)
        {
            Console.WriteLine("Therapist: How many years has this been an issue?");
            int problemLength = Convert.ToInt32(Console.ReadLine());

            if (yearsMarried < problemLength || yearsMarried != 0)
            {
                Console.WriteLine("Therapist: So this has been an issue for longer than you have been married.");
            }

            Console.WriteLine("Therapist: What specifically is the issue with money");
            string moneyIssue = Console.ReadLine().ToLower().Trim();

            if (moneyIssue.Contains("not enough") || moneyIssue.Contains("poor") || moneyIssue.Contains("need more") || moneyIssue.Contains("saving"))
            {
                Console.WriteLine("Therapist: I suggest setting up a savings plan or possibly talking to your bank aboput your options");
            }
            else if (moneyIssue.Contains("spends too much") || moneyIssue.Contains("dosent allow me to spend") || moneyIssue.Contains("restrictive") || moneyIssue.Contains("No acsess"))
            {
                Console.WriteLine("Therapist: I think you need to talk to your partner about being more fair with money");
            }
            else
            {
                Console.WriteLine("Therapist: Im sorry, I dont think I can help you with that");
            }

        }

        static void Communication(int yearsMarried)
        {
            Console.WriteLine("Therapist: How many years has this been an issue?");
            int problemLength = Convert.ToInt32(Console.ReadLine());

            if (yearsMarried < problemLength || yearsMarried != 0)
            {
                Console.WriteLine("Therapist: So this has been an issue for longer than you have been married.");
            }

            Console.WriteLine("Therapist: What specifically is the issue with communication");
            string communicationIssue = Console.ReadLine().ToLower().Trim();

            if (communicationIssue.Contains("dosent talk") || communicationIssue.Contains("silent") || communicationIssue.Contains("talk more") || communicationIssue.Contains("dosent say anything"))
            {
                Console.WriteLine("Therapist: I suggest that you take half an hour every night and talk to each other about you day");
            }
            else if (communicationIssue.Contains("talks too much") || communicationIssue.Contains("shut up") || communicationIssue.Contains("nagging") || communicationIssue.Contains("dosent stop talking"))
            {
                Console.WriteLine("Therapist: I would suggest spending more time apart than usual for a while week");
            }
            else
            {
                Console.WriteLine("Therapist: Im sorry, I dont think I can help you with that");
            }
   
        }

        static void Fight(int yearsMarried)
        {
            Console.WriteLine("Therapist: How many years has this been an issue?");
            int problemLength = Convert.ToInt32(Console.ReadLine());

            if (yearsMarried < problemLength || yearsMarried != 0)
            {
                Console.WriteLine("Therapist: So this has been an issue for longer than you have been married.");
            }

            Console.WriteLine("Therapist: What specifically is the issue with arguing");
            string communicationIssue = Console.ReadLine().ToLower().Trim();

            if (communicationIssue.Contains("too much") || communicationIssue.Contains("all the time") || communicationIssue.Contains("always"))
            {
                Console.WriteLine("Therapist: I suggest that the next time you feel you are about to fight you go to other rooms and cool off.");
            }
            else if (communicationIssue.Contains("nitpick") || communicationIssue.Contains("looks for") || communicationIssue.Contains("goes out of their way"))
            {
                Console.WriteLine("Therapist: I would suggest that you stop looking for thing to fight over, and instead look for things to laugh about.");
            }
            else
            {
                Console.WriteLine("Therapist: Im sorry, I dont think I can help you with that");
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
                else
                {
                    DhugaldContinue();
                }
            }
        }
        public static void DhugaldContinue()
        {
            Console.WriteLine($"Therapist: Well, {name}, on a scale of 0-10 how content are you with life?");
            Console.Write($"{name}: ");
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
            Console.WriteLine($"Therapist: Would you say that your main mood be happy, sad, angry?");
            Console.Write($"{name}: ");
            string mood = Console.ReadLine().ToLower();
            if (mood.Contains("sad"))
            {
                Console.WriteLine($"Therapist: Have you ever been medicated for this?");
                Console.Write($"{name}: ");
                string meds = Console.ReadLine().ToLower();
                if (meds.Contains("y") || meds.Contains("yes") || meds.Contains("ye"))
                {
                    Console.WriteLine($"Therapist: Would you be willing to go on medication again?");
                    Console.Write($"{name}: ");
                    string meds2 = Console.ReadLine().ToLower();
                    if (meds2.Contains("y") || meds2.Contains("yes") || meds2.Contains("ye"))
                    {
                        Console.WriteLine($"Therapist: This is great, I'll see you next session {name}");
                    }
                    }
                else if (meds.Contains("n") || meds.Contains("no") || meds.Contains("nope"))
                {
                    Console.WriteLine($"Therapist: I would highly recommend trying some sort of medication to help with these feelings");
                }
            }
            else if (mood.Contains("happy"))
            {
                Console.WriteLine($"Therapist: This is great, I'll see you next session {name}");
            }
            else if (mood.Contains("angry"))
            {
                Console.WriteLine($"Therapist: Have you ever been medicated for this?");
                Console.Write($"{name}: ");
                string meds = Console.ReadLine().ToLower();
                if (meds.Contains("y") || meds.Contains("yes") || meds.Contains("ye"))
                {
                    Console.WriteLine($"Therapist: Would you be willing to go on medication again?");
                    Console.Write($"{name}: ");
                    string meds2 = Console.ReadLine().ToLower();
                    if (meds2.Contains("y") || meds2.Contains("yes") || meds2.Contains("ye"))
                    {
                        Console.WriteLine($"Therapist: This is great, I'll see you next session {name}");
                    }
                }
                else if (meds.Contains("n") || meds.Contains("no") || meds.Contains("nope"))
                {
                    Console.WriteLine($"Therapist: I would highly recommend trying some sort of medication to help with these feelings");
                }
            }

        }

    }
}
