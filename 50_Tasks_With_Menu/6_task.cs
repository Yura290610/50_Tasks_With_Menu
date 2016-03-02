using System;


namespace Task6
{
    class Task6
    {
        public static void Task6f()
        {
            Console.WriteLine("6. Вывести на экран наибольшее из двух чисел");
            
            Console.WriteLine("Enter the first number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            Console.WriteLine((a > b) ? a :b );
        }
    }
}
