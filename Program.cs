using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            var myText = "meu texto";
            var muNumber = 8;
            var myPrice = 4.099;
            var myBoolean = false;

            Console.WriteLine("Voce e maior de idade");
            var result = Console.ReadLine();

            myBoolean = result == "sim";
            Console.WriteLine(myBoolean);

        }
    }
}
