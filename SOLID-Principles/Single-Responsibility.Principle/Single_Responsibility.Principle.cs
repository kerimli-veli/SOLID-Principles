using System;

namespace SOLID_Principles.Single_Responsibility.Principle
{
    //public class Single_Responsibility { }
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public void DisplayResult(int result)
        {
            Console.WriteLine("Cavab: " + result);
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(5, 3);
            calculator.DisplayResult(result);

            result = calculator.Subtract(10, 4);
            calculator.DisplayResult(result);
        }
    }







    ////////////////////////////




    //public class Calculator
    //{
    //    public int Add(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public int Subtract(int a, int b)
    //    {
    //        return a - b;
    //    }
    //}

    //public class DisplayService
    //{
    //    public void Display(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Calculator calculator = new Calculator();
    //        DisplayService display = new DisplayService();

    //        int sum = calculator.Add(5, 3);
    //        display.Display("Total " + sum);

    //        int difference = calculator.Subtract(10, 4);
    //        display.Display("Difference " + difference);
    //    }
    //}

}
