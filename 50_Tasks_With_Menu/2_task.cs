using System;


namespace Task2
{
    class Task2
    {
        public static void Task2f()
        {
            
            Console.WriteLine("2. Вывести на экран три числа в порядке, обратном вводу");
            
            Console.WriteLine("Enter the first number");
            int a=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Answer:");

            Console.Write(c+" "+b+" "+a+"\n");
            
        }
    }
}
