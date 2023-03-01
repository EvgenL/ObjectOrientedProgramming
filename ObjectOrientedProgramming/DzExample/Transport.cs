using System.Threading.Channels;

namespace ObjectOrientedProgramming.DzExample;

// abstract : значит что нельзя создать экземпляр через new
// можно создать только экземпляры наследников
public abstract class Transport
{
    // Не может быть переопределён
    // public void Move()
    // {
    //     
    // }
    
    // может быть переопределён
    // public virtual void Move()
    // {
    //     Console.WriteLine("Base method");
    // }
    
    // обязательно должен быть переопределён
    public abstract void Move();
    // {
    //     Console.WriteLine();
    // }
}


public class Ship : Transport
{
    public int Size;
    public int Weight { get; set; }
    public string Color { set; private get; }

    public Ship(int size, int weight, string color)
    {
        Size = size;
        Weight = weight;
        Color = color;
    }

    public Ship()
    {
        
    }

    public override void Move()
    {
        Console.WriteLine("Ship swims");
        // base.Move();
    }
}