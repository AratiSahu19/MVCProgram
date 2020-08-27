using System;

namespace ConsoleApp4
{
    enum  suit { hearts ,diamond,spades, clubs }
    class Program
    {
      
        static void Main(string[] args)
        {
            string color;
            suit tmp = suit.clubs ;
            switch(tmp)
            {
                case suit.clubs:
                
                    break;
                case suit.spades:
                    color = "black";
                    break;
                case suit.diamond:
                case suit.hearts:
                    color = "green";
                    break;
                default:
                    color = "error";
                    break;
            }
            Console.WriteLine("colour is ="+tmp );
            Console.ReadKey();
        }
    }
}
