using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a sua idade?");
            var result = Console.ReadLine();

            int userAge = Int32.Parse(result);
        
            if (userAge > 15 && userAge < 51)
            {
                Console.WriteLine("Sim! Você tem idade para o Entra21");
            } 
            // else if (userAge == 14 || userAge == 15)
            // {
            //     Console.WriteLine("Você não tem idade para o Entra21, mas tem idade para ser menor aprendiz");
            // }
            else
            {
                Console.WriteLine("Você não tem idade nem para o Entra21 e nem para ser menor aprendiz");
            }

            Console.WriteLine("Só isso, mais nada!");
        }
    }
}
