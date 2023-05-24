using interface_obj_parametro;

Carrinho carrinho = new Carrinho();

Produto p1 = new Produto(1, "Call of Duty", 350f);
Produto p2 = new Produto(2, "Mineirinho Ultra Adventures", 2.30f);
Produto p3 = new Produto(3, "The Last of Us", 150f);

// Adicionar

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

//Listar

carrinho.Listar();

// Valor do carrinho

carrinho.ValorTotal();

// REmover

carrinho.Remove(p1);

//Listar

carrinho.Listar();

// Valor do carrinho

carrinho.ValorTotal();

//Atualizar

Produto produtoAtualizado = new Produto();
produtoAtualizado.Nome = "Mineirinho Directors Cut";
produtoAtualizado.Preco = 2.40f;

carrinho.Atualizar(2, produtoAtualizado);

//Listar

carrinho.Listar();

// Valor do carrinho

carrinho.ValorTotal();