namespace TestConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(Symbols.X);

        Symbols[,] array = new Symbols[3, 3];

        player.StepPlayer(new Point(0, 0), array);
        player.StepPlayer(new Point(1, 1), array);
        player.StepPlayer(new Point(2, 2), array);
        player.StepPlayer(new Point(2, 2), array); // Вызываем ошибку
    }
}
