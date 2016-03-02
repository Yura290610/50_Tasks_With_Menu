using System;


namespace Task14
{
    class Task14
    {        
        public static void Task14f()
        {
            Console.WriteLine("14. Найти наибольший нетривиальный делитель натурального числа");
            
            Console.WriteLine("Enter the number, programme finds the most trivial divisor");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            for (int i = n/2; i>=1; i--)
            {
                if (n % i == 0) { Console.WriteLine(i); break; }
            }
        }
    }
}
