using System;


namespace Task11
{
    class Task11
    {        
        public static void Task11f()
        {
            Console.WriteLine("11. Проверить, является ли двоичное представление числа палиндромом");
            
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            string str1 = null;
            
            while(a!=0)
            {
                str1 =str1 + (char)(a % 2);
                a = a / 2;
            }
            string str2=null;
            for(int i=str1.Length-1;i>=0;i--)
            {
                str2 = str2 + str1[i];
            }
            Console.WriteLine("Answer:");
            if (string.Compare(str1, str2) == 0) Console.WriteLine("a palindrome"); else Console.WriteLine("Not a palindrome");

           
        }
        
    }
}
