public class Solution
{
    private static readonly int[][] directions =
    {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 }
    };

    public int NumIslands(char[][] grid)
    {
        if (grid == null || grid.Length == 0 || grid[0].Length == 0)
        {
            return 0;
        }

        int rows = grid.Length;
        int columns = grid[0].Length;
        int islands = 0;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                if (grid[r][c] == '1')
                {
                    Bfs(grid, r, c);
                    islands++;
                }
            }
        }

        return islands;
    }

    private void Bfs(char[][] grid, int r, int c)
    {
        Queue<int[]> queue = new Queue<int[]>();

        grid[r][c] = '0';
        queue.Enqueue(new int[] { r, c });

        while (queue.Count > 0)
        {
            int[] node = queue.Dequeue();
            int row = node[0];
            int col = node[1];

            foreach (int[] direction in directions)
            {
                int nextRow = row + direction[0];
                int nextCol = col + direction[1];

                if (nextRow >= 0 &&
                    nextCol >= 0 &&
                    nextRow < grid.Length &&
                    nextCol < grid[0].Length &&
                    grid[nextRow][nextCol] == '1')
                {
                    grid[nextRow][nextCol] = '0';
                    queue.Enqueue(new int[] { nextRow, nextCol });
                }
            }
        }
    }
}