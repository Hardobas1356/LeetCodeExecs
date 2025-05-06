int[][] matrix = [[1, 2, 3], [4, 5, 6]];
matrix = Solution.Transpose(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix[0].Length; j++)
    {
        Console.Write(matrix[i][j] + " ");
    }
    Console.WriteLine();
}


public static class Solution
{
    public static int[][] Transpose(int[][] matrix)
    {
        int rows = matrix[0].Length;
        int colunms = matrix.Length;

        int[][] result = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            result[i] = new int[colunms];

            for (int j = 0; j < colunms; j++)
            {
                result[i][j] = matrix[j][i];
            }
        }

        return result;
    }
}