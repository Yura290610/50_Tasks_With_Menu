using System;


namespace Task49
{
    class Task49
    {        
       public  static void Task49f()
        {
            Console.WriteLine("49. Проверить баланс круглых скобок в символьном выражении");
            
            Console.WriteLine("Enter the sequence of expression with parentheses ");
            string str = Console.ReadLine();
            Console.WriteLine("Answer:");
            int count = 0;
                for(int i=0;i< str.Length;i++)
                {
                if (str[i] == '(') count++;
                if (str[i] == ')') count--;
            }
            if (count == 0) Console.WriteLine("Balans is correct"); else Console.WriteLine("Balanse is uncorrect");
           
        }
    }
}
