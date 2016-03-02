using System;


namespace Task35
{
    class Task35
    {
        public static void Task35f()
        {
           
            Console.WriteLine("35. Вывести на экран x, записанное в системе счисления с основанием n");
            
            Console.WriteLine("Enter the number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the notation");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            Console.Write("x in n notation = ");
            string str = null;
            while(x!=0)
            {
                str=str+(x % n);
                x=x / n;
            }
            for (int i = str.Length - 1; i >= 0; i--)
            { Console.Write(str[i]); }
            Console.WriteLine("\n");
        }
    }
}
