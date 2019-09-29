using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlySuggestions
{
    class Program
    {
        static void Main(string[] args)
        {
            int activityChoice = 0, extraPeople = 0;
            string mood = "default mood", activity = "default activity", transportation = "default transportation";
            bool runAgain = true, retryActivity, retryPeople, checkActivity, checkPeople;
            char repeatConfirm;

            while (runAgain == true)
            {
                retryActivity = true;
                retryPeople = true;
                checkActivity = true;
                checkPeople = true;

                while (retryActivity == true)
                {
                    Console.WriteLine("Hello and welcome to Friendly Suggestions!");
                    Console.WriteLine("What are you in the mood for today?");
                    Console.WriteLine("1. Action");
                    Console.WriteLine("2. Chilling");
                    Console.WriteLine("3. Danger");
                    Console.WriteLine("4. Good Food");

                    while (checkActivity == true)
                    {
                        checkActivity = false;

                        try
                        {
                            activityChoice = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please only enter a number.");
                            checkActivity = true;
                        }
                    }
                   

                    switch (activityChoice)
                    {
                        case 1:
                            mood = "action";
                            activity = "stock car racing";
                            retryActivity = false;
                            break;

                        case 2:
                            mood = "chilling";
                            activity = "hiking";
                            retryActivity = false;
                            break;

                        case 3:
                            mood = "danger";
                            activity = "skydiving";
                            retryActivity = false;
                            break;

                        case 4:
                            mood = "good food";
                            activity = "to Taco Bell";
                            retryActivity = false;
                            break;

                        default:
                            Console.WriteLine("Please enter the number next to an option listed above.");
                            retryActivity = true;
                            checkActivity = true;
                            break;
                    }
                }

                while (retryPeople == true)
                {
                    Console.WriteLine("How many people are you bringing with you?");

                    while (checkPeople == true)
                    {
                        checkPeople = false;

                        try
                        {
                            extraPeople = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please only enter a number.");
                            checkPeople = true;
                        }
                    }
                    
                    if (extraPeople == 0)
                    {
                        transportation = "sneakers";
                        retryPeople = false;
                    }
                    else if (extraPeople >= 1 && extraPeople <= 4)
                    {
                        transportation = "a sedan";
                        retryPeople = false;
                    }
                    else if (extraPeople >= 5 && extraPeople <= 10)
                    {
                        transportation = "a bus";
                        retryPeople = false;
                    }
                    else if (extraPeople >= 11)
                    {
                        transportation = "an airplane";
                        retryPeople = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number equal to or greater than 0.");
                        retryPeople = true;
                        checkPeople = true;
                    }
                }

                Console.WriteLine("Since you're in the mood for {0}, you should try {1} and travel in {2}!", mood, activity, transportation);
                Console.WriteLine("Goodbye and thank you for using our Friendly Suggestions! Would you like to run this program again? (Y to confirm)");

                repeatConfirm = Convert.ToChar(Console.ReadLine());

                if (repeatConfirm == 'Y' || repeatConfirm == 'y')
                {
                    runAgain = true;
                }
                else
                {
                    runAgain = false;
                }
            }
        }
    }
}
