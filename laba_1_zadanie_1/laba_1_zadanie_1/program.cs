<<<<<<< HEAD
using RationalNumbers;
using System;

namespace laba_1_zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Создаем несколько рациональных чисел для тестирования
                RationalNumber a = new RationalNumber(1, 2);
                RationalNumber b = new RationalNumber(1, 3);
                RationalNumber c = new RationalNumber(3, 4);

                // Выводим значения рациональных чисел
                Console.WriteLine("Рациональное число a: " + a);
                Console.WriteLine("Рациональное число b: " + b);
                Console.WriteLine("Рациональное число c: " + c);

                // Выполняем операции с рациональными числами и выводим результаты
                Console.WriteLine("a + b = " + (a + b));
                Console.WriteLine("a - b = " + (a - b));
                Console.WriteLine("a * b = " + (a * b));
                Console.WriteLine("a / b = " + (a / b));
                Console.WriteLine("-a = " + (-a));
                Console.WriteLine("a == b: " + (a == b));
                Console.WriteLine("a != b: " + (a != b));
                Console.WriteLine("a < c: " + (a < c));
                Console.WriteLine("a > c: " + (a > c));
                Console.WriteLine("a <= c: " + (a <= c));
                Console.WriteLine("a >= c: " + (a >= c));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
=======
using RationalNumbers;
using System;

namespace laba_1_zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Создаем несколько рациональных чисел для тестирования
                RationalNumber a = new RationalNumber(1, 2);
                RationalNumber b = new RationalNumber(1, 3);
                RationalNumber c = new RationalNumber(3, 4);

                // Выводим значения рациональных чисел
                Console.WriteLine("Рациональное число a: " + a);
                Console.WriteLine("Рациональное число b: " + b);
                Console.WriteLine("Рациональное число c: " + c);

                // Выполняем операции с рациональными числами и выводим результаты
                Console.WriteLine("a + b = " + (a + b));
                Console.WriteLine("a - b = " + (a - b));
                Console.WriteLine("a * b = " + (a * b));
                Console.WriteLine("a / b = " + (a / b));
                Console.WriteLine("-a = " + (-a));
                Console.WriteLine("a == b: " + (a == b));
                Console.WriteLine("a != b: " + (a != b));
                Console.WriteLine("a < c: " + (a < c));
                Console.WriteLine("a > c: " + (a > c));
                Console.WriteLine("a <= c: " + (a <= c));
                Console.WriteLine("a >= c: " + (a >= c));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
>>>>>>> 2fd7a5e8fd95fe80e485abda2f345fe4f4912b4b
