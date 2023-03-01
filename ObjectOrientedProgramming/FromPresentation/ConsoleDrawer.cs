namespace ObjectOrientedProgramming;

public static class ConsoleDrawer
{
    // public static int Number; то же самое, что и ниже
    public static int Number { get; set; } // <- избегаем
    // public static int Number { get; private set; } // <- не можем записывать, это ок
    // public static int Number { get; } // <- не можем записывать, ни откуда
    
    public static void DrawSmile()
    {
        Console.WriteLine("¯\\_(ツ)_/¯");
    }

    public static void DrawNumber()
    {
        Console.WriteLine(Number); 
    }

}