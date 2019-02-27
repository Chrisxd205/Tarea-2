using System;
using System.Collections.Generic;
class Employee
{
    private string name;
    private string alias;
   
private decimal salary = 3000.00m;

    
    public Employee(string name, string alias)
    {
        
        this.name = name;
        this.alias = alias;
    }

   
    public void printEmployee()
    {
        Console.WriteLine("Name: {0}\nAlias: {1}", name, alias);
         Console.WriteLine("Tax: {0:C}", Tax.CalcTax(this));
    }

  public decimal Salary
    {
        get { return salary; }
    }
class Tax
{
    public static decimal CalcTax(Employee E)
    {
        return 0.08m * E.Salary;
    }
}

}



class Program
{
    static void Main(string[] args)
        {
        Employee E1 = new Employee("Mingda Pan", "mpan");

      
        E1.printEmployee();
    }
}
