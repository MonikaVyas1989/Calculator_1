using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;

namespace Calculator_1
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            bool running = true;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("*************Calculator***************");
            Console.WriteLine("For Addition Enter number 1");
            Console.WriteLine("For Subtraction Enter number 2");
            Console.WriteLine("For Multiplication Enter number 3");
            Console.WriteLine("For Division Enter number 4");
            Console.WriteLine("For Addition Overload of Enter number 5");
            Console.WriteLine("For Subtraction Overload of Enter number  6");
            Console.WriteLine("For exit from console Enter number 7");
            Console.WriteLine("**************************************");
            Console.ResetColor();

           
            while (running)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue ;
                    Console.WriteLine("Please enter number from Menu which math operation do you want..");
                    var p = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                    double[] num = UserInput(p);
                    
                    switch (p)
                    {
                        case 1:
                            Addition(num[0], num[1]);
                            break;
                        case 2:
                            Subtraction(num[0], num[1]);
                            break;
                        case 3:
                            Multiplication(num[0], num[1]);
                            break;
                        case 4:
                            Division(num[0], num[1]);
                            break;
                        case 5:
                            Addition(num);
                            break;
                        case 6:
                            Subtraction(num);
                            break;
                        case 7:
                            running = false;
                            break;


                        default:
                            Console.WriteLine("It is an invalid number please choose number from Menu");
                            break;


                    }



                }

                catch
                {
                    Console.WriteLine("The value you enterd is not valid");

                }


            }
        }
        public static double[] UserInput(int p)
        {
            if (p >= 1 && p <= 4)
            {
                Console.WriteLine("Enter number 1..");
                var num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter number 2..");
                var num2 = double.Parse(Console.ReadLine());


                return new[] { num1, num2 };
            }
            else if(p>=5 && p<=6)
            {
                var num1list = new List<double>();

                double keepalive = 1;

                do
                {
                    Console.WriteLine("Enter numbers press enter and enter 0 to stop entry");
                    var no1 = double.Parse(Console.ReadLine());
                    keepalive = no1;
                    num1list.Add(no1);

                } while (keepalive  != 0);

                            
                 return  num1list.ToArray() ;
            

            }

            else
            {

                return new[] { 0.0, 0.0 };
            }


        }
                
            public static double Addition(double n1, double n2)
            {
                double sum = 0;
                sum = n1 + n2;
                Console.WriteLine("Addition::" + sum);
                return sum;
            }
            public static double Subtraction(double n1, double n2)
            {

                double sub = n1 - n2;
                Console.WriteLine("Subtraction::" + sub);
                return sub;

            }
            public static double Multiplication(double n1, double n2)
            {

                double mul = n1 * n2;
                Console.WriteLine("Multiplication::" + mul);
                return mul;

            }
            public static double Division(double n1, double n2)
            {

                double div = n1 / n2;
                if (n2 == 0)
                {
                    Console.WriteLine("Number can not be divided by 0");
                }
                else
                {
                    Console.WriteLine("Division::" + div);
                }

                return div;
            }
        public static double Addition(double[] number)
        {
            double sum = 0;
            sum = number.Sum();
            Console.WriteLine("Addition::" + sum);
            return sum;
        }
        public static double Subtraction(double [] number)
        {

            
            double sub = 0;
            double count = 0;
            foreach (double i in number)
            {
                if(count == 0)
                {
                    sub = i;
                }
                else
                {
                    sub = sub - i;
                }
                count++;
            }
            Console.WriteLine("subtraction::" + sub);
            return sub;
        }
     }
}

