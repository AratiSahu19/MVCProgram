using System;

namespace ConsoleApp43
{
    class Program
    {
        static float diva ( ref int a,ref float b,ref int c)
        {
            int x,z;
            float y,res;
            x = a;
            y = b;
            z = c;
            res = x + y + z;
           

            Console.WriteLine("additin is" +res);
            return res;
        }
        static void Main(string[] args)
        {
            
            int a = 3;
            int c = 7;
            float b =1.2f ;
            diva(ref a, ref b, ref c);
            Console.ReadKey();
        }
    }
}
