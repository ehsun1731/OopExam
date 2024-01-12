

var people = new List<IPerson>();


people.Add(new People { Name = "akbar", CodeMeli = "3384569987" });
people.Add(new People { Name = "asghar", CodeMeli = "2125698634" });


people.Add(new Employee { Name = "ehsan", CodeMeli = "3380435295", Id = "55g55" });
people.Add(new Employee { Name = "ali", CodeMeli = "2125687416", Id = "12f56" });


foreach (var person in people)
{
    person.Enter();
}
