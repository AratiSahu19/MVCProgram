using System;

namespace assRoshansir_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,num = 2,k=0;
            for (i = 1; i < 100; i++)
            {
                while (i < 100)
                {
                    if (i % 2 == 0)
                    {
                        k++;

                    }

                }
                if (k == 2)
                {
                    Console.WriteLine("Prime numbers" + i);
                }
            }
              
                
            
            Console.ReadKey();
        }
    }
}
