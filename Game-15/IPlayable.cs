namespace Game15
{
    public interface IPlayable
    {
        int[,] BoardNumbers { get; }
        void CreateGameField();
        int Counter { get; set; }
        int CurrentBoardRow { get; set; }
        int CurrentBoardCol { get; set; }
        int this[int a, int b] { get; set; }
    }
}