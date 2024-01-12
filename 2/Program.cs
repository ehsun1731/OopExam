

using System.Runtime.InteropServices;


while (true)
{

    Console.WriteLine("1- Add employee\n" +
                      "2- Add manager\n");

    var option = int.Parse(Console.ReadLine()!);
    switch (option)
    {
        case 1:

            Console.WriteLine("enter ID");
            var employeeID = Console.ReadLine();
            Console.WriteLine("enter salary");
            var salary = int.Parse(Console.ReadLine()!);
            Employee empeloyee = new Employee(employeeID!, salary);

            Job.employees.Add(empeloyee);
            empeloyee.PrintDetails();

            break;


        case 2:

            Console.WriteLine("enter ID");
            var managerId = Console.ReadLine();
            Console.WriteLine("enter salary");
            var salaryy = int.Parse(Console.ReadLine()!);
            Console.WriteLine("enter department");
            var department = Console.ReadLine();
            var manager = new Manager(managerId!, salaryy, department!);

            Job.managers.Add(manager);
            manager.PrintDetails();
            break;



    }
}



