using System;

namespace C43_G05_OOP04
{
    //class Rectangle
    //{
    //    public int Width { get; set; }
    //    public int Height { get; set; }

    //    public Rectangle()
    //    {
    //        Width = 0;
    //        Height = 0;
    //    }

    //    public Rectangle(int width, int height)
    //    {
    //        Width = width;
    //        Height = height;
    //    }

    //    public Rectangle(int size)
    //    {
    //        Width = size;
    //        Height = size;
    //    }

    //    public void DisplayDimensions()
    //    {
    //        Console.WriteLine($"Width: {Width}, Height: {Height}");
    //    }
    //}


    //class ComplexNumber
    //{
    //    public double Real { get; set; }
    //    public double Imaginary { get; set; }

    //    public ComplexNumber(double real, double imaginary)
    //    {
    //        Real = real;
    //        Imaginary = imaginary;
    //    }

    //    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    //    {
    //        return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    //    }

    //    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
    //    {
    //        return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    //    }

    //    public override string ToString()
    //    {
    //        string sign = Imaginary >= 0 ? "+" : "-";
    //        return $"{Real} {sign} {Math.Abs(Imaginary)}i";
    //    }
    //}




    //class Employee
    //{
    //    public virtual void Work()
    //    {
    //        Console.WriteLine("Employee is working");
    //    }
    //}

    //class Manager : Employee
    //{
    //    public override void Work()
    //    {
    //        base.Work();

    //        Console.WriteLine("Manager is managing");
    //    }
    //}


    //class BaseClass
    //{
    //    public virtual void DisplayMessage()
    //    {
    //        Console.WriteLine("Message from BaseClass");
    //    }
    //}

    //class DerivedClass1 : BaseClass
    //{
    //    public override void DisplayMessage()
    //    {
    //        Console.WriteLine("Message from DerivedClass1");
    //    }
    //}

    //class DerivedClass2 : BaseClass
    //{
    //    public new void DisplayMessage()
    //    {
    //        Console.WriteLine("Message from DerivedClass2");
    //    }
    //}


    class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //    Rectangle rect1 = new Rectangle();
            //    rect1.DisplayDimensions(); 

            //    Rectangle rect2 = new Rectangle(10, 20);
            //    rect2.DisplayDimensions(); 

            //    Rectangle rect3 = new Rectangle(15);
            //    rect3.DisplayDimensions(); 

            //ComplexNumber c1 = new ComplexNumber(3, 4);
            //ComplexNumber c2 = new ComplexNumber(1, 2);

            //ComplexNumber sum = c1 + c2;
            //Console.WriteLine($"Sum: {sum}"); 

            //ComplexNumber difference = c1 - c2;
            //Console.WriteLine($"Difference: {difference}");

            //Manager manager = new Manager();

            //manager.Work();


            //BaseClass baseClass = new BaseClass();
            //baseClass.DisplayMessage();

            //BaseClass derived1 = new DerivedClass1();
            //derived1.DisplayMessage(); 

            //BaseClass derived2 = new DerivedClass2();
            //derived2.DisplayMessage(); 

            //DerivedClass2 derived2Direct = new DerivedClass2();
            //derived2Direct.DisplayMessage(); 


            Duration duration1 = new Duration(2, 45, 30);
            Console.WriteLine("Duration 1: " + duration1); 

            Duration duration2 = new Duration();
            Console.WriteLine("Duration 2: " + duration2);
        }
    }
}
