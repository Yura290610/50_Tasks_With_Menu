using System;


namespace Task13
{
    class Task13
    {        
        public static void Task13f()
        {
            Console.WriteLine("13. Вывести на экран все натуральные числа до заданного");
            
            Console.WriteLine("Enter the number, which will be  the top of row");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");

            for (int i = 0; i <= n; i++)
            {
                Console.Write(i + " ");
            }           
        }
        
    }
}
