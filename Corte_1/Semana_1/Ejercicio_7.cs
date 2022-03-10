using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Problema7
{
    class program
    {
        static void Main(string[] args)
        {
            int A = 500;
            int B = 230;
            int C = 250;
            int suma = 0; 
            double media = 0; 


            if (A >= 500)
            {
                System.Console.WriteLine("las ventas del producto A son {0} y ellas son las mas elevadas",A);
            }
            if (A >= 200) 
                if (B >= 200)
                    if(C >= 200)

                    {
                 System.Console.WriteLine("las ventas de los productos no son inferiores a 200, ya que  A es {0}, B {1} y C {2}", A,B,C);
                    }
            if (A >= 400)
            {
                System.Console.WriteLine("las ventas del producto A son {0}, por lo tanto son superiores a 400", A);
            }
            media = ((A + B + C) / 3);
            System.Console.WriteLine("la media de la venta de productos es {0}, es imposible que ella sea mayor a 500 ya que la venta de productos debe estar en un rango de 500 a 1000 ", media);

            if (B < A && B < C)
            {
            System.Console.WriteLine("las ventas del producto B son {0}, por lo tanto el producto B es el menos vendido", B);
            }
            
            suma = A + B + C; 
            if (A+B+C>500 || A+B+C<1000)
            {
                System.Console.WriteLine("la suma de la venta de los tres productos es:{0}", suma);
            }
        }

    }
}