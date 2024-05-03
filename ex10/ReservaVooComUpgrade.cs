// ./ReservarVooComUpgrade.cs

public class ReservaVooComUpgrade : IReserva
{
    public void ReservarVoo()
    {
        Console.WriteLine("Reservando voo com upgrade de classe...");

    }

    public void CancelarReserva()
    {
        Console.WriteLine("Cancelando reserva de voo com upgrade de classe...");

    }

    public void VerificarStatusReserva()
    {
        Console.WriteLine("Verificando status da reserva de voo com upgrade de classe...");

    }
}