using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SPets.src
{
    internal class Animais
    {
        public string Nome { get; set; }
        public string Especie { get; set; }

        public Animais(string nome, string especie)
        {
            Nome = nome;
            Especie = especie;
        }
        public virtual void Adocao()
        {
            WriteLine($"O amigo {Nome}, da espécie {Especie}, está procurando um lar.");
        }
    }
}
