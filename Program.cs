// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        { 

            double a;
            double b;

            String oprtno;
            String oprtn;
            String res;

            bool WindowRunning = true;

            while(WindowRunning)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("<<<Console Calculator>>>");
                oprtno = "";
                oprtn = "";
                res = "";
                a = 0;
                b = 0;


                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");

                while (oprtno != "1" && oprtno != "2" && oprtno != "3" && oprtno != "4")
                {
                    Console.Write("Choose Operation: ");
                    oprtno = Console.ReadLine();
                }
                Console.WriteLine();

                switch (oprtno)
                {
                    case "1":
                        oprtn = "Addition";
                        Console.WriteLine($"Operation: {oprtn}");
                        Add(a, b);
                        
                        while(res != "Y" && res != "N")
                        {
                            Console.Write("Do you want to use calculator?(Y/N):");
                            res = Console.ReadLine().ToUpper();
                        }

                        if (res == "Y")
                        {
                            WindowRunning = true;
                        }
                        else
                        {
                            WindowRunning = false;
                        }
                        break;
                    case "2":
                        oprtn = "Subtraction";
                        Console.WriteLine($"Operation: {oprtn}");
                        Subtract(a, b);

                        while (res != "Y" && res != "N")
                        {
                            Console.Write("Do you want to use calculator?(Y/N):");
                            res = Console.ReadLine().ToUpper();
                        }

                        if (res == "Y")
                        {
                            WindowRunning = true;
                        }
                        else
                        {
                            WindowRunning = false;
                        }
                        break;
                    case "3":
                        oprtn = "Multiplication";
                        Console.WriteLine($"Operation: {oprtn}");
                        Multiply(a, b);

                        while (res != "Y" && res != "N")
                        {
                            Console.Write("Do you want to use calculator?(Y/N):");
                            res = Console.ReadLine().ToUpper();
                        }

                        if (res == "Y")
                        {
                            WindowRunning = true;
                        }
                        else
                        {
                            WindowRunning = false;
                        }
                        break;
                    case "4":
                        oprtn = "Division";
                        Console.WriteLine($"Operation: {oprtn}");
                        Divide(a, b);

                        while (res != "Y" && res != "N")
                        {
                            Console.Write("Do you want to use calculator?(Y/N):");
                            res = Console.ReadLine().ToUpper();
                        }

                        if (res == "Y")
                        {
                            WindowRunning = true;
                        }
                        else
                        {
                            WindowRunning = false;
                        }
                        break;

                }
                
                
            }
            Console.WriteLine("Thank You!");
            Console.WriteLine("<<<END>>>");
            Console.ReadKey();
        }
        static void Add(double a,double b)
        {

            Console.Write("Enter Number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number: ");
            b = Convert.ToDouble(Console.ReadLine());

            double sum = a + b;
            Console.WriteLine($"Answer: {sum}");
        }
        static void Subtract(double a, double b)
        {
            Console.Write("Enter Number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number: ");
            b = Convert.ToDouble(Console.ReadLine());
            double difference = a - b;
            Console.WriteLine($"Answer: {difference}");
        }
        static void Multiply(double a, double b)
        {
            Console.Write("Enter Number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number: ");
            b = Convert.ToDouble(Console.ReadLine());
            double product = a * b;
            Console.WriteLine($"Answer: {product}");
        }
        static void Divide(double a, double b)
        {
            Console.Write("Enter Number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number: ");
            b = Convert.ToDouble(Console.ReadLine());
            double quotient = a / b;
            Console.WriteLine($"Answer: {quotient}");
        }
    }
}
