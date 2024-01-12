public interface Person
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string ID { get; set; }
}


public class UniversityMember : Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ID { get; set; }

    public UniversityMember(string firstName, string lastName, string id)
    {
        FirstName = firstName;
        LastName = lastName;
        ID = id;
    }
}

public class Student : UniversityMember
{
    

    
    public Student(string firstName, string lastName, string id, int grade, int units)
        : base(firstName, lastName, id)
    {
        Grade = grade;
        Units = units;
    }
    public int Grade { get; set; }
    public int Units { get; set; }


    public void DisplayInfo()
    {
        Console.WriteLine($"Student - Name: {FirstName} {LastName}, ID: {ID}, Grade: {Grade}, Units: {Units}");
    }
}