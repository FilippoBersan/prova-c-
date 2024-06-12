using System;

namespace EsempioQuadrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero:");
            string input = Console.ReadLine();

            // Convertire l'input in un numero intero
            if (int.TryParse(input, out int numero))
            {
                int quadrato = numero * numero;
                Console.WriteLine($"Il quadrato di {numero} è {quadrato}.");
            }
            else
            {
                Console.WriteLine("Per favore, inserisci un numero valido.");
            }
        }
    }
}
