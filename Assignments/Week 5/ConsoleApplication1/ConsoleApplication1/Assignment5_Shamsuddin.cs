using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class Book
    {
        protected string title;
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

        protected string author;
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

        public void BookType(string type, string level)
        {

            Console.WriteLine("You will enter data for a " + type + " book indicating the " + level + " .");
        }

    }

    public class Fiction : Book 
    {
        private string readingLevel;
        public string ReadingLevel
        {
            get
            {
                return readingLevel; 
            }
            set
            {

                readingLevel = value; 

            }

        }

        public void displayReadingLevel()
        {

            Console.Write("The book you entered is " + Title + " by " + Author + " reading level is " + ReadingLevel + ".");

        }

        public void passToParentConstructor(string type, string level)
        {
            type = "fiction";
            level = "reading level";

            BookType(type, level); 

        }

    }

    public class NonFiction : Book
    {

        private string numberOfPages;
        public string NumberOfPages
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

        public void displayNumberOfPages()
        {

            Console.Write("The book you entered is " + Title + " by " + Author + " the number of pages is " + NumberOfPages + ".");
        }

        public void passToParentConstructor2(string type, string level)
        {

            type = "non-fiction";
            level = "number of pages";

            BookType(type, level);

        }



    }


    class Assignment5_Shamsuddin
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Do you want Fiction (F) or Non-Fiction(N)");
            string fnf = Convert.ToString(Console.ReadLine());

            if (fnf == "f")
            {
                Fiction fiction0 = new Fiction(); 
                string type = " "; 
                string level= " ";
                fiction0.passToParentConstructor(type, level); 
                Console.WriteLine("Enter the book title: ");
                fiction0.Title = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the book author: ");
                fiction0.Author = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the reading level: ");
                fiction0.ReadingLevel = Convert.ToString(Console.ReadLine());
                fiction0.displayReadingLevel(); 
            }
            else if (fnf == "n")
            {
                NonFiction fiction0 = new NonFiction();
                string type = " ";
                string level = " ";
                fiction0.passToParentConstructor2(type, level);
                Console.WriteLine("Enter the book title: ");
                fiction0.Title = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the book author: ");
                fiction0.Author = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the number of pages: ");
                fiction0.NumberOfPages = Convert.ToString(Console.ReadLine());
                fiction0.displayNumberOfPages(); 

            }

            Console.ReadKey();
        }
    }
}
