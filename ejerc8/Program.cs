using System;

namespace ejerc8
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa que solicite 20 numeros y luego mostrar por pantalla 
            // el menor de ellos y la posicion en la que fue encontrado.

            int n, pos, menor;
            pos = 0;
            menor = 0;

            for(int x = 0; x < 20; x++){

                Console.WriteLine("ingrese un numero");
                n = int.Parse(Console.ReadLine());

                if(x == 0){
                    menor = n;
                    pos = 1;
                }else if(n < menor){
                    menor = n;
                    pos = x + 1;
                }
            } 
                 Console.WriteLine("el menor es: " + menor + " en la posicion: " + pos);
        }
    }
}
