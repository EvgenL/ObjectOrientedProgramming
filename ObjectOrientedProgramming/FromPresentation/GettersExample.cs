namespace ObjectOrientedProgramming;

public class GettersExample
{
    public static void Test()
    {
        var biba = new Person(10, "Biba");
        var boba = new Person();
        
        Console.WriteLine($"{biba.GetName()}'s age is: {biba.GetAge()}");
        
        Console.WriteLine($"{boba.GetName()}'s age is: {boba.GetAge()}");
        ConsoleDrawer.DrawSmile();
    }
    
    public class Person
    {
        private int _age;
        private string _name;

        public int GetAge()
        {
            return _age;
        }
    
        public string GetName()
        {
            return _name;
        }

        public Person(int age, string name)
        {
            _age = age;
            _name = name;
        }

        public Person()
        {
        }
    }
}
