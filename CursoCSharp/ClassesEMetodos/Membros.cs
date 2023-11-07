using System;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 30;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Mauro";
            fulano.Idade = 34;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
