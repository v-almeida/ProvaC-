// ./Filme.cs

/*5.Implemente um sistema para uma locadora de filmes. 
Crie uma classe Filme com os seguintes atributos: Titulo, Genero, Duracao, Disponivel (indicando se o filme está disponível para locação).
Implemente métodos para registrar a locação de um filme, registrar a devolução de um filme e verificar se um filme está disponível para locação. 
Não há necessidade de implementar rotinas de bancos de dados.*/

public class Filme {

    public string Titulo {get; set;}
    public string Genero {get; set;}
    public decimal Duracao {get; set;}
    public int Disponivel {get; private set;}

    public Filme (string titulo, string genero, decimal duracao, string disponivel){

        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
        Disponivel = disponivel;

    }

    public void DevolverFilme (int quantidade){

        if (quantidade > 0){
            Disponivel = Disponivel + quantidade;
            Console.WriteLine($"Filme {Titulo} devolvido. Disponiveis: {Disponivel}")
        }
        else{

            Console.WriteLine("Para devolver o filme, primeiro você precisa ter feito a locação. :)")
        
            }

    }

    public void LocarFilme (int quantidade){

        if (quantidade > 0 && quantidade <= Disponivel){
            Disponivel -= quantidade;
            Console.WriteLine($"Filme {Titulo} locado. Disponiveis {Disponivel}");

        }
        else{
            Console.WriteLine("Filme não disponível para locação.")

            }
    }

    public bool DisponibilidadeFilme(){

        return Disponivel > 0;
    }

}