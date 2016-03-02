using System;


namespace Task45
{
    class Task45
    {        
        public static void Task45f()
        {
            Console.WriteLine("45. Проверить, является ли последовательность строго монотонной");
            
            Console.WriteLine("Enter the sequence of numbers");
            string[] str = Console.ReadLine().Split(' ');
            Console.WriteLine("Answer:");

            int[] a = new int[str.Length];
 
            for(int i=0;i<str.Length;i++)
            {
                a[i] = Convert.ToInt32(str[i]);
            }
            int k = 0;
            int delta = a[1] - a[0];
            for (int i = 2; i < a.Length; i++)
            {
                if (delta * (a[i] - a[i - 1]) < 0) { k = -1; break; }
            }
            
           if (k==-1) Console.WriteLine("It's not a monotonic function"); else Console.WriteLine("It's a monotonic function");
        }
    }
}
