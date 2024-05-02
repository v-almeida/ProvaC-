// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

//EXERCICIO 01

//Código do Program Exercicio 01 corrigido com o Copilot bing.

/* class Program
{
    static void Main()
    {
        var gerente1 = new gerente
        {
            nome = "Ana",
            numeroIdentificacao = "RGM36113620",
            salario = 30000,
            gerencia = "Vendas",
            cargo = "Gerente de Vendas"
        };

        Console.WriteLine(gerente1.tipoDepartamento());
        Console.WriteLine($"Nome: {gerente1.nome}");
        Console.WriteLine($"Salário: {gerente1.salario}");
        Console.WriteLine($"Cargo: {gerente1.cargo}");
        Console.WriteLine($"ID: {gerente1.numeroIdentificacao}");
    }
} */
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//EXERCICIO 02



/* class Program
{
    static void Main(string[] args)
    {
        var cartao = new CartaoCredito();
        double precoProduto = 100.0;
        double valorPago = cartao.PagarOnline(precoProduto);

        Console.WriteLine($"Valor pago com cartão de crédito: R${valorPago:F2}");
    }
} */

/* class Program
{
    static void Main(string[] args)
    {
        var boleto = new BoletoBancario();
        double precoProduto = 200.0;
        double valorPago = boleto.PagarOnline(precoProduto);

        Console.WriteLine($"Valor pago no boleto bancário: R${valorPago:F2}");
    }
} */

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// EXERCICIO 03

// OVERRIDE e OVERLOADING

/* ave Tucano = new ave();
Tucano.porte = "Médio";
Tucano.alimentacao = "Onivoro";
Console.WriteLine(Tucano.porte);
Console.WriteLine(Tucano.alimentacao);
Console.WriteLine(Tucano.somEmitido()); */

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//EXERCICIO 04

/* class Program
{
    static void Main()
    {
        // Exemplo de uso
        var produto1 = new Produto("Camiseta", 29.99m, 50);
        Console.WriteLine($"Produto: {produto1.Nome}");
        Console.WriteLine($"Preço: R${produto1.Preco}");
        Console.WriteLine($"Quantidade em estoque: {produto1.QuantidadeEmEstoque}");
        Console.WriteLine($"Valor total em estoque: R${produto1.CalcularValorTotalEmEstoque()}");

        // Adicionando e removendo do estoque
        produto1.AdicionarEstoque(10);
        produto1.RemoverEstoque(5);
        Console.WriteLine($"Quantidade em estoque após operações: {produto1.QuantidadeEmEstoque}");
    }
} */

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//EXERCICIO 05

class Program
{
    static void Main()
    {

        var movie = new Filme("Kill Bill", "Ação", 1.45m, 4);
        Console.WriteLine($"Filme: {movie.Titulo}");
        Console.WriteLine($"Genero: {movie.Genero}");
        Console.WriteLine($"Duracao: {movie.Duracao}");
        Console.WriteLine($"Disponível para locação: {movie.Disponivel}");

        movie.LocarFilme(1);
        movie.DevolverFilme(1);

        if (movie.DisponibilidadeFilme()){

            Console.WriteLine($"Filme {movie.Titulo} Disponível para locação.");
        } else {
            Console.WriteLine($"Filme {movie.Titulo} não está disponível para locação.");
        }
    }
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


