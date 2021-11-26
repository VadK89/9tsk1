using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9tsk1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*.    Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции 
             * (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). 
             * После этого на консоль выводится ответ. 
             * Используйте обработку исключений для защиты от ввода некорректных данных.
             */
            Console.WriteLine("Простой калькулятор");            
            Console.WriteLine("Введите целое число ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(@"Выберите арифметическое действие:
                  - Сложение (введите 1)
                  - Вычитание (введите 2)
                  - Умножение (введите 3)
                  - Деление (введите 4)");
            string d = Console.ReadLine();
            try
            {
                if (d=="1")
                {
                    Console.WriteLine("Результат сложения двух чисел {0}", x+y);
                }
                else if (d=="2")
                {
                    Console.WriteLine("Результат вычитания двух чисел {0}", x-y);
                }
                else if (d=="3")
                {
                    Console.WriteLine("Результат умножения двух чисел {0}", x*y);
                }
                else if (d=="4")
                {
                    Console.WriteLine("Результат деления двух чисел {0}", x/y);
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор. Перезапустите и выберите другой оператор");
                }                             
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
                
            Console.ReadKey();


        }
    }
}
