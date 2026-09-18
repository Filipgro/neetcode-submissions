public class Solution
{
    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        int n = grid.Length;

        if (n == 0 || grid[0].Length == 0)
        {
            return -1;
        }

        if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1)
        {
            return -1;
        }

        if (n == 1)
        {
            return 1;
        }

        int[] dr = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dc = { -1, 0, 1, -1, 1, -1, 0, 1 };

        Queue<(int row, int col)> q = new Queue<(int row, int col)>();

        q.Enqueue((0, 0));
        grid[0][0] = 1; 

        int pathLength = 1;

        while (q.Count > 0)
        {
            int levelSize = q.Count;

            for (int i = 0; i < levelSize; i++)
            {
                var (row, col) = q.Dequeue();

                if (row == n - 1 && col == n - 1)
                {
                    return pathLength;
                }

                for (int direction = 0; direction < 8; direction++)
                {
                    int newRow = row + dr[direction];
                    int newCol = col + dc[direction];

                    if (newRow < 0 || newRow >= n ||
                        newCol < 0 || newCol >= n ||
                        grid[newRow][newCol] == 1)
                    {
                        continue;
                    }

                    grid[newRow][newCol] = 1;
                    q.Enqueue((newRow, newCol));
                }
            }

            pathLength++;
        }

        return -1;
    }
}