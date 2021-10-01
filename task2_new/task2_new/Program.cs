using System;

namespace task2_new
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите диапозон X в котором необходимо вывести значения Y");
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            if (x1 > x2)
            {
                Console.WriteLine("неверно указан диапазон");
                Environment.Exit(0);
            }
            Console.WriteLine("Введите шаг x до 0.2");
            double step = double.Parse(Console.ReadLine());
            if (step > 0.2 || step < 0)
            {
                Console.WriteLine("неверно указан шаг");
                Environment.Exit(0);
            }
            Console.WriteLine("Введите радиус окружности");
            double R = double.Parse(Console.ReadLine());
            for (double x = x1; x <= x2; x = x + step)
            {
                FounderY(R, x);

            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("для завершения введите 1111");
            do
            {
                Console.WriteLine("Введите любое значение х");
                double xx = double.Parse(Console.ReadLine());
                if (xx == 1111)
                {
                    Environment.Exit(0);
                }
                FounderY(R, xx);
            } while (true);

            static void FounderY(double R, double x)
            {
                if (Math.Round(R, 3) < 2)
                {
                    if (x < -8 - R)
                    {
                        Console.WriteLine("y не существует");
                    }
                    if (x > -8 + R && x < -6)
                    {
                        Console.WriteLine("y не существует");
                    }


                }

                if (Math.Round(R, 3) > 2)
                {
                    R = 2;
                    if (x < -8 - R)
                    {
                        Console.WriteLine("y не существует");
                    }
                }
                if (x >= -8 - R && x <= -8 + R)
                {

                    double y = Math.Sqrt(Math.Abs(R * R - (x + 8) * (x + 8))) - 2;
                    Console.WriteLine(Math.Round(y, 3));

                }
                if (Math.Round(x, 3) == -6)
                {
                    Console.WriteLine("----------------------------------");
                }

                if (Math.Round(x, 3) >= -6 && Math.Round(x, 3) <= 2)
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

