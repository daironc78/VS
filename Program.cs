using System;

namespace WindowsCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos = new Metodos();
            int Tamanio = 100;
            int[] Array = { 1, 4, -1, 3, 2, };

            // PRIMER EJERCICIO
            Console.WriteLine("Ejercicio numero uno");
            int posicion = metodos.ContarSaltos(Array);
            Console.WriteLine("El -1 esta en el salto numero: " + posicion + "\n \n Ejercicio numero dos");

            // SEGUNDO EJERCICIO
            int numero = metodos.DistintoNumero(Array);
            Console.WriteLine("El numero menor que no esta en el arrego es: " + numero + "\n \n Ejercicio numero tres");

            // TERCER EJERCICIO
            metodos.Divisores(Tamanio);
            
            Console.ReadKey();
        }
    }
}
// QUE FUNCIONE EL ALGORITMO
// TIEMPOS DE EJECUCION OPTIMOS
// CALIDAD DEL CODIGO