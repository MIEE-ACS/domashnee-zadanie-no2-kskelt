using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Выведем все значения у соответствующие х-10 до 2");
            Console.WriteLine("Введите радиус окружности");
                int R = int.Parse(Console.ReadLine());
            for (double x = -10; x <= 8; x = x + 0.1)
            {
                FounderY(R, x);

            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Введите любое значение х");
            
            double x1 = double.Parse(Console.ReadLine());
            FounderY(R, x1);

            static void FounderY(int R, double x)
            {
                if (R < 2) {
                    if(x< -8-R) {
                        Console.WriteLine("y не существует");
                    }
                    if (x > -8 + R&& x<-6)
                    {
                        Console.WriteLine("y не существует");
                    }
                   
               
                } 
            
                if(R>2)
                    {
                        R = 2;
                    if (x < -8 - R)
                    {
                        Console.WriteLine("y не существует");
                    }
                }
                if (x >= -8-R && x <= -8+R)
                {

                    double y = Math.Sqrt(Math.Abs(R * R - (x + 8) * (x + 8))) - 2;
                    Console.WriteLine(Math.Round(y, 3));

                }
                if (Math.Round(x, 3) == -6)
                {
                    Console.WriteLine("----------------------------------");
                }

                if (x >= -6 && x <= 2)
                {

                    double y = x / 2 + 1.0;
                    Console.WriteLine(Math.Round(y, 3));
                }
                if (Math.Round(x, 3) == 2)
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Точка разрыва");
                    double y = 0;
                    Console.WriteLine(y);
                    Console.WriteLine("----------------------------------");
                }
                if (x > 2 && x <= 6)
                {
                    double y = 0;
                    Console.WriteLine(Math.Round(y, 3));

                }
                if (Math.Round(x, 3) == 6)
                {
                    Console.WriteLine("----------------------------------");
                }
                if (x >= 6)
                {
                    double y = (x - 6) * (x - 6);
                    Console.WriteLine(Math.Round(y, 3));

                }
            }
        }
       
    }
}
