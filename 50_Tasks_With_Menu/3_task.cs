using System;


namespace Task3
{
    class Task3
    {
        public static void Task3f()
        {
            Console.WriteLine("3. Вывести на экран квадрат введенного числа");
            
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");

            Console.Write(a*a+"\n");

        }
    }
}
