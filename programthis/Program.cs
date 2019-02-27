using System;
using System.Collections.Generic;
class Trabajador
{
    private string nombre;
    private string alias;
   
private decimal salario = 3000.00m;

    
    public Trabajador(string nombre, string alias)
    {
        
        this.nombre = nombre;
        this.alias = alias;
    }

   
    public void Imprimir()
    {
        Console.WriteLine("Name: {0}\nAlias: {1}", nombre, alias);
         Console.WriteLine("Tax: {0:C}", Tax.CalcTax(this));
    }

  public decimal Salario
    {
        get { return salario; }
    }
class Tax
{
    public static decimal CalcTax(Trabajador E)
    {
        return 0.08m * E.salario;
    }
}

}



class Program
{
    static void Main(string[] args)
        {
        Trabajador E1 = new Trabajador("Mingda Pan", "mpan");

      
        E1.Imprimir();
    }
}
