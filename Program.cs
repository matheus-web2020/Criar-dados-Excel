using System;
using System.IO;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 2;
            p1.Nome = "Guitarra Gibson";
            p1.Preco = 4500f;

            p1.Cadastrar(p1);

        }
    }
}
