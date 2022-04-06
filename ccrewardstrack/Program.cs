using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace ccrewardstrack
{
    public class Program
    {
        
        
        

        static void Main(string[] args)



        {
            do
            {

                string file = @"C:\Users\Jamie\source\repos\ccrewardstrack\ccrewardstrack\cardinfo.txt";
                using StreamWriter sw = new StreamWriter(file);

                {
                    Console.WriteLine("Enter a nickname for your credit card: ");

                    string creditCardName = Console.ReadLine();
                    sw.WriteLine("Credit Card Name: " + creditCardName);


                    Console.WriteLine("Enter credit card expiration date in format mm/yy: ");

                    string expDate = Console.ReadLine();
                    sw.WriteLine("Expiration Date: " + expDate);


                    Console.WriteLine("Enter reward category for January-March: ");

                    string rewardCat1 = Console.ReadLine();
                    sw.WriteLine("January-March Rewards: " + rewardCat1);


                    Console.WriteLine("Enter reward category for April-June: ");

                    string rewardCat2 = Console.ReadLine();
                    sw.WriteLine("April-June Rewards: " + rewardCat2);

                    Console.WriteLine("Enter reward category for July-September: ");

                    string rewardCat3 = Console.ReadLine();
                    sw.WriteLine("July-September Rewards: " + rewardCat3);

                    Console.WriteLine("Enter reward category for October-December: ");

                    string rewardCat4 = Console.ReadLine();
                    sw.WriteLine("October-December Rewards: " + rewardCat4);

                    sw.Close();


            
                    DateTime dateTime = DateTime.Today;


                    DateTime startDatePer1 = new DateTime(2022, 1, 1);
                    DateTime endDatePer1 = new DateTime(2022, 3, 31);
                    DateTime startDatePer2 = new DateTime(2022, 4, 1);
                    DateTime endDatePer2 = new DateTime(2022, 6, 30);

                    DateTime startDatePer3 = new DateTime(2022, 7, 1);
                    DateTime endDatePer3 = new DateTime(2022, 9, 30);
                    DateTime startDatePer4 = new DateTime(2022, 10, 1);
                    DateTime endDatePer4 = new DateTime(2022, 12, 31);

            if (dateTime >= startDatePer1 && dateTime <= endDatePer1)
                    {
                        Console.WriteLine("The reward category eligible for today is: " + rewardCat1);
                        TimeSpan t = (endDatePer1 - dateTime);
                        int days = (int)t.TotalDays;
                        {
                            Console.WriteLine("There are " + days + " days until next reward category");
                        }
                    }
                    else if (dateTime >= startDatePer2 && dateTime <= endDatePer2)
                    {
                        Console.WriteLine("The reward category eligible for today is: " + rewardCat2);
                        TimeSpan t = (endDatePer2 - dateTime);
                        int days = (int)t.TotalDays;
                        {
                            Console.WriteLine("There are " + days + " days until next reward category");
                        }
                    }
                    else if (dateTime >= startDatePer3 && dateTime <= endDatePer3)
                    {

                        Console.WriteLine("The reward category eligible for today is: " + rewardCat3);
                        TimeSpan t = (endDatePer3 - dateTime);
                        int days = (int)t.TotalDays;
                        {
                            Console.WriteLine("There are " + days + " days until next reward category");
                        }
                    }
                    else if (dateTime >= startDatePer4 && dateTime <= endDatePer4)
                    {
                        Console.WriteLine("The reward category eligible for today is: " + rewardCat4);
                        TimeSpan t = (endDatePer4 - dateTime);
                        int days = (int)t.TotalDays;
                        {
                            Console.WriteLine("There are " + days + " days until next reward category");
                        }
                    }
                }

            CreditCard myCreditCard = new CreditCard();
                Console.WriteLine("Receive " + myCreditCard.cashBack + " cash back for all categories.");

                Console.WriteLine("press \"enter\" to view credit card info");
                Console.ReadLine();

                using StreamReader sr = new StreamReader(file);

                {
                    Console.WriteLine(sr.ReadToEnd());
                }

                
                Console.WriteLine("If you would like to input a differnt credit card hit \"enter\". If you would like to exit enter \"exit\"");
                string answer = Console.ReadLine();

                if (answer == "exit")
                {
                    break;
                }
                
               

            }while (true);


        }

    }
}
    
