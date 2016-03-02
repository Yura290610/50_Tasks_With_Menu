using System;


namespace Task12
{
    class Task12
    {        
        public static void Task12f()
        {
            Console.WriteLine("12. Решить квадратное уравнение");
            
            Console.WriteLine("Enter 3 number with space. They are members of thq quadratic equation");
            string[] str = Console.ReadLine().Split(' ');
            Console.WriteLine("Answer:");
            double a = Convert.ToInt32(str[0]);
            double b = Convert.ToInt32(str[1]);
            double c = Convert.ToInt32(str[2]);
            double d = b * b - 4 * a * c;
            if (d < 0) { Console.WriteLine("The equation hasn't real solutions"); }
            if (d == 0) { Console.WriteLine("x="+(-b/2.0/a)); }
            if (d > 0) { Console.WriteLine("x1= " + ((-b +Math.Sqrt(d))/ 2.0 / a)+ "\tx2= " + ((-b - Math.Sqrt(d)) / 2.0 / a)); }
          

           
        }
        
    }
}
