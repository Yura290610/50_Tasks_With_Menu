using System;


namespace Task42
{
    class Task42
    {
        public static void Task42f()
        {
            Console.WriteLine("42. Найти количество простых членов последовательности");
            
            Console.WriteLine("Enter the sequence of  numbers");
            string[] str = Console.ReadLine().Split(' ');
            Console.WriteLine("Answer:");

            for (int i=0;i<str.Length;i++)
            {
                int k = Convert.ToInt32(str[i]);
                int p = 0;
                for(int j=1;j< k;j++ )
                {
                    if (k % j==0) p++;
                }
                if (p == 1) Console.Write(k+" ");
                p = 0;
            }

            
        }
    }
}
