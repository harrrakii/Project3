using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProjects3
{
    internal class Program
    {
        static void Main()
        {
            bool working = true;
            do
            {
                try
                {
                    Console.WriteLine("Выберите номер операции:\r\n" +
                        "1.Игра \"Угадай число\"\r\n" +
                        "2.Таблица умножения\r\n" +
                        "3.Вывод делителей числа\r\n" +
                        "4.Выход из программы");
                    int operatorProg = Convert.ToInt32(Console.ReadLine());
                    switch (operatorProg)
                    {
                        case 1:
                            {
                                Console.WriteLine("Введите число от 0 до 100");
                                RandomNum();
                                Console.WriteLine();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Таблица умножения:");
                                int[,] matrix = new int[9, 9];
                                MultiplicationTable(matrix);
                                Console.WriteLine();
                                break;
                            }
                        case 3:
                            {
                                GetDivisors();
                                Console.WriteLine();
                                break;
                            }
                        case 4:
                            {
                                working = false;
                                Console.WriteLine("Завершение программы");
                                Console.WriteLine();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Неизвестная команда");
                                Console.WriteLine();
                                break;
                            }
                    }
                }
                catch
                {
                    Console.WriteLine("Введи именно число!");
                    Console.WriteLine();
                }
            }
            while (working);
            Console.ReadKey();
        }

        private static void MultiplicationTable(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (i + 1) * (j + 1);
                    Console.Write($"\t{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }

        private static void RandomNum()
        {
            Random r = new Random();
            int num = r.Next(100);
            while (true)
            {
                try
                {
                    int numOfUsers = Convert.ToInt32(Console.ReadLine());
                    if (numOfUsers < num)
                    {
                        Console.WriteLine("Надо больше!");
                    }
                    if (numOfUsers > num)
                    {
                        Console.WriteLine("Надо меньше!");
                    }
                    if (numOfUsers == num)
                    {
                        Console.WriteLine("Верное число!\r\n");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Введи именно число!");
                }
            }
        }

        private static void GetDivisors()
        {
            double numOfUsers;
            bool work = true;
            do
            {
                try
                {
                    Console.WriteLine("1.Введите число\n\r" +
                    "2.Выход в меню");
                    int operatorDiv = Convert.ToInt32(Console.ReadLine());
                    switch (operatorDiv)
                    {
                        case 1:
                            {
                                Console.WriteLine("Необходимо ввести число");
                                numOfUsers = Convert.ToInt32(Console.ReadLine());
                                for (int i = 1; i <= numOfUsers; i++)
                                {
                                    if (numOfUsers % i == 0)
                                    {
                                        Console.Write("{0} ", i);
                                    }
                                }
                                Console.WriteLine();
                                break;
                            }
                        case 2:
                            {
                                work = false;
                                Console.WriteLine("Выход в меню");
                                Console.WriteLine();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Неизвестная команда");
                                Console.WriteLine();
                                break;
                            }
                    }
                }
                catch
                {
                    Console.WriteLine("Нужно было ввести число");
                    Console.WriteLine();
                }
            }
            while (work);
        }
    }
}

