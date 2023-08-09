using System;
using System.Collections.Generic;

 public delegate bool IsPromotable(Employee emp);
 public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Salery { get; set; }

    public int Experience { get; set; }


    public static void PromoteEmployee(List<Employee> Employlist,IsPromotable isPromotable)
    {
        foreach(Employee employee in Employlist)
        {
            if (isPromotable(employee))
            {
                Console.WriteLine(employee.Name + "Promoted");
            }
        }
    }


}
class Program
{
    public static void Main()
    {
        List<Employee> Emplist = new List<Employee>();
        Emplist.Add(new Employee
        {
            Id = 101, Name = "Himanshu", Salery =6000 , Experience = 6
        }) ;
        Emplist.Add(new Employee
        {
            Id = 102,
            Name = "Abhishek",
            Salery = 5000,
            Experience = 5
        });
        Emplist.Add(new Employee
        {
            Id = 103,
            Name = "Rajpal",
            Salery = 4000,
            Experience = 4
        });
        Emplist.Add(new Employee
        {
            Id = 104,
            Name = "Anjali",
            Salery = 3000,
            Experience = 3
        });
        Employee.PromoteEmployee(Emplist, Emp => Emp.Experience >= 5);
       

    }

    
}