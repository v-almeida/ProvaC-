// ./ReservarVooGrupoGrande.cs

public class ReservaVooGrupoGrande : IReserva
{
    public void ReservarVoo()
    {
        Console.WriteLine("Reservando voo para grupo grande...");

    }

    public void CancelarReserva()
    {
        Console.WriteLine("Cancelando reserva de voo para grupo grande...");

    }

    public void VerificarStatusReserva()
    {
        Console.WriteLine("Verificando status da reserva de voo para grupo grande...");

    }
}