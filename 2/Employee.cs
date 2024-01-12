
public class Employee
{

    public Employee(string employeeId, int salary)
    {
        employeeId = EmployeeID!;
        salary = Salary;
    }
    
    public string? EmployeeID { get; set; }

    public int Salary { get; set; }
    public virtual void PrintDetails()
    {
        foreach (var item in Job.employees)
        {
            Console.WriteLine($"{item.EmployeeID}\n{item.Salary}");
        }

    }
}
public class Manager : Employee
{
    public Manager(string managerId, int msalary, string department) : base(managerId, msalary)
    {
        ManagerID = managerId;
        Salary = msalary;
        Department = department;
    }
    
    public string? ManagerID { get; set; }
    public int Salary { get; set; }
    public string Department { get; set; }
    
    public override void PrintDetails()
    {
        foreach (var item in Job.managers)
        {
            Console.WriteLine($"{item.ManagerID}\n{item.Salary}\n{item.Department}");
        }
        base.PrintDetails();



    }
}
