//1 задание
using System;

class deadinside
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0 && number % 7 == 0)
            {
                Console.WriteLine("Число делится и на 3, и на 7.");
            }
            else
            {
                Console.WriteLine("Число не делится на 3 и 7 одновременно.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка: " + e.Message);
        }
    }
}

using System;
//2 задание
class deadinside
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите первое число:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Первое число больше второго.");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("Второе число больше первого.");
            }
            else
            {
                Console.WriteLine("Числа равны.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка: " + e.Message);
        }
    }
}
//3 задание
using System;

class deadinside
{
    static void Main()
    {
        int sum = 0;
        int number;

        try
        {
            do
            {
                Console.Write("Введите число (для выхода введите 0): ");
                number = int.Parse(Console.ReadLine());
                sum += number;
            } while (number != 0);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка формата числа! Пожалуйста, введите целое число.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка переполнения! Введенное число слишком большое.");
        }
        finally
        {
            Console.WriteLine("Сумма введенных чисел: " + sum);
        }
    }
}
//4 задание
using System;

class deadinside
{
    static void Main()
    {
        try
        {
            Console.Write("Введите число от 1 до 7: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Введено некорректное значение. Пожалуйста, введите число от 1 до 7.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка формата числа! Пожалуйста, введите целое число.");
        }
    }
}
//5 задание
using System;

class deadinside
{
    static void Main()
    {
        // switch
        Console.Write("Введите название дня недели: ");
        string day = Console.ReadLine();

        int number;

        switch (day)
        {
            case "понедельник":
                number = 1;
                break;
            case "вторник":
                number = 2;
                break;
            case "среда":
                number = 3;
                break;
            case "четверг":
                number = 4;
                break;
            case "пятница":
                number = 5;
                break;
            case "суббота":
                number = 6;
                break;
            case "воскресенье":
                number = 7;
                break;
            default:
                Console.WriteLine("Такого дня нет");
                return;
        }

        Console.WriteLine($"Порядковый номер дня недели: {number}");
    }
}
//6 задание
using System;

class deadinside
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        Console.WriteLine($"Сумма четных чисел от 2 до {n}: {sum}");

        // while
        sum = 0;
        int i = 2;

        while (i <= n)
        {
            sum += i;
            i += 2;
        }

        Console.WriteLine($"Сумма четных чисел от 2 до {n}: {sum}");

        // do-while
        sum = 0;
        i = 2;

        do
        {
            sum += i;
            i += 2;
        } while (i <= n);

        Console.WriteLine($"Сумма четных чисел от 2 до {n}: {sum}");
    }
}
//8 задание
using System;

class deadinside
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите два целых числа:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("while:");
            PrintNumbersWithWhileLoop(number1, number2);
            Console.WriteLine();

            Console.WriteLine("do-while:");
            PrintNumbersWithDoWhileLoop(number1, number2);
            Console.WriteLine();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }

    static void PrintNumbersWithWhileLoop(int number1, int number2)
    {
        int start = Math.Min(number1, number2);
        int end = Math.Max(number1, number2);

        while (start <= end)
        {
            Console.Write(start + " ");
            start++;
        }
    }

    static void PrintNumbersWithDoWhileLoop(int number1, int number2)
    {
        int start = Math.Min(number1, number2);
        int end = Math.Max(number1, number2);

        do
        {
            Console.Write(start + " ");
            start++;
        }
        while (start <= end);
    }

    static void PrintNumbersWithForLoop(int number1, int number2)
    {
        int start = Math.Min(number1, number2);
        int end = Math.Max(number1, number2);

        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
    }
}
//Задание 9
using System;

class deadinside
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите количество чисел:");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(" while:");
            PrintSumWithWhileLoop(count);

            Console.WriteLine(" do-while:");
            PrintSumWithDoWhileLoop(count);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }

    static void PrintSumWithWhileLoop(int count)
    {
        int sum = 0;
        int number = 1;
        int numbersCount = 0;

        while (numbersCount < count)
        {
            if (number % 5 == 2 || number % 3 == 1)
            {
                sum += number;
                Console.Write(number + " ");
                numbersCount++;
            }

            number++;
        }

        Console.WriteLine("\nСумма чисел: " + sum);
    }

    static void PrintSumWithDoWhileLoop(int count)
    {
        int sum = 0;
        int number = 1;
        int numbersCount = 0;

        do
        {
            if (number % 5 == 2 || number % 3 == 1)
            {
                sum += number;
                Console.Write(number + " ");
                numbersCount++;
            }

            number++;
        } while (numbersCount < count);

        Console.WriteLine("\nСумма чисел: " + sum);
    }

    static void PrintSumWithForLoop(int count)
    {
        int sum = 0;
        int numbersCount = 0;

        for (int number = 1; numbersCount < count; number++)
        {
            if (number % 5 == 2 || number % 3 == 1)
            {
                sum += number;
                Console.Write(number + " ");
                numbersCount++;
            }
        }

        Console.WriteLine("\nСумма чисел: " + sum);
    }
}
