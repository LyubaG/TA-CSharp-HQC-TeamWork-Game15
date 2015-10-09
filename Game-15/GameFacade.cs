namespace Game15
{
    public class GameFacade
    {
        private GameStrategy strategy;
        private MoveNumber moveNumber;
        public GameFacade(IPlayable gameInstance)
        {
            strategy = new GameStrategy();
            moveNumber = new MoveNumber(gameInstance);
        }

        public void Move(int number)
        {
            moveNumber.Move(number);
        }
    }
}