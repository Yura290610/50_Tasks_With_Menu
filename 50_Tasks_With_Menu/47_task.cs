using System;


namespace Task47
{
    class Task47
    {        
        public static void Task47f()
        {
            Console.WriteLine("47. Вывести на экран сумму чисел Фибоначчи до n-ного включительно");
            
            Console.WriteLine("Enter the serial number of the Fibonachi sequence, which will be summed to your's number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            if (n == 0) Console.WriteLine(0);
            if (n == 1) Console.WriteLine(1);
            if (n>1)
            {
                int s = 0;
                int sum = 0;
                int p = 0;
                int k = 1;
                for(int i=1;i< n;i++)
                {
                    s = k + p;
                    p = k;
                    k = s;
                    sum = sum + s;
                }
                Console.WriteLine(sum+1);

            }
           
        }
    }
}
