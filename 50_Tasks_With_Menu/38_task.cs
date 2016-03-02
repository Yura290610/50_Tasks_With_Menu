using System;


namespace Task38
{
    class Task38
    {        
        public static void Task38f()
        {
            Console.WriteLine("38. Проверить, является ли натуральное число палиндромом");
            
            Console.WriteLine("Enter the number, which will be detected on palindrom");
            string str1 = Console.ReadLine();
            Console.WriteLine("Answer:");
            string str2 = null;

            for(int i=str1.Length-1;i>=0;i--)
            {
                str2 = str2 + str1[i];
            }
             
            if (string.Compare(str1,str2)==0) Console.WriteLine("It's a palindrome"); else Console.WriteLine("It's not a palindrome");
        }
    }
}
