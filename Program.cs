using ConceptsPoo;

Console.WriteLine("Concepts POO");
Console.WriteLine("************");

Employee employee1 = new SalaryEmployee()
{
    Id = 10,
    FirstName = "Luis",
    LastName = "Laverde",
    BirthDate=new Date(2010,12,31),
    HiringDate=new Date(2023,1,01),
    IsActive = true,
    Salary=6000000.50M
};
Console.WriteLine(employee1);
Employee employee2 = new CommissionEmployee()
{
    Id = 20,
    FirstName = "Laura",
    LastName = "Benavidez",
    BirthDate=new Date(2012,2,27),
    HiringDate=new Date(2022,5,10),
    IsActive = true,
    CommissionPercentaje= 0.03F,
    Sales=380000000M
};
Console.WriteLine(employee2);