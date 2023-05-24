using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/Produto.csv";

        //criar um construtor

        public Produto()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);                
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }
    }
}