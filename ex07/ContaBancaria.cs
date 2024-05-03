// ./ContaBancaria.cs


/* public class ContaBancaria {

    public string Tipo {get; set;}
    public double Saldo {get; set;}

    public ContaBancaria(string tipo, double saldo){

        Tipo = tipo;
        Saldo = saldo;

    }

    public virtual void Sacar(double valor){

        if (valor <= Saldo)
            Saldo -= valor;
        else
            Console.WriteLine("Saldo insuficiente para saque.");
    }

    public virtual void ExibirSaldo(){
        Console.WriteLine($"Saldo da conta {Tipo}: R$ {Saldo:F2}");
    }

} */