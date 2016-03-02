using System;


namespace Task4
{
    class Task4
    {
        public static void Task4f()
        {
            Console.WriteLine("4. Получить реверсную запись трехзначного числа");
            
            Console.WriteLine("Enter the  number");
            string a = Console.ReadLine();
            Console.WriteLine("Answer:");

            for (int i = a.Length - 2; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
