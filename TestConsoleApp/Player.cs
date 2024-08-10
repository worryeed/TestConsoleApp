namespace TestConsoleApp;

public class Player
{
    private const Symbols EMPTY_CELL = Symbols.Empty;

    public Symbols Symbol { get; private set; }

    public Player(Symbols symbol)
    {
        Symbol = symbol;
    }

    public void StepPlayer(Point point, Symbols[,] array)
    {
        if (IsStepCorrect(point, array))
        {
            MakeStep(point, array);
        }
        else
        {
            throw new Exception($"Incorrect step: {point.X} {point.Y}");
        }
    }

    private bool IsStepCorrect(Point point, Symbols[,] array)
    {
        return array[point.X, point.Y] == EMPTY_CELL;
    }

    private void MakeStep(Point point, Symbols[,] array)
    {
        array[point.X, point.Y] = Symbol;
    }
}
