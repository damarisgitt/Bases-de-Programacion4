using System;

namespace ejerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa que solicite el ingreso de 10 numeros y 
            //que muestre el mayor de ellos por pantalla.Solo se debe emitir UN valor por pantalla
            
            int N = 0, M;
            M = 0;

            for(int x = 0; x < 10; x++) {
                Console.WriteLine("ingrese un numero porfavor ");
                N = int.Parse(Console.ReadLine());
              
                 if (N > M) {
                    M = N;  }
            }
            Console.WriteLine("el mayor es "  + M);

        }
    }
}
