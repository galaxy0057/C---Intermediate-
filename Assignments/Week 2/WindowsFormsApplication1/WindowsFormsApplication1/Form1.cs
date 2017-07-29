using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] accountNum = new int[5]; // single dimensional account number array of length 5
        private double[] balances = new double[5]; // single dimensional balances array of length 5
        private string[] accntName = new string[5]; // single dimensional account name array of length 5

        public void fillAccounts() //method to fill all account information using user input
        {
            int x = 0;


            while (x < 5) // loop to fill all arrays 
            {
                
                
                accountNum[x] = Convert.ToInt32(textAccountNumber.Text);  //placing user input in array

                
                balances[x] = Convert.ToDouble(textAccntBalance.Text);

                
                accntName[x] = Convert.ToString(textAccountName.Text);

                x++;

            }

        }

        public void searchAccounts(int userInput) //method to search account with user input
        
        {
            //int userInput;
           // userInput = Convert.ToInt32(textBox1.Text);

            for (int x = 0; x < 5; x++) //iteratively searches all indexes in the user filled accounts 
            {

                if (userInput == accountNum[x]) //if match is found statement is outputted 
                {

                    string showMethodOutput = "Account number" + " " + userInput + " " + "has a balance of" + " " + balances[x] + " " + "for customer" + " " + accntName[x];
                    label9.Text = showMethodOutput;

                }

            }
            return;
        }

        public void averageAccounts() // method to get average of all balances 
        {



            int sum = 0;

            foreach (int x in balances) //loop to sum up values in balances array
            {


                sum = sum + x;

            }


            int averageValueHolder = sum / balances.Length; //expression to calculate average
            label9.Text = ("The average dollar amount for the accounts is" + " " + averageValueHolder);

            return;
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillAccounts();
 

        }
     
        

        private void button2_Click(object sender, EventArgs e)
        {
            string displayPrompt = "Enter an account number to search for: ";
            label10.Text = displayPrompt;

        }

        

        private void button3_Click(object sender, EventArgs e)
        {

     
          string displayPrompt = "Enter an account number to search for: ";
          label10.Text = displayPrompt;
      
                
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            averageAccounts(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            averageAccounts();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        

        private void textAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        int userInput;

        private void button8_Click(object sender, EventArgs e)
        {
            userInput = Convert.ToInt32(textBox1.Text);
            searchAccounts(userInput);
        }
    }
}


        
    
    
    
    
    
    
   

