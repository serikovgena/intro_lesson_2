using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args) {
            //GetAvarageDayTempreture();
            //GetMonthByNumber();
            CheckParityOfNumber();
        }

        static void GetAvarageDayTempreture() {
            Console.Write("Введите t(min), C за сутки: ");
            double minTemp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите t(max), C за сутки: ");
            double maxTemp = Convert.ToDouble(Console.ReadLine());

            double result = (minTemp + maxTemp) / 2;
            Console.WriteLine($"Средняя температура за сутки была: {result}");
        }

        static void GetMonthByNumber() {
            Console.Write("Введите номер месяца: ");
            int monthNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Вы указали {(new DateTime(1, monthNum, 1)).ToString("MMMM")}");
        }

        static void CheckParityOfNumber() {
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Указанное число {number} { (number % 2 == 0 ? "четное" : "нечетное") }");
        }
    }
}
