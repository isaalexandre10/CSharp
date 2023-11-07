using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;

            //Arredonda com 1 casa decimal
            Console.WriteLine(valor.ToString("F1"));

            //C significa moeda
            Console.WriteLine(valor.ToString("C"));

            //P de percentual
            Console.WriteLine(valor.ToString("P"));

            //Numero com 2 casas decimais
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));

            CultureInfo cultura2 = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura2));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
