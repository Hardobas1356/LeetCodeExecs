Console.WriteLine(Solution.IsValidSudoku([['5','3','.','.','7','.','.','.','.'],
 ['6','.','.','1','9','5','.','.','.'],
 ['.','9','8','.','.','.','.','6','.'],
 ['8','.','.','.','6','.','.','.','3'],
 ['4','.','.','8','.','3','.','.','1'],
 ['7','.','.','.','2','.','.','.','6'],
 ['.','6','.','.','.','.','2','8','.'],
 ['.','.','.','4','1','9','.','.','5'],
 ['.','.','.','.','8','.','.','7','9']]
));

public static class Solution
{
    public static bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            HashSet<char> row = new HashSet<char>();
            HashSet<char> column = new HashSet<char>();

            for (int j = 0; j < board[0].Length; j++)
            {
                if (!row.Add(board[i][j]) && board[i][j] != '.')
                {
                    return false;
                }

                if (!column.Add(board[j][i]) && board[j][i] != '.')
                {
                    return false;
                }

                if (i % 3 == 0 && j % 3 == 0)
                {
                    char[] arr = {
                    board[i][j], board[i][j+1], board[i][j+2],
                    board[i+1][j], board[i+1][j+1], board[i+1][j+2],
                    board[i+2][j], board[i+2][j+1], board[i+2][j+2],
                };

                    HashSet<char> cube = new HashSet<char>();

                    foreach (var num in arr)
                    {
                        if (num != '.' && !cube.Add(num))
                        {
                            return false;
                        }
                    }
                }
            }
        }

        return true;
    }
}