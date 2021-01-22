using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_app
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please Enter a Number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter one of (+,-,*,/) Operators: ");
                string op = Console.ReadLine();

                Console.WriteLine("Please Enter a Number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Sum is " + Convert.ToString(a + b));

                //Console.WriteLine("Please Enter one of (+,-,*,/) Operators: ");
                //string op = Console.ReadLine();
                switch (op)
                {
                    case "+":
                        Console.WriteLine(Convert.ToString(a + b));
                        break;
                    case "-":
                        Console.WriteLine(Convert.ToString(a - b));
                        break;
                    case "*":
                        Console.WriteLine(Convert.ToString(a * b));
                        break;
                    case "/":
                        Console.WriteLine(Convert.ToString(a / b));
                        break;
                }
                Console.WriteLine("Do you want to Continue with new Numbers? Y/N");
                string Flag = Console.ReadLine();
                
                if ("n" == Flag.ToLower())
                    flag = false;
                else if ("y" == Flag.ToLower())
                    flag = true;
                else
                    Console.WriteLine("Please Enter True Format . . . ");
            }
            Console.ReadKey();
        }
    }
}
