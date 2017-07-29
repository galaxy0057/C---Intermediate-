using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Date
    {
        public int day; //class variable declarations for day
        public int month; //class variable declarations for month
        public int year; //class variable declarations for year

        public int Day //get set property to retrieve and set value for respective class variables  
        {
            get
            {
                return day;

            }

            set
            {
                day = value;

            }

        }

        public int Month
        {
            get
            {
                return month;

            }

            set
            {
                month = value;

            }

        }

        public int Year
        {
            get
            {
                return year;

            }

            set
            {
                year = value;

            }

        }




        public Date() //no argument constructor 
        {
            day = 1;
            month = 1;
            year = 2000;


            

        }

        public Date(int day, int month) //two argument constructor 
        {
            Day = day;
            Month = month;
            year = 2004;

   
        }

        public Date(int day, int month, int year) //three argument constructor 
        {

            Day = day;
            Month = month;
            Year = year;


        }


        public void DisplayDate() //method to display object date 
        {



            Console.WriteLine("The date in this object is" + " " + month + "/" + day + "/" + year);
            Console.WriteLine("************************************");



        }


    }
    
    
    class Assignment4a_Shamsuddin
    {
        static void Main(string[] args)
        {
            int Day;
            int Month;
            int Year;


            Console.WriteLine("Implementing overloaded constructors program");
            Console.WriteLine("************************************ ");
            Date date0 = new Date(); //instantiation of no argument constructor 
            Console.WriteLine("Using no-argument constructor, assigning date 1/1/2000");
            date0.DisplayDate();

           // Console.ReadKey();

            Console.WriteLine("Using 2-argument constructor, assigning year 2004");
            Console.WriteLine("Enter a month eg 10 for October: ");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a day eg 24:");
            Month = Convert.ToInt32(Console.ReadLine());
            Date date2 = new Date(Day, Month); //instantiation of 2 argument constructor 
            date2.DisplayDate();

            //Console.ReadKey();

            Console.WriteLine("Using 3-argument constructor, for mo/da/y");
            Console.WriteLine("Enter a month eg 10 for October: ");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a day eg 24:");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a year eg 1950:");
            Year= Convert.ToInt32(Console.ReadLine());
            Date date3 = new Date(Day, Month, Year);

            date3.DisplayDate(); //instatntiation of 3 argument constructor 


           
            Console.ReadLine();










        }
    }
}
