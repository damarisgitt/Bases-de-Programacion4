using System;

namespace ejerc10
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa que solicite 20 numeros y luego emitir por pantalla el maximo 
            // de los numeros pares y el minimo de los numeros impares! 

            int n1, maxima, minimo;
            maxima = 0;
            minimo = 0;

            for(int x = 0; x < 20; x++){
            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());

            if(n1 % 2 == 0){
                 if(n1 > maxima){
                    maxima = n1;
                }
            
            }else if(minimo == 0){
                    minimo = n1;
                }else if(n1 < minimo){
                    minimo = n1;
                }
                   
            }

            
                 Console.WriteLine(" el maximo de los pares es: " + maxima );
                 Console.WriteLine("el minimo de los impares es: " + minimo );
            
        }
    }
}
