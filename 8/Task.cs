public interface ITask
{
    void DisplayTaskDetails();
}

 
public class Task : ITask
{
    public string Description { get; set; }
    public string Priority { get; set; }

    public Task(string description, string priority)
    {
        Description = description;
        Priority = priority;
    }

    public virtual void DisplayTaskDetails()
    {
        Console.WriteLine($"task: {Description} - priority: {Priority}");
    }
}


public class WorkTask : Task
{
    public WorkTask(string description, string priority) : base(description, priority) { }

    public override void DisplayTaskDetails()
    {
        Console.WriteLine($"work task: {Description} - priority: {Priority}");
    }
}

public class PersonalTask : Task
{
    public PersonalTask(string description, string priority) : base(description, priority) { }

    public override void DisplayTaskDetails()
    {
        Console.WriteLine($"personal: {Description} - priority: {Priority}");
    }
}
