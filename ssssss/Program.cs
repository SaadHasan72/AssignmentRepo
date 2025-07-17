using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ssssss
{
    internal class Program
    {
        static void Main(string[] args)
        {




            #region Q1
            ////Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            ///Console.WriteLine ("write num");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{ 

            //Console.WriteLine(i);

            //}
            #endregion

            #region Q2

            ////7 - Write a program that allows the user to insert an integer then
            ////print a multiplication table up to 12.
            ///Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i=1; i<=12 ;i++)
            //{ 
            //Console.WriteLine(num*i);


            //}
            #endregion

            #region Q3
            ////8 - Write a program that allows to user to insert number then print all even numbers between 1 to this number
            ///Console.WriteLine ("Enter number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= num; i++)
            //{
            //    if (i%2==0)
            //    { 
            //        Console.WriteLine(i);
            //    }

            //} 
            #endregion

            #region Q4
            //////9 - Write a program that takes two integers then prints the power.
            //Console.WriteLine("Enter base  ");
            ////int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter exponent:  ");

            ////int y = int.Parse(Console.ReadLine());


            //Console.WriteLine(Math.Pow(x,y));

            #endregion

            #region Q5
            //Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.WriteLine("Please Enter The First Grade ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter The secound Grade ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter The third Grade ");
            //int z = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter The forth Grade ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter The fifth Grade ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Total ={x+y+z+a+b} ");

            //Console.WriteLine($"Average ={(x+y+z+a+b)/5} ");

            //Console.WriteLine($"Percentage = {((x + y + z + a + b) / 500.0) * 100}%");





            #endregion

            #region Q6
            // //11 - Write a program to input the month number and print the number of days in that month.

            // Console.WriteLine("Please Enter Month Number");
            //int num=int.Parse ( Console.ReadLine());


            // int date = DateTime.DaysInMonth(2025,num);
            // Console.WriteLine($"dayes in month : {date}");
            #endregion

            #region Q7
            ////12 - Write a program to create a Simple Calculator.
            //Console.WriteLine("Enter First num");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Secound num");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter opretor");
            //string opretor =Console.ReadLine();


            //if (opretor == "+")
            //{
            //    Console.WriteLine($"{num1}+{num2}={num1+num2}");

            //}
            //if (opretor == "-")
            //{
            //    Console.WriteLine($"{num1}-{num2}={num1-num2}");

            //}
            //if (opretor == "*")
            //{
            //    Console.WriteLine($"{num1}*{num2}={num1*num2}");

            //}
            //if (opretor == "/")
            //{
            //    Console.WriteLine($"{num1}/{num2}={num1/num2}");

            //}

            #endregion

            #region Q8
            //Console.Write("Enter a string to reverse: ");
            //string input = Console.ReadLine();

            //char[] chars = input.ToCharArray();
            //Array.Reverse(chars);
            //string reversed = new string(chars);

            //Console.WriteLine($"Reversed string: {reversed}");
            #endregion

            #region Q9

            // //15 - Write a program in C# Sharp to find prime numbers within a range of numbers.
            // Console.WriteLine("Enter Strting num");
            //int num1=int.Parse( Console.ReadLine());
            //Console.WriteLine("Enter Ending num");
            //int num2 = int.Parse(Console.ReadLine());



            // for (int i = num1; i <= num2; i++)
            // {
            //     if (i==1)
            //     {

            //        continue;

            //     }
            //     else if (i % 2 != 0 || i == 2)
            //     { 

            //     Console.WriteLine (i);

            //     }


            // }

            #endregion

            #region Q10

            ////17 - Create a program that asks the user to input three points(x1, y1), (x2, y2), and(x3, y3),
            ////and determines whether these points lie on a single straight line.
            //// Collinear : Points  are collinear When they all lie on the line described by the equation y = 2x.
            //Console.WriteLine("Enter point X1");
            //int x1 = int.Parse(Console.ReadLine ());
            //Console.WriteLine("Enter point Y1");
            //int y1 = int.Parse(Console.ReadLine ());
            //Console.WriteLine("Enter point X2");
            //int x2 = int.Parse(Console.ReadLine ());
            //Console.WriteLine("Enter point Y2");
            //int y2 = int.Parse(Console.ReadLine ());
            //Console.WriteLine("Enter point X3");
            //int x3 = int.Parse(Console.ReadLine ());
            //Console.WriteLine("Enter point Y3");
            //int y3 = int.Parse(Console.ReadLine());

            //if (y1 == 2 * (x1) && y2 == 2 * (x2) && y3 == 2 * (x3))
            //{
            //    Console.WriteLine("Thise Pointes are on the straight line |");

            //}
            //else
            //{
            //    Console.WriteLine("its not in stright line");


            //}









            #endregion

            #region Q11
            //////18- Within a company, the efficiency of workers is evaluated based on the duration required
            /////to complete a specific task. A worker's efficiency level is determined as follows: 
            ////-If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            ////- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            ////- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            ////- If the worker takes more than 5 hours, they are required to leave the company.
            ////To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            //Console.WriteLine("Enter number of hours that you take to complet a job");
            //double time =double.Parse(Console.ReadLine());

            //if (time >= 2 && time < 3)
            //{
            //    Console.WriteLine("Wow ! You are Supper Worker");
            //}
            //else if (time >= 3 && time < 4)
            //{ 
            
            //    Console.WriteLine("ok but you are instructed to increase Your speed");

            //}
            //else if (time >= 4 && time < 5)
            //{ 
            
            //    Console.WriteLine("oh no ! You Should take training to enhance their speed ");

            //}
            //else if (time >5)
            //{ 
            
            //    Console.WriteLine("I'am Sorry but you are terminated");

            //}

            #endregion


        }
    }
}
