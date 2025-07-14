//using System.ComponentModel;
//using System.Diagnostics.Metrics;
//using System.Drawing;
//using System.Security.Cryptography.X509Certificates;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace Assignment
//{
//    internal class Program
//    {
        
//        static void Main()
//        {

//            #region Q1
//            ////Write a program that allows the user to enter a number then print it.
            
//            int num = int.Parse(Console.ReadLine());
//            Console.WriteLine(num);


//            #endregion

//            //#region Q2
//            ///*Write C# program that converts a string to an integer,
//            //    but the string contains non-numeric characters.
//            //    And mention what will happen */

//            //string age = "1one";
//            //int x;
//            //bool Age = int.TryParse(age, out x);
//            //Console.WriteLine(Age);

//            //// Thise non valid convertion so when use TryParse Thise Method try to parse string
//            //// and didn't crush the program
//            //#endregion


//            //#region Q3
//            ///* Write C# program that Perform a simple arithmetic operation with floating-point numbers 
//            //     And mention what will happen*/

//            //int x = 3;
//            //float y = 3.3f;
//            //Console.WriteLine((2 * 3) + ++x / 5 * 6.9 - y--);

//            //// first calculation will perform its ++x then (2*3) , x+1 /5 *6.9 , result - y , result + the product of (2*3)
//            ////and in the end of calculatin y will deducted by 1 
//            //#endregion

//            //#region Q4
//            ////Write C# program that Extract a substring from a given string.  

//            //string name = "Saad Usama Saad ";

//            //string FirstName = name.Substring(0, 4);
//            //string MedName = name.Substring(5, 5);
//            //string LastName = name.Substring(11, 4);
//            //Console.WriteLine($"My name is {FirstName} My Father is name {MedName}and Last name is {LastName}");
//            //#endregion

//            //#region Q5
//            ////Write C# program that Assigning one value type variable to
//            ////another and modifying the value of one variable and mention what will happen

//            //int a = 10;
//            //int b = a;

//            //Console.WriteLine($"a= {a}");
//            //Console.WriteLine($"b={b}");

//            //a = 20;
//            //Console.WriteLine($"a= {a}");
//            //Console.WriteLine($"b={b}");

//            //// after changing value of a the value of b still the same because b gets a copy of a is value
//            //// changing a latter dosent effect 

//            //#endregion

//            //#region Q6

//            ////Write C# program that Assigning one reference type variable to another and modifying
//            ////the object through one variable and mention what will happen

//            //Point p01;
//            //p01 = new Point();
//            //p01.X = 1;

//            //Point p02 = p01;

//            //Console.WriteLine($"p01.x ={p01.X}");
//            //Console.WriteLine($"p02.x ={p02.X}");

//            //p02.X = 4;

//            //Console.WriteLine($"After p01.x ={p01.X}");
//            //Console.WriteLine($"After  p02.x ={p02.X}");


//            //// it the same thing of the previous 
//            //#endregion

//            //#region Q7
//            //////Write C# program that take two string variables and print them as one variable
//            //string x = Console.ReadLine();
//            //string y = Console.ReadLine();
//            //Console.WriteLine($"{x} {y}");
//            //#endregion

//            //#region Q8
//            ////Which of the following statements is correct about the C#.NET code snippet given below?
//            //int d;
//            //d = Convert.ToInt32(!(30 < 20));

//            ////The code reports an error.
//            //#endregion

//            //#region Q9
//            ////Which of the following is the correct output for the C# code given below?
//            //Console.WriteLine(13 / 2 + " " + 13 % 2);

//            //Console.WriteLine(13 / 2 + " " + 13 % 2);

//            //A.6.5 1
//            //#endregion

//            //#region Q10


//            ////10 - What will be the output of the C# code given below?


//            //int num = 1, z = 5;


//            //if (!(num <= 0))
//            //    Console.WriteLine(++num + z++ + " " + ++z);
//            //else
//            //    Console.WriteLine(--num + z-- + " " + --z);

//            //c.6 6

//            //#endregion

//        }
//    }
//}
