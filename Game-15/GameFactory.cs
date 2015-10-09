namespace Game15
{
    public class GameFactory
    {
        public GameSingleton initGame;
        public GameFacade facade;

        public GameFactory()
        {
            initGame = GameSingleton.Instance;
            facade = new GameFacade(initGame);
        }
    }
}