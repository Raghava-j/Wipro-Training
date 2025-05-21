//Backtracking - N - Queens Problem
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N:");
        int n = int.Parse(Console.ReadLine());

        char[,] board = new char[n, n];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                board[i, j] = '_';
        SolveNQueens(board, 0, n);
    }
    static void SolveNQueens(char[,] board, int row, int n)
    {
        if (row == n)
        {
            PrintBoard(board, n);
            Console.WriteLine();
            return;
        }
        for (int col = 0; col < n; col++)
        {
            if (IsSafe(board, row, col, n))
            {
                board[row, col] = 'Q';
                SolveNQueens(board, row + 1, n);
                board[row, col] = '_';
            }
        }
    }
    static bool IsSafe(char[,] board, int row, int col, int n)
    {
        for (int i = 0; i < row; i++)
            if (board[i, col] == 'Q')
                return false;

        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j --)
            if (board[i, j] == 'Q')
                return false;

        for (int i = row - 1, j = col + 1; i > 0 && j < n; i--, j++)
            if (board[i, j] == 'Q')

                return true;
        return true;
    }
    static void PrintBoard(char[,] board, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(board[i, j] + " ");
            Console.WriteLine();
        }
    }
}