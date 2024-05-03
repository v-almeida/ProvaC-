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

/* class Program
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
} */

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// EXERCICIO 06

//CARRO

/* Carro carro = new Carro();
carro.Ano = "2018";
carro.Placa = "RGM36113620";
carro.NumeroDePortas = 4;
carro.Modelo = "Onix";
carro.Marca = "Chevrolet";
Console.WriteLine("Ano: " + carro.Ano);
Console.WriteLine("Placa: " + carro.Placa);
Console.WriteLine("Numero de portas: " + carro.NumeroDePortas);
Console.WriteLine("Modelo: " + carro.Modelo);
Console.WriteLine("Marca do Carro: " + carro.Marca); */

//MOTO

/* Moto moto = new Moto();
moto.Ano = "2018";
moto.Placa = "RGM36113620";
moto.QuantidadeCilindrada = 400;
moto.Modelo = "kawasaki";
moto.Marca = "kawasaki";
Console.WriteLine("Ano: " + moto.Ano);
Console.WriteLine("Placa: " + moto.Placa);
Console.WriteLine("Numero de cilindradas: " + moto.QuantidadeCilindrada);
Console.WriteLine("Modelo: " + moto.Modelo);
Console.WriteLine("Marca do moto: " + moto.Marca); */

// BICICLETA

/* Bicicleta bicicleta = new Bicicleta();
bicicleta.Ano = "2018";
bicicleta.QuantidadeMarcha = 21;
bicicleta.Modelo = "BMX";
bicicleta.Marca = "Colli Bikes";
Console.WriteLine("Ano: " + bicicleta.Ano);
Console.WriteLine("Numero de marchas: " + bicicleta.QuantidadeMarcha);
Console.WriteLine("Modelo: " + bicicleta.Modelo);
Console.WriteLine("Marca da bike: " + bicicleta.Marca); */


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//EXERCICIO 07

/* class Program
{
    static void Main()
    {
        ContaBancaria corrente = new ContaBancaria("Corrente", 1000.0);
        corrente.Sacar(200.0);
        corrente.ExibirSaldo();

        Poupanca poupanca = new Poupanca("Poupança", 5000.0);
        poupanca.CalcularJuros(1.5);
        poupanca.ExibirSaldo();

        Empresarial empresarial = new Empresarial("Empresarial", 30000.0);
        empresarial.VerificarSaldoMinimo(20000.0);
    }
} */

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//EXERCICIO 08

/* public class Program
{
    public static void Main()
    {
        var cursoIngles = new Ingles(nota1: 8.5, nota2: 9.0, pagamento: 500.0, curso: "Inglês");
        Console.WriteLine($"Curso: {cursoIngles.Curso}");
        Console.WriteLine($"Média de Notas: {cursoIngles.CalcularMedia()}");
        Console.WriteLine($"Certificado: {cursoIngles.GerarCertificado()}");
    }
} */
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// EXERCICIO 09

/* class Program
{
    static void Main()
    {
        double valorCompra = 100.0;

        IMetodoPagamento metodo1 = new CartaoCredito();
        metodo1.Pagar(valorCompra);
        Console.WriteLine(metodo1.StatusPagamento("Aprovado"));

        IMetodoPagamento metodo2 = new BoletoBancario();
        metodo2.Pagar(valorCompra);
        Console.WriteLine(metodo2.StatusPagamento("Pendente"));

        IMetodoPagamento metodo3 = new TransferenciaBancaria();
        metodo3.Pagar(valorCompra);
        Console.WriteLine(metodo3.StatusPagamento("Concluída"));
    }
} */

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//EXERCICIO 10

class Program
{
    static void Main()
    {

        IReserva reserva = new ReservaVooRegular();
        reserva.ReservarVoo();
        reserva.VerificarStatusReserva();

        reserva = new ReservaVooComUpgrade();
        reserva.ReservarVoo();
        reserva.CancelarReserva();

        reserva = new ReservaVooGrupoGrande();
        reserva.ReservarVoo();
    }
}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
















