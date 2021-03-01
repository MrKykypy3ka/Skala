using System;

namespace Skala
{
    public static class Program
    {
        public static void Main()
        {
            int x = 0, y = 0, m = 0;
            Console.WriteLine("Введите максимальную высоту");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите продолжительность пути");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальный перепад высот смежных скал");
            m = Convert.ToInt32(Console.ReadLine());
            Mounts one = new Mounts(x, y, m);
            one.print();
            one.draw();
            Console.ReadKey(true);
        }
    }
}