using System;


namespace Task5
{
    class Task5
    {
        public static void Task5f()
        {
            Console.WriteLine("5. Посчитать количество единичных битов числа");
            
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            int count=0;
           while(a!=0)
            {
                count += a % 2;
                a = a / 2;
            }
            Console.WriteLine(count);
        }
    }
}
