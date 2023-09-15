using System;
using System.ComponentModel.Design;
double result;
double a;
double b;
int menu;
int n;
do
{
    Console.WriteLine("1. Сложить два числа");
    Console.WriteLine("2. Вычесть второе из первого");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти один процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    string? input = Console.ReadLine();
    menu = Convert.ToInt32(input);
    switch (menu)
    {
        case 1:
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            result = a + b;
            Console.WriteLine("Ответ:" + ' ' + result);
            break;

        case 2:
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            result = a - b;
            Console.WriteLine("Ответ:" + ' ' + result);
            break;

        case 3:
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            result = a * b;
            Console.WriteLine("Ответ:" + ' ' + result);
            break;

        case 4:
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя :)");
            }
            else
            {
                result = a / b;
                Console.WriteLine("Ответ:" + ' ' + result);
            }
            break;

        case 5:
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень числа:");
            n = Convert.ToInt32(Console.ReadLine());
            result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= a;
            }
            Console.WriteLine("Ответ:" + ' ' + result);
            break;

        case 6:
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            if (a<0)
            {
                Console.WriteLine("Число меньше нуля");
            }
            else 
            {
                result = Math.Sqrt(a);
                Console.WriteLine("Ответ:" + ' ' + result);
            }            
            break;

        case 7:
            Console.WriteLine("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            result = a / 100;
            Console.WriteLine("Ответ:" + ' ' + result);
            break;

        case 8:
            Console.WriteLine("Введите число:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Число меньше нуля :(");
            }
            else
            {
                result = 1;
                for (int i = 1; i <= a; i += 1)
                {
                    result *= i;
                }
                Console.WriteLine("Ответ:" + ' ' + result);
            }
            break;
    }
}
while (menu != 9);
