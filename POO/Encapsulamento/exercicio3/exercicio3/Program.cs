using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500, 10);
            p.Nome = "TV4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.GetPreco());

        }
    }
}
