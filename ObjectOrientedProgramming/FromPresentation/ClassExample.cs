namespace ObjectOrientedProgramming;

public class ClassExample
{
    public static void Test()
    {
        Airplane2 plane = new Airplane2("Boeing");

        plane.DeleteName();

    }
}

public class Airplane2
{
    private string _name; // Поле

    public void DeleteName() // Метод
    {
        _name = "";
        OnNameDeleted?.Invoke();
    }
    
    public int MaxSpeed { get; private set; } // Свойство

    public Airplane2(string name) // Конструктор
    {
        _name = name;
        MaxSpeed = 900;
    }
    
    public event Action OnNameDeleted; // Cобытие
}
