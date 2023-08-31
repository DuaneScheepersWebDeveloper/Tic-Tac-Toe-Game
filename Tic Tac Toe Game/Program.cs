namespace Tic_Tac_Toe_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[,]
            {
                {'X', '1', 'O'},
                {'X', 'X', 'O'},
                {'O', 'O', '1'}
            };

            bool hasWinner = CheckForWinner(board);
            Console.WriteLine("Has winner: " + hasWinner);
        }

        static bool CheckForWinner(char[,] board)
        {
            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != '1' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;

                if (board[0, i] != '1' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return true;
            }

            // Check diagonals
            if (board[0, 0] != '1' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;

            if (board[0, 2] != '1' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;

            return false;
        }
    }
}