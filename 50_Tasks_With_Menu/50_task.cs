using System;


namespace Task50
{
    class Task50
    {        
        public static void Task50f()
        {
            Console.WriteLine("50. Вычислить экспоненту с заданной точностью");

            Console.WriteLine("Enter the number - exponential degree ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of accuracy ");
            double eps = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Answer:");
            double exp=1;
            int k = 1;
            double s = 1;
            while(s>=eps)
            {
                s = s*x / (double)k;
                exp = exp + s;
                k++;

            }
            Console.WriteLine(exp);

        }
    }
}
