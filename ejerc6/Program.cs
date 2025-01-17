using System;

namespace ejerc6
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa que solicite un numero y luego calcule y emita un cartel aclaratorio 
            //si el mismo es primo o no es primo.

            int n = 0, cont;
            cont = 0;

             Console.WriteLine("INGRESE UN NUMERO");
             n = int.Parse(Console.ReadLine()); 

           
            for(int x = 1; x <= n; x++){

                  if(n % x == 0){ 
                    cont++; 
                }
                }
            
            if(cont == 2){
                Console.WriteLine("es primo");
            }else{
                Console.WriteLine("no es primo");
            }

    
        }
    }
}
