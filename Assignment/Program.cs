using System.ComponentModel;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            
            //#region Q1
            //////Write a program that allows the user to enter a number then print it.
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num);


            //#endregion

            //#region Q2
            ///*Write C# program that converts a string to an integer,
            //    but the string contains non-numeric characters.
            //    And mention what will happen */
            //string age = "1one";
            //int x;
            //bool Age = int.TryParse(age, out x);
            //Console.WriteLine(Age);
            //// Thise non valid convertion so when use TryParse Thise Method try to parse string
            //// and didn't crush the program
            //#endregion

            //#region Q3
            ///* Write C# program that Perform a simple arithmetic operation with floating-point numbers 
            //     And mention what will happen*/
            //int x = 3;
            //float y = 3.3f;

            //// first calculation will perform its ++x then (2*3) , x+1 /5 *6.9 , result - y
            ////and in the end of calculatin y will deducted by 1 
            //#endregion

                 #region Q4
            //Write C# program that Extract a substring from a given string.  

            string name = "Saad Usama Saad ";

            string FirstName = name.Substring(0,4);
            string MedName = name.Substring(5,5);
            string LastName = name.Substring(11,4);
            Console.WriteLine($"My name is {FirstName} My Father is name {MedName}and Last name is {LastName}");
            #endregion




        }
    }
}
