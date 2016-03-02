using System;


namespace Task37
{
    class Task37
    {        
        public static void Task37f()
        {
            Console.WriteLine("37. Проверить, является ли натуральное число счастливым билетом");
            
            Console.WriteLine("Enter the number of the ticket");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            string str = n.ToString();
            int s1 = 0;
            int s2 = 0;
            if (n%2==0)
            {
                for(int i=0;i<str.Length/2;i++)
                {
                    s1 = s1 + Convert.ToInt32(str[i]);
                }
                for (int i = str.Length / 2; i < str.Length; i++)
                {
                    s2 = s2 + Convert.ToInt32(str[i]);
                }
            }
            if(n%2!=0)
            {
                for (int i = 0; i < str.Length / 2; i++)
                {
                    s1 = s1 + Convert.ToInt32(str[i]);
                }
                for (int i = str.Length / 2+1; i < str.Length; i++)
                {
                    s2 = s2 + Convert.ToInt32(str[i]);
                }
            }
            if (s1 == s2) Console.WriteLine("It's a happy ticket"); else Console.WriteLine("It's not a happy ticket");
        }
    }
}
