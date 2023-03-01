namespace ObjectOrientedProgramming;

public class PropertyExample
{
    public static void Test()
    {
        var biba = new Person();

        biba.Name = "Biba";
        biba.Age = -1;
        
        Console.WriteLine($"{biba.Name}'s age is: {biba.Age}");
        ConsoleDrawer.DrawSmile();
        
    }
    
    public class Person
    {
        private int _age;
        private string _name;

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0) value = 0;
                _age = value;
            } 
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public Person()
        {
        }
    }
}