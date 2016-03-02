using System;


namespace Task36
{
    class Task36
    {
        public static void Task36f()
        {
            Console.WriteLine("36. Найти наименьший нетривиальный делитель двух заданных чисел");
            
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second  number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            int j = 0;
            for(int i=2;i<(a>b? b :a);i++)
            {
                if((a%i==0)&&(b%i==0))
                {
                    Console.WriteLine("Lowest common denominator = " + i);
                    j++;
                    break;
                }
            }
            if (j==0) Console.WriteLine("Lowest common denominator = " + 1);
        }
    }
}
