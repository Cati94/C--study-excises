using System;

namespace cursobasico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos de datos de C#

            int cajaentero = 7;
            int cajaenteronegativo = -5;

            double val_hierro = 9.3;
            double val_leucina = 120.5;

            decimal dinero = (decimal)50.9898;
            decimal dinero2 = 50.9898M;

            char letra = 'h';


            string texto = "Primeiro programa em C #";

            bool verdadero = true;

            // Como imprimir en c#

            Console.WriteLine(texto);

            Console.WriteLine(cajaentero);

            Console.WriteLine(cajaenteronegativo);

            Console.WriteLine(val_hierro);

            Console.WriteLine(val_leucina);

            Console.WriteLine(letra);

            Console.WriteLine(dinero);

            Console.WriteLine(dinero2);

            Console.WriteLine(verdadero);

            // Aqui inicia mi condicional 

            // condicional numero = a que 

            if (cajaentero==cajaenteronegativo)
            {
                Console.WriteLine("son iguales");
                
            }
            else
            {
                Console.WriteLine("no son iguales");
            }
            // condicional diferente que 

            if (cajaentero !=cajaenteronegativo) 
            {
                Console.WriteLine("son diferentes");

            }

            // condicional mayor que 
            if (cajaentero > cajaenteronegativo)
            {
                Console.WriteLine(cajaentero+" es mayor que "+cajaenteronegativo);
            }

            // condicional menor que

            if (cajaentero < cajaenteronegativo)
            {
                Console.WriteLine(cajaentero +"es menor que " + cajaenteronegativo);
            }
        }

        

    }
}
