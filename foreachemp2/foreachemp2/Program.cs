using System;

namespace foreachemp2
{
    class Program

    {
        static void Main(string[] args)
        {
            int i, j,temp = 0;
            Console.WriteLine("enter size");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            Console.WriteLine("enter element");
           for(i=0;i<n;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(i=0;i<n;i++)
            {
                for(j=i+1;i<n;i++)
                {
                    if(num[i]>num[j])
                    {
                        temp = num[j];
                        num[j] = num[i];
                        num[j] = temp;
                    }
                }

            }
            Console.WriteLine("display sorted element");
            foreach(int k in num)
            {
                Console.WriteLine(k);
            }
        }
        

    }
}
