using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second whole number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number using decimals: ");
            decimal dec1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second number using decimals: ");
            decimal dec2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your first name: ");
            string name1 = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            string name2 = Console.ReadLine();

            Console.WriteLine($"\n...Details...\nNumber 1: {num1}\nNumber 2: {num2}\nNumber 3: {dec1}\nNumber 4: {dec2}\nFirst Name: {name1}\nLast Name: {name2}",num1,num2,dec1,dec2,name1,name2);
            Console.ReadLine();
        }
    }
}
