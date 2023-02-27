namespace ObjectOrientedProgramming;

public class ClassExample
{
    public static void Test()
    {
        Airplane plane = new Airplane("Boeing");

        plane.DeleteName();

    }
}

public class Airplane
{
    private string _name; // Поле

    public void DeleteName() // Метод
    {
        _name = "";
        OnNameDeleted?.Invoke();
    }
    
    public int MaxSpeed { get; private set; } // Свойство

    public Airplane(string name) // Конструктор
    {
        _name = name;
        MaxSpeed = 900;
    }
    
    public event Action OnNameDeleted; // Cобытие
}
