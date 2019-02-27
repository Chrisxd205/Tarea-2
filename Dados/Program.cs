using System;

namespace Dados
{
    

    class Dados
    {
public string color;
public int valor;
 public Dados(int valor)
 {
this.valor=valor;
 }
 public Dados(string color)
 {
  this.color=color;
 }
 public void imprimir()
 {
     Console.WriteLine(valor);
 }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Dados d1= new Dados(4);
           Dados d2 = new Dados(3);
           Dados d3 = new Dados(1);
            d1.imprimir();
            d2.imprimir();
            d3.imprimir();
       
        }
    }
}
