using System;

namespace Skala
{
    public class Mounts
    {
        int[] markup, markup1;
        string[,] mount;
        Random rand = new Random();
        int x, y;
        public Mounts(int x, int y, int m)
        {
            markup = new int[x];
            mount = new String[x, y];
            markup[0] = rand.Next(0, y);
            this.x = x;
            this.y = y;
            for (int i = 1; i < x; i++)
            {
                do
                    markup[i] = rand.Next(markup[i - 1] - m, markup[i - 1] + m + 1);
                while (markup[i] > y || markup[i] < 0);
            }
            markup1 = (int[])markup.Clone();
            for (int i = 0; i < x; i++)
            {
                for (int j = y - 1; j >= 0; j--)
                {
                    if (j == y - 1 && markup1[i] == 0)
                        mount[i, j] = "—";
                    else if (markup1[i] > 0)
                    {
                        mount[i, j] = "*";
                        markup1[i]--;
                    }
                    else
                        mount[i, j] = " ";
                }
            }
        }
        public void print()
        {
            Console.WriteLine();
            for (int i = 0; i < x; i++)
                Console.Write(markup[i] + " ");
        }
        public void draw()
        {
            Console.WriteLine();
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                    Console.Write(mount[j, i]);
                Console.WriteLine();
            }
        }
    }
}