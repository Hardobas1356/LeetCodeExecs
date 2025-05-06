Console.WriteLine(Solution.DiagonalSum([[1, 2, 3], [4, 5, 6], [7, 8, 9]]));

public static class Solution
{
    public static int DiagonalSum(int[][] mat)
    {
        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;
        int j = mat.Length - 1;

        for (int i = 0; i < mat.Length; i++)
        {
            primaryDiagonalSum += mat[i][i];

            if (i + j == mat.Length - 1)
            {
                secondaryDiagonalSum += mat[i][j];
                j--;
            }

        }

        if (mat.Length % 2 == 1)
        {
            secondaryDiagonalSum -= mat[mat.Length / 2][mat.Length / 2];
        }

        return primaryDiagonalSum + secondaryDiagonalSum;
    }
}