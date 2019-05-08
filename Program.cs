using System;
using System.Globalization;
using System.Threading;
namespace Unit1dev1.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Amount: ");
            double uno = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Amount ");
            double dos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Third Amount: ");
            double tres = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(""); //to give extra space 
            double total = uno + dos + tres;
            double average = total / 3;
            double[] array = { uno, dos, tres };
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
            Console.WriteLine("The Sum of all entries is: {0:C} ", total);
            Console.WriteLine(" "); // To give extra space 
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
            Console.WriteLine("The Average of all entries is: {0:C} ", average);
            Console.WriteLine(" "); // To give extra space 


            //-------------------Smalles Amount-----------------------------
            if (uno < dos && uno < tres)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
                Console.WriteLine("The Smalles amount is: {0:C} ", uno);
            }

            if (dos < uno && dos < tres)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
                Console.WriteLine("The Smallest amount is: {0:C} ", dos);
            }

            if (tres < dos && tres < uno)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
                Console.WriteLine("The Smallest amount is: {0:C} ", tres);
            }
            Console.WriteLine(" "); // To give extra space 

            //-------------------Largest Amount------------------------------
            if (uno > dos && uno > tres)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
                Console.WriteLine("The Largest amount is: {0:C} ", uno);
            }
            if (dos > uno && dos > tres)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
                Console.WriteLine("The Largest amount is: {0:C} ", dos);
            }

            if (tres > dos && tres > uno)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
                Console.WriteLine("The Largest amount is: {0:C} ", tres);
            }
            Console.WriteLine(" "); // To give extra space 



            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
            Console.WriteLine("US: {0:C} ", total);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-SE", false);
            Console.WriteLine("Swedish: {0:C} ", total);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ja-JP", false);
            Console.WriteLine("Japanese: {0:C} ", total);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("th-TH", false);
            Console.WriteLine("Thai: {0:C} ", total);
            Console.WriteLine(" "); // To give extra space 
            Console.WriteLine("Good Luck and Good Bye");
        }
    }
}

