using System;
using System.Collections.Generic;
class Employee
{
    private string name;
    private string alias;
   

    
    public Employee(string name, string alias)
    {
        
        this.name = name;
        this.alias = alias;
    }

   
    public void printEmployee()
    {
        Console.WriteLine("Name: {0}\nAlias: {1}", name, alias);
     
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
