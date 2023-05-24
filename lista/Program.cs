using lista;


//Cria uma lista de objetos
List<Produto> produtos = new List<Produto>();

//Inserir objetos de produtos dentro da lista
//através de uma instância direta (com construtor)

produtos.Add(
        new Produto("1234", "Camiseta Lacoste", 19.99f)
);

//através de uma instância básica de objeto
Produto camisetaArmani = new Produto("1235", "Camiseta Armani", 49.90f);
produtos.Add(camisetaArmani);

foreach (var item in produtos)
{
    Console.WriteLine($"{item.Codigo}, {item.Nome}, {item.Preco:C}");
    
}

//UPDATE

//acessar um objeto da lista para poder manipulá-lo
Produto produtoEncontrado = produtos.Find(x => x.Codigo == "1235");

//encontrar o indice do produto encontrado
int index = produtos.IndexOf(produtoEncontrado);

//exibir o indice no console
Console.WriteLine($"O indice do produto encontrado é o: {index}");

//fazer alterações
produtoEncontrado.Preco = 599f;

//remover o item antigo da lista
produtos.RemoveAt(index);


//devolver o item atualizado no lugar
produtos.Insert(index, produtoEncontrado);

//lista atualiuzada
foreach (var item in produtos)
{
    Console.WriteLine($"{item.Codigo}, {item.Nome}, {item.Preco:C}");
    
}