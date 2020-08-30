using System;

namespace access_modifiers
{
    class BaseClass
    {
        public int RollNo;
    }
    class ChildClass:BaseClass
    {
        public void Getdata(int rno)
        {
            RollNo = rno;
        }
        public void Showdata()
        {
            Console.WriteLine("rno:" + RollNo);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();
            cc.Getdata(22);
            cc.Showdata();
            Console.ReadKey();
        }
    }
}
