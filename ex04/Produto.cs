// ./produto.cs

/* 4.	Crie uma classe Produto que represente um produto em uma loja online. A classe deve ter os seguintes atributos: 
Nome, Preco, QuantidadeEmEstoque. 
Implemente métodos para adicionar e remover unidades do estoque, e um método para calcular o valor total do produto em estoque. 
Os métodos devem alterar o estado do objeto instanciado*/

/* public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int QuantidadeEmEstoque { get; private set; }

    public Produto(string nome, decimal preco, int quantidadeEmEstoque)
    {
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
            QuantidadeEmEstoque += quantidade;
        else
            Console.WriteLine("Quantidade inválida. Não foi possível adicionar ao estoque.");
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= QuantidadeEmEstoque)
            QuantidadeEmEstoque -= quantidade;
        else
            Console.WriteLine("Quantidade inválida ou insuficiente. Não foi possível remover do estoque.");
    }

    public decimal CalcularValorTotalEmEstoque()
    {
        return Preco * QuantidadeEmEstoque;
    }
} */