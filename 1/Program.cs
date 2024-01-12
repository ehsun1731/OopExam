var person = new Person();
while (true)
{

    Console.WriteLine("pls enter first name");
    string? FirstName = Console.ReadLine();
    Console.WriteLine("pls enter last name");
    string? LastName = Console.ReadLine();

    var nameAndFamily=person.GetFullName(FirstName,LastName);
    Console.WriteLine($"FullName is : {nameAndFamily}");

}

        
        
    




