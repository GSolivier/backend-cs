using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lista
{
    public class Produto
    {
        public string Codigo;
        public string Nome;

        public float Preco { get; set; }

        public Produto()
        {
            
        }

        public Produto(string codigo, string nome, float preco)
        {
            Codigo = codigo;
            Preco = preco;
            Nome = nome;
        }
    }
}