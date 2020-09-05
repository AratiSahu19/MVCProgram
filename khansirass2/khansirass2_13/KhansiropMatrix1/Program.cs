using System;

namespace KhansiropMatrix1
{
   public class Matrix
    {
      public  static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter the rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the coloumn");
            int colm = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[50,50];
            int[,] matrix2 = new int[50, 50];
            int[,] matrixadd = new int[50, 50];
            for (i=0;i<rows;i++)
            {
                for( j=0;j<colm;j++)
                {
                    Console.WriteLine("Enter Matrix1 Element");
                    matrix1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for ( i = 0; i <rows; i++)
            {
                for ( j = 0; j <colm; j++)
                {
                    Console.WriteLine("Enter Matrix2 Element");
                     matrix2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("First Matrix is");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < colm; j++)
                {
                    Console.WriteLine(matrix1[i,j]);
                   // matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Second Matrix is");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < colm; j++)
                {
                    Console.WriteLine(matrix2[i,j]);
                    //matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
           for (i = 0; i <rows ; i++)
            {
               for (j = 0; j <colm; j++)
                {
                
                    matrixadd[i, j] = matrix1[i, j] + matrix2[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Addition Of Matrix");
            for (i=0;i<rows;i++)
            {
                for(j=0;j<colm;j++)
                {
                    Console.WriteLine(matrixadd[i, j] +"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
