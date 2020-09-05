using System;

namespace Khansir_ass_Matrix2d
{
    class matrix
    {
        int rows, colm;
        public matrix()
        {
            rows = 2;
            colm = 2;
        }
        public void show()
        {
            Console.WriteLine("Total number of rows:" + rows);
            Console.WriteLine("Total numbers of coloumns:" + colm);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array elemnts");
            matrix [] mat = new matrix[2];
            for(int i = 0; i < 2; i++)
            {
                //  mat[i] = Convert.ToInt32(Console.ReadLine());
                mat[i] = new matrix();
                Console.WriteLine("Enter first array element")
                    
               
            }

        }
    }
}
