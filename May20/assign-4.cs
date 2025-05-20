//Dynamic Programming --- Logest Common Subsequence (LCS)
using System;
using System.Text;
class LCSProblem
{
    static string LCS(string str1, string str2, out int length)
    {
        int m = str1.Length;
        int n = str2.Length;

        int[,] dp = new int[m + 1, n + 1];

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }
        StringBuilder lcs = new StringBuilder();
        int x = m, y = n;
        while (x > 0 && y > 0)
        {
            if (str1[x - 1] == str2[y - 1])
            {
                lcs.Insert(0, str1[x - 1]);
                x--; y--;
            }
            else if (dp[x - 1, y] > dp[x, y - 1])
                x--;
            else
                y--;
        }
        length = dp[m, n];
        return lcs.ToString();
    }
    static void Main()
    {
        string str1 = "ABCDGH";
        string str2 = "AEDFHR";

        int lcsLength;
        string lcs = LCS(str1, str2, out lcsLength);

        Console.WriteLine("String 1: " + str1);
        Console.WriteLine("String 2: " + str2);
        Console.WriteLine("\nLongest Common Subsequence: " + lcs);
        Console.WriteLine("Length of LCS: " + lcsLength);
    }
}