public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        for (int row = 0; row < 9; row++)
        {
            HashSet<char> rowSet = new HashSet<char>();

            for (int col = 0; col < 9; col++)
            {
                if (board[row][col] == '.')
                    continue;

                if (!rowSet.Add(board[row][col]))
                    return false;
            }
        }

        for (int col = 0; col < 9; col++)
        {
            HashSet<char> colSet = new HashSet<char>();

            for (int row = 0; row < 9; row++)
            {
                if (board[row][col] == '.')
                    continue;

                if (!colSet.Add(board[row][col]))
                    return false;
            }
        }

        for (int rowStart = 0; rowStart < 9; rowStart += 3)
        {
            for (int colStart = 0; colStart < 9; colStart += 3)
            {
                HashSet<char> boxSet = new HashSet<char>();

                for (int row = rowStart; row < rowStart + 3; row++)
                {
                    for (int col = colStart; col < colStart + 3; col++)
                    {
                        if (board[row][col] == '.')
                            continue;

                        if (!boxSet.Add(board[row][col]))
                            return false;
                    }
                }
            }
        }

        return true;
    }
}