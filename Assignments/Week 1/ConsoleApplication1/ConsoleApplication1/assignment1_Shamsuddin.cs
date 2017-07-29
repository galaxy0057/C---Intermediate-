using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class PhoneCall //Phone call class creation and declation 
    {
        public double numberOfMinutes; //declaring PhoneCall class wide public variable for number of minutes as double 
        public double costOfPhoneCall; //declaring PhoneCall class wide public variable for total cost of phone call


        public void NumberOfMinGet() //first constructor method to ask user for number of minutes and set it variable
        {
            Console.WriteLine("Enter the number of minutes of your phone call in decimal format, example 3.44 :"); // asking for user input
            numberOfMinutes = Convert.ToDouble(Console.ReadLine()); // reading and converting user input to double
            
        }

        public void CalculatePhoneCost() // method to calculate cost of phone call
        {
            costOfPhoneCall = numberOfMinutes * 0.10; // equation to calculate phone call cost and set to variable


        }

        public void DisplayPhoneCost() //method to show cost of phone call
        {

            Console.WriteLine("Your total phone cost is $" + costOfPhoneCall);
            Console.WriteLine();
        }

    }



    class assignment1_Shamsuddin
    {
        static void Main(string[] args)
        {

            PhoneCall phone0 = new PhoneCall(); //PhoneCall class instantiation 
            
            for(int x = 0; x<3; x++) //for loop set
            {

                phone0.NumberOfMinGet(); //method call
                phone0.CalculatePhoneCost(); //method call
                phone0.DisplayPhoneCost(); //method call



            }


            Console.ReadLine();


        }
    }
}
