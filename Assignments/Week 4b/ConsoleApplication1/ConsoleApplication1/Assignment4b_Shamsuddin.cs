using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Account  //this account class has no public methods, it uses public accessors
    {
        private int accnt;  //declare a private data member
        public int Accnt //declare a public accessor for accnt
        {
            get
            {
                return accnt;
            }
            set
            {
                accnt = value;
            }
        }
        private double balance;  //declare a private data member
        public double Balance  //declare a public accessor for balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public void srchData(int accnt2)
        //function to srch data from user
        {
            if (accnt2 == accnt)
                Console.WriteLine("\nAccount number: " + accnt
                    + " Has a balance of:  "
                    + balance.ToString("C")
                    + " dollars.");
        }
        public void outputData()
        //function to output data to the screen
        {
            Console.WriteLine(accnt + "    " + balance.ToString("C"));
        }
    }
 
    class Program
    {
        static void Main()
        {
            Account[] myAccounts = new Account[5];
            int accnt2 = 0;
 
            for (int x = 0; x < 5; x++)  //use public accessors to set accnt and balance values
            {
                myAccounts[x] = new Account();
                Console.Write("\nPlease enter the account number:  ");
                myAccounts[x].Accnt = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nPlease enter the corresponding balance: ");
                myAccounts[x].Balance = Convert.ToDouble(Console.ReadLine());
            }
 
            Console.WriteLine("\nPlease enter the account number to be searched:  ");
            accnt2 = Convert.ToInt32(Console.ReadLine());
 
            for (int x = 0; x < 5; x++)  //use accessors to get the private data being searched for
            {
                myAccounts[x].srchData(accnt2);
            }
 
            Console.WriteLine("\nAccount   Balance");
            Console.WriteLine();
 
            for (int x = 0; x < 5; x++)  //use accessors to get and print each accnt and balance
            {
                myAccounts[x].outputData();
            }
            Console.WriteLine();
        }
    }
}