using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Shell
{
    public static class Program 
    {
        public static void Main() 
        {
           int n1=0, n2=0, Resultado1=0, Resultado2=0;
           string salir="si", VA="x²";
           
           while(salir=="si")
           {
           Console.WriteLine("Digite dos números. ");
           n1=int.Parse(System.Console.ReadLine());
           n2=int.Parse(System.Console.ReadLine());
           
           if (n1>0 && n2<0){
           	Resultado1=(n1+n2);
           	Resultado2=(n1*n2);
            Console.Write($"(x+{n1})(x{n2})");
            Console.WriteLine($"={VA}+{Resultado1}{Resultado2}");
           }
           if (n1>0 && n2>0){
           	Resultado1=(n1+n2);
           	Resultado2=(n1*n2);
            Console.Write($"(x+{n1})(x+{n2})");
            Console.WriteLine($"={VA}+{Resultado1}+{Resultado2}");
           }
           if (n1<0 && n2<0){
            Resultado1=(n1+n2);
           	Resultado2=(n1*n2);
            Console.Write($"(x{n1})(x{n2})");
            Console.WriteLine($"={VA}{Resultado1}+{Resultado2}");
           }
           if (n1<0 && n2>0){
           	Resultado1=n1+n2;
           	Resultado2=n1*n2;
           	Console.Write($"(x{n1})(x+{n2})");
           	Console.WriteLine($"={VA}{Resultado1}{Resultado2}");
           }
           	
           Console.WriteLine("Desea repetir la operación.");
           Console.WriteLine("Digite (si o no).");
           salir=System.Console.ReadLine();
           }
           Console.WriteLine("Programa finalizado.");
           
        }
    }
}