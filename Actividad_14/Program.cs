using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_14
{
    class Program
    {
        //Solicite el ingreso de dos frases y determine si son iguales, sin diferenciar mayúsculas de minúsculas.
        static void Main(string[] args)
        {
            string Frase_1;
            string Frase_2;
            string NuevaFrase1;
            string NuevaFrase2;

            Console.Write("Por favor, ingrese la primera frase: ");
            Frase_1 = Console.ReadLine();
            Console.Write("Por favor, ingrese la segunda frase: ");
            Frase_2 = Console.ReadLine();
            Console.WriteLine("\r");

            NuevaFrase1 = Frase_1.ToUpper();
            NuevaFrase2 = Frase_2.ToUpper();

            if (NuevaFrase1 == NuevaFrase2)
            {
                Console.WriteLine("Las frases ingresadas son iguales, sin diferenciar mayúsculas de minúsculas.");
            }
            else
            {
                Console.WriteLine("Las frases ingresadas son diferentes, sin diferenciar mayúsculas de minúsculas.");
            }
            Console.ReadLine();
        }
    }
}
