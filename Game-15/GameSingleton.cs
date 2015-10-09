namespace Game15
{
    using System;

    public sealed class GameSingleton : IPlayable
    {
        private static readonly int[,] boardNumbers = new int[4, 4] 
        { 
            { 1, 2, 3, 4 }, 
            { 5, 6, 7, 8 }, 
            { 9, 10, 11, 12 }, 
            { 13, 14, 15, 0 } 
        };

        private static readonly GameSingleton instance = new GameSingleton();
        private int counter;
        private int currentBoardRow = 3, currentBoardCol = 3;
        Random random;
        int randomNumber;
        int row;
        int col;
        int numberForSwap;

        private GameSingleton()
        {
            counter = 0;
            this.random = new Random();
            this.row = currentBoardRow - 1;
            this.col = currentBoardCol;
        }

        public int[,] BoardNumbers
        {
            get { return boardNumbers; }
        }

        public int this[int i, int j]{
            get { return boardNumbers[i, j]; }
            set { boardNumbers[i, j] = value; }
        }

        public int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        public int CurrentBoardRow
        {
            get { return currentBoardRow; }
            set { currentBoardRow = value; }
        }

        public int CurrentBoardCol
        {
            get { return currentBoardCol; }
            set { currentBoardCol = value; }
        }

        public static GameSingleton Instance
        {
            get
            {
                return instance;
            }
        }


        public void CreateGameField()
        {

            for (int i = 0; i < 1000; i++)
            {
                randomNumber = random.Next(3);
                if (randomNumber == 0)
                {
                    row = currentBoardRow - 1;
                    col = currentBoardCol;
                    if (row >= 0 && row <= 3 && col >= 0 && col <= 3)
                    {
                        numberForSwap = boardNumbers[currentBoardRow, currentBoardCol];
                        boardNumbers[currentBoardRow, currentBoardCol] = boardNumbers[row, col];
                        boardNumbers[row, col] = numberForSwap;
                        currentBoardRow = row;
                        currentBoardCol = col;
                    }
                    else
                    {
                        randomNumber++;
                        i--;
                    }
                }

                if (randomNumber == 1)
                {
                    row = currentBoardRow;
                    col = currentBoardCol + 1;
                    if (row >= 0 && row <= 3 && col >= 0 && col <= 3)
                    {
                        numberForSwap = boardNumbers[currentBoardRow, currentBoardCol];
                        boardNumbers[currentBoardRow, currentBoardCol] = boardNumbers[row, col];
                        boardNumbers[row, col] = numberForSwap;
                        currentBoardRow = row;
                        currentBoardCol = col;
                    }
                    else
                    {
                        randomNumber++;
                        i--;
                    }
                }

                if (randomNumber == 2)
                {
                    row = currentBoardRow + 1;
                    col = currentBoardCol;
                    if (row >= 0 && row <= 3 && col >= 0 && col <= 3)
                    {
                        numberForSwap = boardNumbers[currentBoardRow, currentBoardCol];
                        boardNumbers[currentBoardRow, currentBoardCol] = boardNumbers[row, col];
                        boardNumbers[row, col] = numberForSwap;
                        currentBoardRow = row;
                        currentBoardCol = col;
                    }
                    else
                    {
                        randomNumber++;
                        i--;
                    }
                }

                if (randomNumber == 3)
                {
                    row = currentBoardRow;
                    col = currentBoardCol - 1;
                    if (row >= 0 && row <= 3 && col >= 0 && col <= 3)
                    {
                        numberForSwap = boardNumbers[currentBoardRow, currentBoardCol];
                        boardNumbers[currentBoardRow, currentBoardCol] = boardNumbers[row, col];
                        boardNumbers[row, col] = numberForSwap;
                        currentBoardRow = row;
                        currentBoardCol = col;
                    }
                    else
                    {
                        i--;
                    }
                }
            }
        }
    }
}