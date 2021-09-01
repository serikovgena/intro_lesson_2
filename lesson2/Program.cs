using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args) {
            GetAvarageDayTempreture();
            GetMonthByNumber();
            CheckParityOfNumber();
            PrintCheck();
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

        static void PrintCheck() {
            int checkNumber = 5844;
            string fuelTitle = "Топливо дизельное ЭКТО Diesel (ДТ-Л-К5)";
            DateTime date = new DateTime(2015, 8, 7, 16, 33, 0);

            decimal price = 34.50m;
            decimal volume = 289.855m;
            decimal sum = 10000.00m;

            string checkView = 
$@"************************************************
        ООО ЛУКОЙЛ-Уралнефтепродукт      
            Казанская сеть АЗС           
          АЗС 16001 Космонавтов          
Чек № {checkNumber}                     
ТРК № 8 {fuelTitle}                     
{price} X {volume} Л                    
{date.ToString("dd.MM.yy HH:mm"), -10}            
Тип оплаты: Наличные                               
Тип скидки: Округление в пользу клиента            
==================================================
ИТОГ                                      {sum}
ККМ 00023114                ИНН 007453011758 #5844

                       ФП                         
**************************************************";

            Console.WriteLine(checkView);
        }
    }
}
