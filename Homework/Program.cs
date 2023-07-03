using System;

namespace Homework
{
    class Program
    {
        static void Task1() //Задание 1
        {
            Console.Write("Enter a number between 1 and 100: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0 && num <= 100)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        static void Task2() //Задание 2
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter a percentage: ");
            int percentage = int.Parse(Console.ReadLine());
            double result = percentage * number / 100.0;
            Console.WriteLine($"{percentage}% of {number} = {result}");
        }
        static void Task3() //Задание 3
        {
            Console.Write("1st digit: ");
            int digit_1 = int.Parse(Console.ReadLine());
            Console.Write("2nd digit: ");
            int digit_2 = int.Parse(Console.ReadLine());
            Console.Write("3rd digit: ");
            int digit_3 = int.Parse(Console.ReadLine());
            Console.Write("4th digit: ");
            int digit_4 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}{3}", digit_1, digit_2, digit_3, digit_4);
        }
        static void Task4() //Задание 4
        {
            Console.Write("Enter a six-digit number: ");
            string inputNumber = Console.ReadLine();
            if (inputNumber.Length == 6)
            {
                Console.Write("Enter first position of the number: "); //Первый разряд
                int position1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second position of the number: "); //Второй разряд
                int position2 = int.Parse(Console.ReadLine());
                if ((position1 > 0 && position1 <= 6) && (position2 > 0 && position2 <= 6))
                {
                    string result = SwapDigits(inputNumber, position1, position2); //Поменять числа местами
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("It's not a six-digit number");
            }
        }
        static string SwapDigits(string inputNumber, int position1, int position2)
        {
            char[] digits = inputNumber.ToCharArray();
            char temp = digits[position1 - 1];
            digits[position1 - 1] = digits[position2 - 1];
            digits[position2 - 1] = temp;
            return new string(digits); 
        }
        static void Task5() //Задание 5
        {
            Console.Write("Enter date in specified format (dd.mm.yyyy): ");
            string inputDate = Console.ReadLine();
            DateTime date;
            if (!DateTime.TryParse(inputDate, out date)) //Если дата введена неправильно
            {
                Console.WriteLine("Incorrect date format");
                return;
            }
            string season = GetSeason(date.Month); //Вывести время года
            string day_of_week = date.DayOfWeek.ToString(); //Вывести день недели
            Console.WriteLine($"{season} {day_of_week}");
        }
        static string GetSeason(int month)
        {
            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Autumn";
                default:
                    return "Error";
            }
        }
        static void Task6() //Задание 6
        {
            Console.Write("In order to convert temperature value, choose: 1 - Celsius, 2 - Fahrenheit: ");
            int choice = int.Parse(Console.ReadLine());
            double celsius;
            double fahrenheit;
            switch(choice)
            {
                case 1: //Цельсий -> Фаренгейт
                    Console.Write("Enter temperature value to convert to Fahrenheit: ");
                    celsius = double.Parse(Console.ReadLine());
                    fahrenheit = celsius * 9 / 5 + 32;
                    Console.Write("Result: " + fahrenheit);
                    break;
                case 2: //Фаренгейт -> Цельсий
                    Console.Write("Enter temperature value to convert to Celsius: ");
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.Write("Result: " + celsius);
                    break;
                default:
                    Console.Write("Error");
                    break;
            }
            Console.WriteLine();
        }
        static void Task7() //Задание 7
        {
            Console.Write("Enter start of range: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end of range: ");
            int end = int.Parse(Console.ReadLine());
            if (start > end) //Если начало диапазона больше чем конец, то выполняется нормализация диапазона по порядку возрастания чисел
            {
                int temp;
                temp = start;
                start = end;
                end = temp;
            }
            Console.WriteLine("Even numbers in range:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        static void Main()
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
        }
    }
}