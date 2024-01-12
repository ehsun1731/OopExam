
public  class Person
{

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public  string GetFullName(string FirstName, string LastName)
    {
        return FirstName + " " + LastName;

    }

}

