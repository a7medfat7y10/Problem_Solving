namespace Reveal_Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] result =  RevealMinesweeper(
                new string[][] { new string[] { "M", "M" }, 
                new string[] { "H", "H" },
                new string[] { "H", "H" } },
            2, 0);
            foreach (string[] result2 in result)
            {
                foreach(string str in result2)
                {
                    Console.Write(str);
                }
                Console.WriteLine();
            }
        }
        //O(w*h) time / O(w*h) space
        public static string[][] RevealMinesweeper(string[][] board, int row, int column)
        {
            // Write your code here.
            if (board[row][column] == "M")
            {
                board[row][column] = "X";
                return board;
            }
            int numOfNieghbourMines = 0;
            List<Coordinate> neighbours = GetNeighbours(board, row, column);
            foreach (var neighbour in neighbours)
            {
                if (board[neighbour.row][neighbour.col] == "M")
                    numOfNieghbourMines++;
            }
            if (numOfNieghbourMines > 0)
                board[row][column] = numOfNieghbourMines.ToString();
            else
            {
                board[row][column] = "0";
                foreach (var neighbour in neighbours)
                {
                    if (board[neighbour.row][neighbour.col] == "H")
                        RevealMinesweeper(board, neighbour.row, neighbour.col);
                }
            }

            return board;
        }
        public static List<Coordinate> GetNeighbours(string[][] board, int row, int col)
        {
            int[,] directions = new int[8, 2]{
            {0,1},{0,-1},{1,0},{-1,0},{1,1},{1,-1},{-1,1},{-1,-1,}
        };
            List<Coordinate> neighbours = new List<Coordinate>();
            for (int i = 0; i < directions.GetLength(0); i++)
            {
                int neighbourRow = row + directions[i, 0];
                int neighbourCol = col + directions[i, 1];
                if (neighbourRow >= 0 && neighbourRow < board.Length && neighbourCol >= 0 && neighbourCol < board[0].Length)
                {
                    neighbours.Add(new Coordinate(neighbourRow, neighbourCol));
                }
            }
            return neighbours;
        }
        public class Coordinate
        {
            public int row;
            public int col;
            public Coordinate(int row, int col)
            {
                this.row = row;
                this.col = col;
            }
        }
    }
}