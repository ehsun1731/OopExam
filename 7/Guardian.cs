public interface IPerson
{
    string Name { get; set; }
    string CodeMeli { get; set; }
    void Enter();
}


public class People : IPerson
{
    public string Name { get; set; }
    public string CodeMeli { get; set; }

    public void Enter()
    {
        Console.WriteLine($"{Name} is in the public hall.");
    }
}


public class Employee : IPerson
{
    public string Name { get; set; }
    public string CodeMeli { get; set; }
    public string Id { get; set; }

    public void Enter()
    {
        Console.WriteLine($"{Name} is in the company.");
    }
}