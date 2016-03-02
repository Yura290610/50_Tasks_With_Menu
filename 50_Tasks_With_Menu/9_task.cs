using System;


namespace Task9
{
    class Task9
    {        
        public static void Task9f()
        {
            Console.WriteLine("9. Проверить, является ли четырехзначное число палиндромом");
            
            Console.WriteLine("Enter the number, which will be detected on a palindrome");
            string a = Console.ReadLine();
            Console.WriteLine("Answer:");

            string b=null;
            for (int i=a.Length-1;i>=0;i--)
            {
                b = b + a[i];
            }

            if (string.Compare(a, b) == 0) Console.WriteLine("Palinrome"); else Console.WriteLine("Not a palinrome");

        }
        
    }
}
