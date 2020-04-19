using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_7
{
    class Program
    {
        static void Main(string[] args)
        {

    ///////////////////////////Task_2///////////////////////////////////////
          /*   Console.Write("Первая сторона прямоугольника = ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Вторая сторона прямоугольника = ");
            double side2 = double.Parse(Console.ReadLine());
            
            if (side1 == side2)
            {
                Console.WriteLine("Неправильно задали значеные!!!");
            }
            else
            {
                Rectangle rect1 = new Rectangle(side1, side2);
                System.Console.WriteLine($"Площадь = {rect1.Area}\nПериметр = {rect1.Perimetr}");
            }

        }

    class Rectangle
    {
        public double side1 {get;}
        public double side2 {get;}
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimetr
        {
            get
            {
                return PerimetrCalculator();
            }
        }
        private double AreaCalculator()
        {
            return this.side1 * this.side2;
        }
        private double PerimetrCalculator()
            {
                return 2 * (this.side1 + this.side2);
            }

    } */

    ///////////////////////////EndTask_2///////////////////////////////////////


    ///////////////////////////Task_3//////////////////////////////////////////
            MyBook NewBook = new MyBook();
            Book_Name n = new Book_Name();
            Console.WriteLine("Введите данные для слейдующая книга");
            Console.Write("\nНазвание книга: \t");
            NewBook.Book_Name.B_Name = Console.ReadLine();
            Console.Write("Автор книги: \t\t");
            NewBook.Book_Author.B_Author = Console.ReadLine();
            Console.Write("Контент книги: \t\t");
            NewBook.Book_Content.B_Content = Console.ReadLine();
            Console.WriteLine("Данные о книге с разними цветами! ");
            NewBook.Show();   

            
        }

        class MyBook
        {
            public Book_Name Book_Name = new Book_Name();
            public Book_Author Book_Author = new Book_Author();
            public Book_Content Book_Content = new Book_Content();

            public void Show() 
            {
                this.Book_Name.Show();
                this.Book_Author.Show();
                this.Book_Content.Show();
            }

        }
        class Book_Name
        {
            public string B_Name{get; set;}
            public void Show() 
            {   
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nНазвание книга\t: {this.B_Name}");
            }

            

        }
        class Book_Content
        {
            public string B_Content{get; set;}
            public void Show() 
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Автор книга\t: {this.B_Content}");
            }

        }
        class Book_Author
        {
            public string B_Author{get; set;}
            public void Show() 
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Контент книга\t: {this.B_Author}");
            }
        }
    ///////////////////////////EndTask_3///////////////////////////////////////

    }
    
}
