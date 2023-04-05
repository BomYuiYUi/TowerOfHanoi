using System;

namespace Tower_of_Hanoi
{
    class Program
    {
        static void hanoi(int n , char a , char b , char c)
        {
            if(n == 0) { return; }
            hanoi(n - 1, a, c, b);
            Console.WriteLine("Disc "+n+" From "+a+" To "+c);
            hanoi(n - 1, b, a, c);
        }
        static void Main(string[] args)
        {

            int disc = 3;
            char start = 'A';
            char mid = 'B';
            char end = 'C';
            hanoi(disc, start, mid, end);

        }
    }
}
