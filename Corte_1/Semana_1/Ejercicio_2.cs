using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Problema2
{
    class program
    {
        static void Main(string[] args)

        {
            double precio1;
            double precio2;
            double precio3;
            double total1 = 0;

            Console.WriteLine("Digite precio de la pelicula #1");
            precio1 = double.Parse(System.Console.ReadLine());

            Console.WriteLine("Digite precio de la pelicula #2");
            precio2 = double.Parse(System.Console.ReadLine());

            Console.WriteLine("Digite precio de la pelicula #3");
            precio3 = double.Parse(System.Console.ReadLine());

            if (precio1 > precio2 && precio1 > precio3)
            {
                total1 = precio2 + precio3;
                Console.WriteLine("El costo de las 3 peliculas es: {0}", total1);

            }
            else if (precio2 > precio1 && precio2 > precio3)
            {
                total1 = precio1 + precio3;
                Console.WriteLine("El costo de las 3 peliculas es: {0}", total1);

            }
            else
            {
                total1 = precio1 + precio2;
                Console.WriteLine("El costo de las 3 peliculas es: {0}", total1);

            }

            }

        }
    }