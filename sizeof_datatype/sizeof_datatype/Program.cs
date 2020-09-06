using System;

namespace sizeof_datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine("Size of char: {0}", sizeof(char));
            Console.WriteLine("Size of ulong: {0}", sizeof(ulong));
            Console.WriteLine("Size of ushort: {0}", sizeof(ushort));
            Console.WriteLine("Size of sbyte: {0}", sizeof(sbyte));
            Console.ReadKey();

        }
    }
}
