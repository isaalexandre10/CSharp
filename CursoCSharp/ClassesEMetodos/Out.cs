using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Out {
        public static void Executar() {
            //string str = "100";
            string str = "100a";

            if (int.TryParse(str, out int num)) {
                Console.WriteLine("{0}", num + 1);
            } else {
                Console.WriteLine("{0}", num);
                Console.WriteLine("A conversão falhou!");
            }
        }
    }
}
