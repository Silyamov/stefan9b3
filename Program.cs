


namespace stefan9b3;
using System;

class CharMatrixIntersection
{
    static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        char[,] A = ReadCharMatrix(M, N);
        char[,] B = ReadCharMatrix(M, N);

        char[,] C = new char[M, N];

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                C[i, j] = (A[i, j] == B[i, j]) ? A[i, j] : '*';
            }
        }

        PrintCharMatrix(C, M, N);
    }

    static char[,] ReadCharMatrix(int rows, int cols)
    {
        char[,] matrix = new char[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = line[j];
            }
        }
        return matrix;
    }

    static void PrintCharMatrix(char[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}


