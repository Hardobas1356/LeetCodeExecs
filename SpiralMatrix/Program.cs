Console.WriteLine(String.Join(' ',Solution.SpiralOrder([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]])));

public static class Solution
{
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        int boundaryRight = matrix[0].Length - 1; 
        int boundaryDown = matrix.GetLength(0) - 1;
        int boundaryLeft = 0;
        int boundaryUp = 1;

        int[] right = { 0, 1 };
        int[] down = { 1, 0 };
        int[] left = { 0, -1 };
        int[] up = { -1, 0 };

        int[] currentCoordinates = { 0, 0 };
        int[] direction = right;
        List<int> result = [matrix[currentCoordinates[0]][currentCoordinates[1]]];

        int size = matrix[0].Length * matrix.GetLength(0);
        int counter = 1;

        while (counter < size)
        {
            if (direction == right && currentCoordinates[1] == boundaryRight)
            {
                direction = down;
                boundaryRight--;
            }
            else if (direction == down && currentCoordinates[0] == boundaryDown)
            {
                direction = left;
                boundaryDown--;
            }
            else if (direction == left && currentCoordinates[1] == boundaryLeft)
            {
                direction = up;
                boundaryLeft++;
            }
            else if (direction == up && currentCoordinates[0] == boundaryUp)
            {
                direction = right;
                boundaryUp++;
            }

                currentCoordinates[0] += direction[0];
            currentCoordinates[1] += direction[1];

            counter++;
            result.Add(matrix[currentCoordinates[0]][currentCoordinates[1]]);
        }

        return result;
    }
}