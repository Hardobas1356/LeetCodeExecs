int[][] matrix = [[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]];
Solution.Rotate(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        Console.Write(matrix[i][j] + " ");
    }
    Console.WriteLine();
}

public static class Solution
{
    public static void Rotate(int[][] matrix)
    {
        Transpose(matrix);

        Flip(matrix);
    }

    public static void Flip(int[][] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int rightCount = matrix[0].Length - 1;
            for (int j = 0; j < matrix[0].Length / 2; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][rightCount];
                matrix[i][rightCount] = temp;
                rightCount--;
            }
        }
    }

    public static void Transpose(int[][] matrix)
    {
        int lineCoordinates = 0;
        for (int i = lineCoordinates; i < matrix.GetLength(0); i++)
        {
            for (int j = lineCoordinates; j < matrix[0].Length; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
            lineCoordinates++;
        }
    }
}