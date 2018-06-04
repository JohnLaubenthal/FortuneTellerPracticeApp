using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerPracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName;
            //string lastName;
            string result;
            int age;
            int siblings;
            int retirementAmount = 2500000;
            int bank;
            int retire;
          


            Console.WriteLine("What is your First Name?");
            string firstName = Console.ReadLine().ToLower();

            Console.WriteLine("What is your Last Name?");
            string lastName = Console.ReadLine().ToLower();

            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());



            Console.WriteLine("What number month were you born in {1-12}?");
            int month = int.Parse(Console.ReadLine());

            if (month < 1) 
            if (month > 12)
            {
                Console.WriteLine("You will have $0.00 in the bank."); 
            }

    

                Console.WriteLine("Choose your favorite color from, ROY G BIV?");
            string response = Console.ReadLine().ToLower();


            if (response == "help")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet");

                Console.WriteLine("Choose your favorite color from, ROY G BIV");
                response = Console.ReadLine().ToLower();
            }
            switch (response)
            {

                case "red":
                    result = "red";
                    break;
                case "orange":
                    result = "orange";
                    break;
                case "yellow":
                    result = "yellow";
                    break;
                case "green":
                    result = "green";
                    break;
                case "blue":
                    result = "blue";
                    break;
                case "indigo":
                    result = "indigo";
                    break; 
                case "violet":
                    result = "violet";
                    break;                
            }
            
            Console.WriteLine("How many siblings do you have?");
            int Siblings = int.Parse(Console.ReadLine());

            if ((age % 2) == 0)
            {

                Console.WriteLine("You will retire in 5 years!");
             
            }

            else
            {
                Console.WriteLine("You will retire in 15 years!");
             
            }
            
            

            if (Siblings > 3)
            {
                Console.WriteLine("You will have a vacation home in France!");
                
            }
            if (Siblings <= 0)
            {
                Console.WriteLine("You will have a vacation home in Toledo!");
                
            }   
            else if (Siblings == 1)
            {
                Console.WriteLine("You will have a vacation home in Acapulco!");
                
            }
            else if (Siblings == 2)
            {
                Console.WriteLine("You will have a vacation home in the Bahamas");
                
            }
            else if (Siblings == 3)
                Console.WriteLine("You will have a vacation home in London!");
            bank = retirementAmount / month;
            Console.WriteLine("You will have $" + bank + "!");



                 if (Siblings <0)
            {
                Console.WriteLine("You will drive a Yugo!");
                
            }

            else if (Siblings == 1)
            {
                Console.WriteLine("You will drive a Porsche!");
            }

            else if (Siblings  == 2)
            {
                Console.WriteLine("You will drive a Bentley!");
            }

            else if (Siblings  == 3)
            {

                Console.WriteLine("You will drive a Mercedes Benz!");
            }
            else if (Siblings  == 4)

            {
                Console.WriteLine("You will drive a Land Rover!");
            }
            else if (Siblings  > 4)
            {
                Console.WriteLine("You will drive a Lexus!");

            //  Console.WriteLine("{0}, + {1}  will retire in {3} with {4}     in the bank, a vacation home in {5}, and a {6}", firstName, lastName, retire, bank, vacation home, and a vehicle"); 
            }

           

            



        } // main static void end 

    }//class end
   
}//namespace end

