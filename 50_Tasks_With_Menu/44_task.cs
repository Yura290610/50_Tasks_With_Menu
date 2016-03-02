using System;


namespace Task44
{
    class Task44
    {        
       public  static void Task44f()
        {
            Console.WriteLine("44. Проверить, является ли последовательность пилообразной");
            
            Console.WriteLine("Enter the sequence numbers");
            string[] str = Console.ReadLine().Split(' ');
            Console.WriteLine("Answer:");
            int k = 0;
            int[] a = new int[str.Length];
 
            for(int i=0;i<str.Length;i++)
            {
                a[i] = Convert.ToInt32(str[i]);
            }
            for (int i = 1; i < a.Length-1; i++)
            {
                if (((a[i - 1] > a[i]) && (a[i + 1] > a[i])) || ((a[i - 1] < a[i]) && (a[i + 1] < a[i]))) {  k++; } else { k = -1;  break; }
            }
            
           if (k==a.Length-2) Console.WriteLine("It's a sawtooth surface"); else Console.WriteLine("It's not a sawtooth surface");
        }
    }
}
