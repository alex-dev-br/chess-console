using board;

internal class Program
{
    private static void Main(string[] args)
    {
        Position P;
        P = new Position(3, 4);

        Console.WriteLine("Position: " + P);
        Console.WriteLine();

        Board board = new Board(8, 8);
        Console.WriteLine();
    }
}