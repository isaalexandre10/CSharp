using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            int hashCode = -347481536;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Preco.GetHashCode();
            return hashCode;
        }

        //public override bool Equals(object obj) {
        //    Produto outroProduto = (Produto)obj;
        //    bool mesmoNome = Nome == outroProduto.Nome;
        //    bool mesmoPreco = Preco == outroProduto.Preco;
        //    return mesmoNome && mesmoPreco;
        //}

        //public override int GetHashCode() {
        //    return Nome.Length;
        //}
    }
    class ColecoesList {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
            Console.WriteLine(carrinho.Count);
        }
    }
}
