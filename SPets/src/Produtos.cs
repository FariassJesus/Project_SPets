using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SPets.src
{
    internal class Produtos
    {
        public string Produto{ get; set; }
        public int Preco { get; set; }
        public string Codigo { get; set; }

        public Produtos(string produto, int preco, string codigo)
        {
            Produto = produto;
            Preco = preco;
            Codigo = codigo;
        }

        public virtual void Prod()
        {
            WriteLine($"\nO produto {Produto} custa {Preco} cada unidade.");
        }
    }
}
