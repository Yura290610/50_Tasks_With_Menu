using System;


namespace Task8
{
    class Task8
    {        
        public static void Task8f()
        {
            Console.WriteLine("8. Вывести название дня недели по его номеру");
            
            Console.WriteLine("Enter the number of weekday");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");

            switch (a)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Такого дня нет :)");
                    break;

            }
        }
    }
}
