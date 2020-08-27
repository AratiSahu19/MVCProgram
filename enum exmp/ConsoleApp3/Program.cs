using System;

namespace ConsoleApp3
{
    class Program

    {
        enum suit { clubs,spades,diamond,hearts}
        static void Main(string[] args)
        {
            string color;
            suit tmp = suit.spades ;
            if (tmp == suit.clubs)
                color = "Green";
            else if (tmp == suit.hearts)
                color = "blue";
            else if (tmp == suit.diamond)
                color = "yellow";
            else
                color = "black";
            Console.WriteLine("color is = " + color);
            Console.ReadKey();

        }
    }
}
