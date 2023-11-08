using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class SubCelebridade {
        //Atributo acessado por Todos
        public string InfoPublica = "Tenho um instagra!";

        //Atributo de Herança
        protected string CorDoOlho = "Verde";

        //mesmo projeto (assembly)
        internal ulong NumeroCelular = 5511999999999;

        // herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //mesma classe ou herança no mesmo projeto (C# >= 7.2)
        //private protected string SegredoFamilia = "Bla bla";

        //private é o valor padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
