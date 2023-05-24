using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interface_obj_parametro
{
    public class Carrinho : ICarrinho
    {
        public float valor { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Listar()
        {
            if(carrinho.Count != 0){

                foreach (Produto x in carrinho)
                {
                    Console.WriteLine($"Nome: {x.Nome}, Código: {x.Codigo}, Preço: {x.Preco}");
                }
            }
        }

        public void Atualizar(int _codigo, Produto _novoproduto)
        {
            carrinho.Find( x => x.Codigo == _codigo).Nome = _novoproduto.Nome;
            carrinho.Find( x => x.Codigo == _codigo).Preco = _novoproduto.Preco;
        }

        public void Remove(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void ValorTotal()
        {
           valor = 0;

            if (carrinho.Count > 0 || carrinho != null)
            {
                foreach (Produto x in carrinho)
                {
                    valor += x.Preco;
                }
            Console.WriteLine($"Valor total do carrinho: {valor:C}");
            }
            else{
                Console.WriteLine($"Seu carrinho está vazio!");
                
            }
        
        }
    }

}