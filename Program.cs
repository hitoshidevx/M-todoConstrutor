using System;

namespace MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem first = new Personagem();

            Personagem soldado = new Personagem("Ryan");
            System.Console.WriteLine(soldado.Nome);

            System.Console.WriteLine();

            Personagem link = new Personagem("Link", "Hyliano", 100, 150);
            System.Console.WriteLine(link.Nome);
            System.Console.WriteLine(link.Classe);
            System.Console.WriteLine(link.Vida);
            System.Console.WriteLine(link.Escudo);
        }
    }
}
