//=================================================================================================
// Задание:  Дано целое число N (> 0). Найти произведение 1.1 * 1.2 * 1.3 ... (N сомножителей).
//=================================================================================================
using System;

namespace Buckix_DZ1_FOR12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Найти произведение 1.1 * 1.2 * 1.3 ... (где N количество сомножителей).\nВведите целое число N (N > 0): ";
            string next = "Чтобы продолжить нажмите на любую кнопку.";
            string error = "Число должно быть больше нуля.";
            int n = 0;
            double result = 1.1, num = 1.1;
            bool cycle = true;

            // Цикл не бесконечен, из цикла можно выйти если пользователь введет число удовлетворяющее условиям задания.
            while (cycle)
            {
                try
                {
                    Console.Write(title);
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 0)
                        throw new Exception(error);
                    cycle = false;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString()); 
                    cycle = true;
                    Console.WriteLine(next);
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            for (int i = 1; i < n; i++)
                result *= num += 0.1;
            
            // Выводим результат, ожидаем нажатие клавиши.
            Console.WriteLine("Результат: " + result);
            Console.WriteLine(next);
            Console.ReadKey();
        }
    }
}
