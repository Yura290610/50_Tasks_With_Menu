using System;


namespace Task7
{
    class Task7
    {
       public  static void Task7f()
        {
            Console.WriteLine("7. Вывести на экран наибольшее из трех чисел");
            
            Console.WriteLine("Enter the first number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");
            Console.WriteLine(((a > b) ? a :b)>c? ((a > b) ? a : b):c );
        }
    }
}
