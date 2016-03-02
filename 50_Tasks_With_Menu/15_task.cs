using System;


namespace Task15
{
    class Task15
    {        
        public static void Task15f()
        {
            Console.WriteLine("15. Найти наименьший нетривиальный делитель натурального числа");
            
            Console.WriteLine("Enter the number, programme finds the least trivial divisor");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            for (int i = 2; i<=n; i++)
            {
                if (n % i == 0) { Console.WriteLine(i); break; }
            }
        }
    }
}
