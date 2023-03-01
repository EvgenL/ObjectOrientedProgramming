namespace ObjectOrientedProgramming.DzExample;

public class Airplane : Transport
{
    // можно создать через сокращенную записть ctor и tab
    public Airplane()
    {
    }
    
    
    public override void Move()
    {
        Console.WriteLine("Plane flies");
    }
}