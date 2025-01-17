using System;

namespace ejerc7
{
    class Program
    {
        static void Main(string[] args)
        { //hacer un programa para que solicite 10 numeros y luego mostrar por pantalla 
         // el maximo de ellos y la posicion en la que fue ingresada.
        int N, M, POS;
        M = 0; 
        POS = 0;

         for (int x = 1; x < 11; x++) {
            Console.WriteLine("ingrese un numero");
            N = int.Parse(Console.ReadLine());
            if(N > M) {
            M = N;
            POS = x; }
                                        
                                        
                                        }
             Console.WriteLine("EL MAYOR ES " + M + " Y LA POSICION ES " + POS);
        }
    }
}
