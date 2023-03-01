namespace ObjectOrientedProgramming;

public class SettersExample
{
    public static void Test()
    {
        
        ConsoleDrawer.Number = 10941124;
        // var biba = new Person();
        //
        // biba.SetName("Biba");
        //
        // Console.WriteLine($"{biba.GetName()}'s age is: {biba.GetAge()}");
        //
        // biba.SetAge(1);
    }
    
    public class Person
    {
        private int _age;
        private string _name;
        
        public void SetAge(int newAge)
        {
            if (_age < 0) _age = 0;
            _age = newAge;
        }
        
        public void SetName(string newName)
        {
            _name = newName;
        }

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
