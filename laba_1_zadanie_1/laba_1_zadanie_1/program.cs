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
                // ������� ��������� ������������ ����� ��� ������������
                RationalNumber a = new RationalNumber(1, 2);
                RationalNumber b = new RationalNumber(1, 3);
                RationalNumber c = new RationalNumber(3, 4);

                // ������� �������� ������������ �����
                Console.WriteLine("������������ ����� a: " + a);
                Console.WriteLine("������������ ����� b: " + b);
                Console.WriteLine("������������ ����� c: " + c);

                // ��������� �������� � ������������� ������� � ������� ����������
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
                Console.WriteLine("��������� ������: " + ex.Message);
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
                // ������� ��������� ������������ ����� ��� ������������
                RationalNumber a = new RationalNumber(1, 2);
                RationalNumber b = new RationalNumber(1, 3);
                RationalNumber c = new RationalNumber(3, 4);

                // ������� �������� ������������ �����
                Console.WriteLine("������������ ����� a: " + a);
                Console.WriteLine("������������ ����� b: " + b);
                Console.WriteLine("������������ ����� c: " + c);

                // ��������� �������� � ������������� ������� � ������� ����������
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
                Console.WriteLine("��������� ������: " + ex.Message);
            }
        }
    }
}
>>>>>>> 2fd7a5e8fd95fe80e485abda2f345fe4f4912b4b
