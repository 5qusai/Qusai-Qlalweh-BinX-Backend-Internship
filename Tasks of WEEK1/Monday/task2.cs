using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Your Grade");
            int grade = Convert.ToInt32(Console.ReadLine());

            switch (grade/10)
            {
                case 9: Console.WriteLine("Your Grade is A"); break;
                case 8: Console.WriteLine("Your Grade is B"); break;
                case 7: Console.WriteLine("Your Grade is C"); break;
                case 6: Console.WriteLine("Your Grade is D"); break;
                default: Console.WriteLine("Your Grade is F"); break;
            }

        }
    }
}
