using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsrprogram
{
    class Program
    {
        public static int Addition(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public static int Substraction(int a, int b)
        {
            int result = a - b;
            return result;
        }
        public static int Multiplication(int a, int b)
        {
            int result = a * b;
            return result;
        }
        public static int Division(int a, int b)
        {
            int result = a / b;
            return result;
        }

        static void Main(string[] args)
        {
            char repeat = 'y';

            while (repeat == 'y')
            {

                Console.WriteLine("Enter value 1");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter value 2");
                int z = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number operator");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"The addition of {y} and {z} is {Addition(y, z)}");
                        break;
                    case 2:
                        Console.WriteLine($"The subraction of {z} from {y} is {Substraction(y, z)}");
                        break;
                    case 3:
                        Console.WriteLine($"The product of {y} and {z} is {Multiplication(y, z)}");
                        break;
                    case 4:
                        Console.WriteLine($"The division of {z} from {y} is {Division(y, z)}");
                        break;

                }
                Console.WriteLine("Do you want to continue?");
                repeat = char.Parse(Console.ReadLine());
            }


        }
    }
}
