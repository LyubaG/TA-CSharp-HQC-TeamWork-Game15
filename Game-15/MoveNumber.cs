namespace Game15
{
    using System;

    public class MoveNumber : IMovable
    {
        private IPlayable gameInstance;
        private int[,] boardNumbers;
        int currentRow;
        int currentCol;

        public MoveNumber(IPlayable gameInstance)
        {
            this.gameInstance = gameInstance;
            this.boardNumbers = gameInstance.BoardNumbers;
            this.currentRow = this.gameInstance.CurrentBoardRow;
            this.currentCol = this.gameInstance.CurrentBoardCol;
        }

        public void Move(int number)
        {
            this.currentRow = this.gameInstance.CurrentBoardRow;
            this.currentCol = this.gameInstance.CurrentBoardCol;
            int row = gameInstance.CurrentBoardRow;
            int col = gameInstance.CurrentBoardCol;

            bool isFoundNumber = false;
            for (int i = 0; i < 4; i++)
            {
                if (!isFoundNumber)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (gameInstance.BoardNumbers[i, j] == number)
                        {
                            row = i;
                            col = j;
                            isFoundNumber = true;
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            bool isFoundEmptyCell = IsEmptyNeighbourCell(row, col);
            if (!isFoundEmptyCell)
            {
                Console.WriteLine("Illegal move!");
            }
            else
            {
                int numberForSwap = gameInstance.BoardNumbers[row, col];
                gameInstance[row, col] = gameInstance.BoardNumbers[currentRow, currentCol];
                gameInstance[currentRow, currentCol] = numberForSwap;
                gameInstance.CurrentBoardRow = row;
                gameInstance.CurrentBoardCol = col;
                gameInstance.Counter++;
            }
        }

        private bool IsEmptyNeighbourCell(int row, int col)
        {
            if ((row == currentRow - 1 || row == currentRow + 1) && col == currentCol)
            {
                return true;
            }

            if ((row == currentRow) && (col == currentCol - 1 || col == currentCol + 1))
            {
                return true;
            }

            return false;
        }

    }
}