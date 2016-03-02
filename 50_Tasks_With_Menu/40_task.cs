using System;


namespace Task40
{
    class Task40
    {
        public static void Task40f()
        {
            Console.WriteLine("40. Вывести на экран произведение четных элементов заданной последовательности натуральных чисел");
            
            Console.WriteLine("Enter the sequence numbers");
            string[] str = Console.ReadLine().Split(' ');
            Console.WriteLine("Answer:");

            for (int i=0;i<str.Length;i++)
            {
                if(Convert.ToInt32(str[i])%2==0) Console.Write(str[i]+" ");
            }

            
        }
    }
}
