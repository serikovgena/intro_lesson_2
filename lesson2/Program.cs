using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args) {
            GetAvarageDayTempreture();
        }

        static void GetAvarageDayTempreture() {
            Console.Write("Введите t(min), C за сутки: ");
            double minTemp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите t(max), C за сутки: ");
            double maxTemp = Convert.ToDouble(Console.ReadLine());

            double result = (minTemp + maxTemp) / 2;
            Console.WriteLine($"Средняя температура за сутки была: {result}");
        }
    }
}
