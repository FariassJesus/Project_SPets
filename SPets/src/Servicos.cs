using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SPets.src
{
    internal class Servicos
    {
        public string BanhoeTosa { get; set; }
        public int Preco { get; set; }

        public Servicos(string banhoetosa, int preco)
        {
            BanhoeTosa = banhoetosa;
            Preco = preco;
        }
        public virtual void Serv()
        {
            WriteLine($"O serviço {BanhoeTosa} custa {Preco}");
        }
    }
}
