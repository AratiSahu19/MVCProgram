using System;

namespace ass7_swapno
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter two numbers");
            Console.WriteLine("Enter number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            p.function1(num1, num2);
        }
        public void function1(int num1,int num2)
        {
            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("Number after swapping   " +"number1="+ num1+" "+ "number2= " + num2);
            
        }

    }
}
