using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main()
        {
            //1
            Console.WriteLine("It's easy to win forgivess for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup");

            //2
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("D: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("E: ");
            int e = Convert.ToInt32(Console.ReadLine());
            int sum = a + b + c + d + e;
            Console.WriteLine("Sum: " + sum);
            int min = 0;
            min = new[] { a, b, c, d, e }.Min();
            Console.WriteLine("Minimum: " + min);
            int max = 0;
            max = new[] { a, b, c, d, e }.Max();
            Console.WriteLine("Maximum: " + max);
            int product = a * b * c * d * e;
            Console.WriteLine("Product: " + product);

            //3
            int num = 341256;
            Console.WriteLine("Number: " + num);
            int revnum = num % 10 * 100000 + (num / 10) % 10 * 10000 + (num / 100) % 10 * 1000 + 
                (num / 1000) % 10 * 100 + (num / 10000) % 10 * 10 + num / 100000;
            Console.WriteLine("Reverse number: " + revnum);

            //4
            Console.WriteLine("Amount of Fibonacci numbers: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\nResult: ");
            int[] fibo = new int[num];
            int n1 = 0;
            int n2 = 1;
            fibo[0] = n1;
            fibo[1] = n2;
            for (int i = 2; i < num; i++)
            {
                int tmp = n1 + n2;
                fibo[i] = tmp;
                n1 = n2;
                n2 = tmp;
            }
            foreach (int c in fibo)
            {
                Console.Write(c.ToString() + " ");
            }
            Console.WriteLine();

            //5
            Console.WriteLine("Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for(int i = a; i <= b; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(i.ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            //6
            Console.WriteLine("Length: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Symbol: ");
            char s = char.Parse(Console.ReadLine());
            Console.WriteLine("Direction (H - horizontal, another key - vertical): ");
            char direct = char.Parse(Console.ReadLine());
            if (direct == 'H')
            {
                for (int i = 1; i <= l; i++)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= l; i++)
                {
                    for (int j = l; j <= i; j++)
                    {
                        Console.Write(s);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
