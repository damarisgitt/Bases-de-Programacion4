using System;

namespace ejerc11
{
    class Program
    {
        static void Main(string[] args)
        {
            //hacer un programa para ingresar 10 numeros y luego calcule y emita el mayor de los primos de la
            // lista, en caso de no haber ningun numero primo, debera aclararlo con un cartel.

            int n, maxpri, nopri, cont, band;
            nopri = 0;
            maxpri = 0;
            band = 0;

            for(int y = 0; y < 10; y++){
            
                Console.WriteLine("ingrese un numero");
                n = int.Parse(Console.ReadLine());
                cont = 0;
            
                
                for(int x = 1; x <= n ; x++){
                    if(n % x == 0){
                        cont++;}
            }
                if(cont == 2){
                  if(band == 0){
                    maxpri = n;
                    band = 1;
                }else { 
                        if (n > maxpri){
                    maxpri = n; }  
                
            }} else{
                nopri++;
            } 
            }
           if(nopri == 0){
               Console.WriteLine("No hay primos");
             }else{
                Console.WriteLine( "El maximo primo es  " + maxpri);
             }
    }   }
}
