using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BookException : Exception //class to create my own exception by extending the Exception class
    {

        public BookException() //message constructor for my BookException exception class
        {
        }
        
        double rate = 0.10; //constant rate 

        private string detailedExceptionMessage; //string to hold detailed error message
        public string DetailedExceptionMessage //accessor for the string to hold detailed error message. 
        {
            get
            {
                return detailedExceptionMessage;
            }
            set
            {

                detailedExceptionMessage = value; 

            }


        }



        public void exceptionClassBookConstructor(string title, double price, int numberOfPages) //three argument constructor to catch exception message
        {


            try //try catch block to trap the error
            {

                double priceOfBook = numberOfPages * rate; //checking for valid ratio

                if (price > priceOfBook) //throw exeption if condition is met 
                {
                    BookException e;
                    e = new BookException();
                    e.DetailedExceptionMessage = @"For " + title + ", ratio is invalid \n" +
                        "...Price is " + price + " for " + numberOfPages+ "\n";
                    throw e;

                }


            }

            catch (BookException e)
            {

                Console.WriteLine(e.DetailedExceptionMessage); 

            }
            
            
            
         
            


        }

  


    }

    class Book
    {
        public static string title; 
        public static string author;
        public static double price;
        public static int numberOfPages;


        public string Title
        {
            get
            {

                return title;

            }
            set
            {

                title = value;

            }


        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;

            }


        }

        public double Price
        {
            get
            {

                return price;

            }
            set
            {

                price = value;
            }


        }

        public int NumberOfPages
        {
            get
            {
                return numberOfPages;
            }
            set
            {
                numberOfPages = value;
            }

        }





    }



    class Assignment6a_Shamsuddin
    {
        static void Main(string[] args)
        {

           

            
            
            Book book0 = new Book(); 
            book0.Title = "GoodNight Moon";
            book0.Author = "Brown"; 
            book0.Price = 12.99;
            book0.NumberOfPages = 25;
            Console.WriteLine("The inputs passed were:  \n");
            Console.WriteLine(" '" + book0.Title + "," + book0.Author + "," + book0.Price + "," + book0.NumberOfPages + "' \n");
            BookException book1 = new BookException();
            book1.exceptionClassBookConstructor(book0.Title, book0.Price, book0.NumberOfPages);
            


            Book book11 = new Book();
            book11.Title = "World History";
            book11.Author = "Stein";
            book11.Price = 72.99;
            book11.NumberOfPages = 900;
            Console.WriteLine(" '" + book11.Title + "," + book11.Author + "," + book11.Price + "," + book11.NumberOfPages + "' \n");
            BookException book2 = new BookException();
            book1.exceptionClassBookConstructor(book11.Title, book11.Price, book11.NumberOfPages);



            Book book22 = new Book();
            book22.Title = "The Grapes of Math";
            book22.Author = "Stoltz";
            book22.Price = 30.99;
            book22.NumberOfPages = 300;
            Console.WriteLine(" '" + book22.Title + "," + book22.Author + "," + book22.Price + "," + book22.NumberOfPages + "' \n");
            BookException book3 = new BookException();
            book1.exceptionClassBookConstructor(book22.Title, book22.Price, book22.NumberOfPages);
           
            
            Book book33 = new Book(); 
            book33.Title = "Steal This Book"; 
            book33.Author = "Hoffman";
            book33.Price = 72.99;
            book33.NumberOfPages = 800;
            Console.WriteLine(" '" + book33.Title + "," + book33.Author + "," + book33.Price + "," + book33.NumberOfPages + "' \n");

            BookException book4 = new BookException();
            book1.exceptionClassBookConstructor(book33.Title, book33.Price, book33.NumberOfPages);
            

            Console.ReadKey();







   




        }
    }
}
