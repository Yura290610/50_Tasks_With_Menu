using System;


namespace Task48
{
    class Task48
    {        
        public static void Task48f()
        {
            Console.WriteLine("48. Вывести на экран все числа Фибоначчи до n-ного включительно");
            

            Console.WriteLine("Enter the serial number of the Fibonachi sequence, which members will be shown");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            if (n == 0) Console.WriteLine(0);
            if (n == 1) Console.WriteLine(0+", "+1);
            if (n>1)
            {
                Console.Write(0+", "+1+", ");
                int s = 0;
                int p = 0;
                int k = 1;
                for(int i=1;i< n;i++)
                {
                    s = k + p;
                    p = k;
                    k = s;
                    Console.Write(s + ", ");
                }
            }
           
        }
    }
}
