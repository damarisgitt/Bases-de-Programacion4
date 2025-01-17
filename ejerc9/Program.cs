using System;

namespace ejerc9
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas 
            // personas mayores a 18 años.
            int edad, Mayores, Con, Promedio;
            Con = 0;
            Mayores = 0;    
            for (int x = 0; x <= 20; x++){
            Console.WriteLine("ingrese la edad");  
             edad = int.Parse(Console.ReadLine());
             if (edad > 18) { 
                Mayores += edad; 
                Con ++;

             } 
                    } 
                   Promedio =  Mayores / Con++;   
                    Console.WriteLine("El promedio es  "  +  Promedio  +  " y la cantidad es " +  Con);

        }
    }
}
