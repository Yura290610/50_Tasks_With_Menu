using System;


namespace Task46
{
    class Task46
    {        
        public static void Task46f()
        {
            Console.WriteLine("46. Вывести на экран n-ное число Фибоначчи");
            
            Console.WriteLine("Enter the serial number of Fibonachi sequence");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            if (n == 0) Console.WriteLine(0);
            if (n == 1) Console.WriteLine(1);
            if (n>1)
            {
                int s = 0;
                int p = 0;
                int k = 1;
                for(int i=1;i< n;i++)
                {
                    s = k + p;
                    p = k;
                    k = s;
                }
                Console.WriteLine(s);

            }
           
        }
    }
}
