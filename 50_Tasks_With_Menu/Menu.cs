using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Beginner_tasks
{
    class Menu
    {
        static void Main(string[] args)
        {
            
            int i = 0;
            Console.WriteLine("Each number is a each task with same number\n");
            Console.WriteLine("1.Вывести на экран сообщение «Hello World!»");
            Console.WriteLine("2. Вывести на экран три числа в порядке, обратном вводу");
            Console.WriteLine("3. Вывести на экран квадрат введенного числа");
            Console.WriteLine("4. Получить реверсную запись трехзначного числа");
            Console.WriteLine("5. Посчитать количество единичных битов числа");
            Console.WriteLine("6. Вывести на экран наибольшее из двух чисел");
            Console.WriteLine("7. Вывести на экран наибольшее из трех чисел");
            Console.WriteLine("8. Вывести название дня недели по его номеру");
            Console.WriteLine("9. Проверить, является ли четырехзначное число палиндромом");
            Console.WriteLine("10. Проверить, является ли четырехзначное число счастливым билетом");
            Console.WriteLine("11. Проверить, является ли двоичное представление числа палиндромом");
            Console.WriteLine("12. Решить квадратное уравнение");
            Console.WriteLine("13. Вывести на экран все натуральные числа до заданного");
            Console.WriteLine("14. Найти наибольший нетривиальный делитель натурального числа");
            Console.WriteLine("15. Найти наименьший нетривиальный делитель натурального числа");
            Console.WriteLine("\nMISS SOME TASKS\n");
            Console.WriteLine("35. Вывести на экран x, записанное в системе счисления с основанием n");
            Console.WriteLine("36. Найти наименьший нетривиальный делитель двух заданных чисел");
            Console.WriteLine("37. Проверить, является ли натуральное число счастливым билетом");
            Console.WriteLine("38. Проверить, является ли натуральное число палиндромом");
            Console.WriteLine("39. Проверить, является ли натуральное число степенью двойки");
            Console.WriteLine("40. Вывести на экран произведение четных элементов заданной последовательности натуральных чисел");
            Console.WriteLine("41. Вывести на экран произведение двузначных элементов последовательности натуральных чисел, которые делятся на заданное число");
            Console.WriteLine("42. Найти количество простых членов последовательности");
            Console.WriteLine("43. Проверить, начинается ли каждый из членов последовательности с десятичной цифры, на которую оканчивается предыдущий");
            Console.WriteLine("44. Проверить, является ли последовательность пилообразной");
            Console.WriteLine("45. Проверить, является ли последовательность строго монотонной");
            Console.WriteLine("46. Вывести на экран n-ное число Фибоначчи");
            Console.WriteLine("47. Вывести на экран сумму чисел Фибоначчи до n-ного включительно");
            Console.WriteLine("48. Вывести на экран все числа Фибоначчи до n-ного включительно");
            Console.WriteLine("49. Проверить баланс круглых скобок в символьном выражении");
            Console.WriteLine("50. Вычислить экспоненту с заданной точностью");
            Console.WriteLine("Continue...");
            Console.WriteLine("Enter 0, if you want to exit");
            do
            {



                Console.WriteLine("\nEnter the item number of the menu");
                i =Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    Task1.Task1.Task1f();
                }
                if (i == 2)
                {
                    Task2.Task2.Task2f();
                }
                if (i == 3)
                {
                    Task3.Task3.Task3f();
                }
                if (i == 4)
                {
                    Task4.Task4.Task4f();
                }
                if (i == 5)
                {
                    Task5.Task5.Task5f();
                }

                if (i == 6)
                {
                    Task6.Task6.Task6f();
                }
                if (i == 7)
                {
                    Task7.Task7.Task7f();
                }

                if (i == 8)
                {
                    Task8.Task8.Task8f();
                }

                if (i == 9)
                {
                    Task9.Task9.Task9f();
                }

                if (i == 10)
                {
                    Task10.Task10.Task10f();
                }

                if (i == 11)
                {
                    Task11.Task11.Task11f();
                }

                if (i == 12)
                {
                    Task12.Task12.Task12f();
                }

                if (i == 13)
                {
                    Task13.Task13.Task13f();
                }

                if (i == 14)
                {
                    Task14.Task14.Task14f();
                }

                if (i == 15)
                {
                    Task15.Task15.Task15f();
                }

                if (i == 35)
                {
                    Task35.Task35.Task35f();
                }

                if (i == 36)
                {
                    Task36.Task36.Task36f();

                }

                if (i == 37)
                {

                    Task37.Task37.Task37f();
                }

                if (i == 38)
                {
                    Task38.Task38.Task38f();

                }

                if (i == 39)
                {
                    Task39.Task39.Task39f();

                }

                if (i == 40)
                {
                    Task40.Task40.Task40f();

                }

                if (i == 41)
                {
                    Task41.Task41.Task41f();

                }

                if (i == 42)
                {
                    Task42.Task42.Task42f();

                }

                if (i == 43)
                {
                    Task43.Task43.Task43f();

                }

                if (i == 44)
                {
                    Task44.Task44.Task44f();

                }

                if (i == 46)
                {
                    Task45.Task45.Task45f();

                }
                if (i == 47)
                {
                    Task47.Task47.Task47f();

                }
                if (i == 48)
                {
                    Task48.Task48.Task48f();

                }
                if (i == 49)
                {
                    Task49.Task49.Task49f();
                }
                if (i == 50)
                {
                    Task50.Task50.Task50f();
                }
                Console.WriteLine("");

            } while (i != 0);

        }
    }
}
