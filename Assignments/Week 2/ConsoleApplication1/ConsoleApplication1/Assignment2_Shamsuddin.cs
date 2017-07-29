using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    class Accounts
    {
        //array creations and declarations
 
        private int[] accountNum = new int[5]; // single dimensional account number array of length 5
        private double[] balances = new double[5]; // single dimensional balances array of length 5
        private string[] accntName = new string[5]; // single dimensional account name array of length 5

        public void fillAccounts() //method to fill all account information using user input
        {
            int x = 0;


            while (x<5) // loop to fill all arrays 
            {
               Console.WriteLine("Enter integer account number: "); // asking user for input
               accountNum[x] = Convert.ToInt32(Console.ReadLine());  //placing user input in array

               Console.WriteLine("Enter account balance as a decimal number (ex. 1324.12):"); 
               balances[x] = Convert.ToDouble(Console.ReadLine()); 

               Console.WriteLine("Enter account holder last name:");
               accntName[x] = Convert.ToString(Console.ReadLine());

               x++; 
                          
            }

        }

        public void searchAccounts() //method to search account with user input
        {
            int userInput;

            Console.WriteLine("Enter an account number to search for: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            for (int x=0; x<5; x++) //iteratively searches all indexes in the user filled accounts 
            {

                if (userInput == accountNum[x]) //if match is found statement is outputted 
                {
                    Console.WriteLine("Account number" +" "+ userInput +" "+ "has a balance of" +" "+ balances[x] +" "+ "for customer" + " " + accntName[x]);
                   
                }
     
            }
            return;
            
        }

        public void averageAccounts() // method to get average of all balances 
        {

            int sum = 0; 

            foreach(int x in balances) //loop to sum up values in balances array
            {
               

                sum = sum + x; 

            }


            int averageValueHolder = sum / balances.Length; //expression to calculate average
            Console.WriteLine("The average dollar amount for the accounts is" + " " + averageValueHolder);

            return;
        }

       
    }

    class Assignment2_Shamsuddin
    {
        static void Main(string[] args)
        {
            Accounts account0 = new Accounts(); // Account class instantiation

            account0.fillAccounts(); //method call to fill accounts 


            

            //bool exit = false; 

            while(true) // loop to ask for user input until break condition is met
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("enter an a or 'A' to search account numbers");
                Console.WriteLine("enter a 'b' or 'B' to average the accounts");
                Console.WriteLine("enter an x or X to exit program");
                Console.WriteLine("*****************************************");
                
                string userInputHolder;
                userInputHolder = Convert.ToString(Console.ReadLine());
            
                if (userInputHolder == "A") //conditional statements to figure out what user wants to do 
                {
                    account0.searchAccounts();
                    

                }
                else if (userInputHolder == "a")
                {

                    account0.searchAccounts();
                    

                }
                else if (userInputHolder == "b")
                {
                    account0.averageAccounts();
                    
                }
                else if (userInputHolder == "B")
                {

                    account0.averageAccounts();
                    
                }
                else if (userInputHolder == "x")
                {

                    Environment.Exit(0);
                    break;
                }
                else if (userInputHolder == "X")
                {

                    Environment.Exit(0);
                    break;
                }
                else
                {
                    Console.WriteLine("You entered an incorrect option");
                  
                } 

               
            }
           
             Console.ReadLine();

}
             
                
                
                
            
            }

        }
    



