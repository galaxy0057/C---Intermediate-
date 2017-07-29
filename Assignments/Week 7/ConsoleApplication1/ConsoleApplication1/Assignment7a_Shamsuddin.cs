using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace ConsoleApplication1
{
    class assignment7 : Form
    {

        public void displayForm1()
        {

            Form Form1 = new Form();
            Form1.Text = "Assignment 8";
            Form1.Size = new System.Drawing.Size(300, 150);
             
            
            Button btnClickMe = new Button();
            btnClickMe.Text = "Press Me";
            btnClickMe.Location = new Point(15, 20);
            Form1.Controls.Add(btnClickMe);
            btnClickMe.Click += new EventHandler(dynamicBtnClickMe_Click);
          

            Button btnExit = new Button();
            btnExit.Text = "Exit";
            btnExit.Location = new Point(15, 60);
            Form1.Controls.Add(btnExit);
            btnExit.Click += new EventHandler(dynamicBtnExit_Click);
            Form1.ShowDialog(); 


        }

        private void dynamicBtnClickMe_Click(object sender, EventArgs e)
        {

            MessageBox.Show("The button has been clicked."); 


        }

        private void dynamicBtnExit_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);   


        }
        



    }
    
    
    
    
    class Assignment7a_Shamsuddin
    {



        static void Main(string[] args)
        {

            assignment7 ss0 = new assignment7();

            ss0.displayForm1(); 


           


           



            Console.ReadKey();

        }
    }
}
