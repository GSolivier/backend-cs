using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interface_obj_parametro
{
    public interface ICarrinho
    {
        //definir/declarar quais os métodos deverão ser implementados
        //na classe que herdar desta interface

        //CRUD: Create/Read/Update/Delete

        //Create
        void Adicionar(Produto _produto);

        //Read
        void Listar();

        //Update
        void Atualizar(int _codigo, Produto _produto);

        //Delete
        void Remove(Produto _produto);

    }
}