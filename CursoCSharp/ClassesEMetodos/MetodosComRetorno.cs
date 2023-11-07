using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Subtrair(int a, int b) { 
            return a - b; 
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }

        public int Divide(int a, int b) {
            return (a / b);
        }
    }

    class CalculadoraCadeia {
        int memoria;
        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a) {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Dividir(int a) {
            memoria /= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }
    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(3, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));
            Console.WriteLine(calculadoraComum.Divide(8, 2));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir()
                .Limpar().Imprimir();
            calculadoraCadeia.Somar(3).Dividir(1).Imprimir()
                .Limpar();
            calculadoraCadeia.Somar(9).Subtrair(3).Imprimir()
                .Limpar();

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
