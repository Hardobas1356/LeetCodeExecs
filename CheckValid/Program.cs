public static class Solution
{
    public static bool CheckValid(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            HashSet<int> row = new HashSet<int>();
            HashSet<int> column = new HashSet<int>();

            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] < 1 || matrix[i][j] > 100)
                {
                    return false;
                }

                row.Add(matrix[i][j]);
                column.Add(matrix[j][i]);
            }

            if (!(row.Count == matrix.Length)
                || !(column.Count == matrix.Length))
            {
                return false;
            }
        }

        return true;
    }
}