//Employee emp1 = new Employee("Abubakr", "Nozimzoda");
//        emp1.Age = 18;
//
//        Console.WriteLine($"Employee: {emp1.FirstName} {emp1.LastName}");
//        Console.WriteLine($"Birth Year: {emp1.GetBirthYear()}");
//section 2
var employees = new List<Employee>()
{
    new Employee()
    {
        Id = 1,
        FirstName = "Alijon",
        LastName = "Zabirov",
        Age = 24,
        PhoneNumber = "881667007",
        Salary = 4000
    },
    new Employee()
    {
        Id = 2,
        FirstName = "Nurullo",
        LastName = "Sulaymonov",
        Age = 30,
        PhoneNumber = "908765432",
        Salary = 8000
    },
    new Employee()
    {
        Id = 3,
        FirstName = "Shodmon",
        LastName = "Inoyatzoda",
        Age = 26,
        PhoneNumber = "987009988",
        Salary = 7800
    }
};
//section 3
var newEmployees = new List<Employee>()
{
    new Employee()
    {
        Id = 4,
        FirstName = "Abubakr",
        LastName = "Nozimzoda",
        Age = 18,
        PhoneNumber = "977251313",
        Salary = 0
    },
    new Employee()
    {
        Id = 5,
        FirstName = "Umed",
        LastName = "Majodov",
        Age = 17,
        PhoneNumber = "987345123",
        Salary = 1
    }
};
employees.AddRange(newEmployees);

//section 4
employees = employees.OrderBy(emp => emp.Salary).ToList();

//section 5
employees.RemoveAll(emp => emp.Age < 25);

//section 6
employees.FindAll(emp => emp.Salary < 5000);

//section 7
var employeeToRemove = employees.FirstOrDefault(emp => emp.Id == 3);
if (employeeToRemove != null)
{
    employees.Remove(employeeToRemove);
}

//section 8
bool exists = employees.Exists(emp => emp.FirstName == "Jura");

if (!exists)
{
    employees.Insert(1, new Employee()
    {
        Id = 6,
        FirstName = "Jura",
        LastName = "Jurayev",
        Age = 28,
        PhoneNumber = "900123456",
        Salary = 5000
    });
}

//section 9
var extraEmployees = new List<Employee>()
{
    new Employee()
    {
        Id = 7,
        FirstName = "Firdavs",
        LastName = "Sharipov",
        Age = 29,
        PhoneNumber = "911223344",
        Salary = 6000
    },
    new Employee()
    {
        Id = 8,
        FirstName = "Karim",
        LastName = "Rahmonov",
        Age = 35,
        PhoneNumber = "922334455",
        Salary = 7000
    },
    new Employee()
    {
        Id = 9,
        FirstName = "Said",
        LastName = "Aliyev",
        Age = 27,
        PhoneNumber = "933445566",
        Salary = 7500
    }
};
employees.InsertRange(1, extraEmployees);
// section 10
employees = employees.OrderByDescending(emp => emp.Salary).ToList();


foreach (var emp in employees)
{
    Console.WriteLine($"Id: {emp.Id}, Name: {emp.FirstName} {emp.LastName}, Age: {emp.Age}, Phone: {emp.PhoneNumber}, Salary: {emp.Salary}");
}

    