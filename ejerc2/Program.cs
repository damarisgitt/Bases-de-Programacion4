using System;

namespace ejerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 20 numeros y calcule y emita por pantalla 
            // cuantos son positivos (mayores a cero). Se debe mostrar un solo valor: 
            // el conteo final.

            int n = 0, cont;
            cont = 0;

            for(int x = 0; x < 20; x++){

                Console.WriteLine("ingrese un numero por favor ");
                n = int.Parse(Console.ReadLine());

                if(n > 0){
                    cont++;

                }

            }

            Console.WriteLine("de los 20 numeros " + cont + " son positivos");
        }
    }
}
