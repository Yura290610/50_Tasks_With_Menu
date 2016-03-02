using System;


namespace Task39
{
    class Task39
    {
        public static void Task39f()
        {
            Console.WriteLine("39. Проверить, является ли натуральное число степенью двойки");
            
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            int j = 0;
            while (a!=0)
            {
                if (a % 2 == 1) j++;
                a=a / 2;
            }
            if (j == 1) Console.WriteLine("Power of 2"); else Console.WriteLine("Not Power of 2");
        }
    }
}
