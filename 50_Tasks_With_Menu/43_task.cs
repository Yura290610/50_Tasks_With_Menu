using System;


namespace Task43
{
    class Task43
    {
        public static void Task43f()
        {
            Console.WriteLine("43. Проверить, начинается ли каждый из членов последовательности с десятичной цифры, на которую оканчивается предыдущий");
            
            Console.WriteLine("Enter the sequence numbers");
            string[] str = Console.ReadLine().Split(' ');
            Console.WriteLine("Answer:");
            int s = 0;
            for(int i=1;i<str.Length;i++)
            {
                if (str[i - 1][str[i-1].Length-1] == str[i][0]) { s++; }
            }
            if(s==(str.Length-1)) Console.WriteLine("All members have same elements with end one and begin other"); else Console.WriteLine("Not all members have same elements with end one and begin other");

        }
    }
}
