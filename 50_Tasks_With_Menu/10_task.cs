using System;


namespace Task10
{
    class Task10
    {        
        public static void Task10f()
        {
            Console.WriteLine("10. Проверить, является ли четырехзначное число счастливым билетом");
            
            Console.WriteLine("Enter the number of ticket(not over 5 numerals");
            string a = Console.ReadLine();
            Console.WriteLine("Answer:");


            if (a.Length == 1) Console.WriteLine("Happy ticket");
            if (a.Length == 2) if(Convert.ToInt32(a[0])==Convert.ToInt32(a[1])) Console.WriteLine("Happy ticket"); else Console.WriteLine("Unhappy ticket");
            if (a.Length == 3) if (Convert.ToInt32(a[0]) == Convert.ToInt32(a[2])) Console.WriteLine("Happy ticket"); else Console.WriteLine("Unhappy ticket");
            if (a.Length == 4) if (Convert.ToInt32(a[0])+ Convert.ToInt32(a[1]) == Convert.ToInt32(a[2])+ Convert.ToInt32(a[3])) Console.WriteLine("Happy ticket"); else Console.WriteLine("Unhappy ticket");
            if (a.Length == 5) if (Convert.ToInt32(a[0]) + Convert.ToInt32(a[1]) == Convert.ToInt32(a[3]) + Convert.ToInt32(a[4])) Console.WriteLine("Happy ticket"); else Console.WriteLine("Unhappy ticket");
        }
        
    }
}
