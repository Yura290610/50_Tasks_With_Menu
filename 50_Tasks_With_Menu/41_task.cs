using System;


namespace Task41
{
    class Task41
    {
        public static void Task41f()
        {
            Console.WriteLine("41. Вывести на экран произведение двузначных элементов последовательности натуральных чисел, которые делятся на заданное число");
            
            Console.WriteLine("Enter the sequence numbers");
            string[] str = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter the  number, which will be played role of divide");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            for (int i=0;i<str.Length;i++)
            {
                if((Convert.ToInt32(str[i])%n==0)&& (Convert.ToInt32(str[i]) /100 == 0)&& (Convert.ToInt32(str[i]) >9)) Console.Write(str[i]+" ");
            }

            
        }
    }
}
