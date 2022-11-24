using board;
using chess_console;

internal class Program
{
    private static void Main(string[] args)
    {
        Board board = new Board(8, 8);
        Console.WriteLine();

        Screen.PrintBoard(board);
        Console.WriteLine();
    }
}