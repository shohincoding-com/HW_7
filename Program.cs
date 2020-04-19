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
            Console.Write("Первая сторона прямоугольника = ");
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

    }

    ///////////////////////////EndTask_2///////////////////////////////////////

    }
    
}
