using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a sua idade?");
            var result = Console.ReadLine();
            var userAge = Int32.Parse(result);
        
            if (userAge > 17)
            {
                Console.WriteLine("Sim! Eu sou maior de idade");
            } 
            else
            {
                Console.WriteLine("Não! Eu sou menor de idade");
            }
        }
    }
}
