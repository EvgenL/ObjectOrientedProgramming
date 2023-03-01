namespace ObjectOrientedProgramming.DzExample;

public class Car : Transport
{
    public int WheelsCount { get; set; }
    
    // override : переопределить абстрактный метод
    public override void Move()
    {
        Console.WriteLine("Car drives. WheelsCount : " + WheelsCount);
    }
}