// ./ReservarVoo.cs

public class ReservaVooRegular : IReserva
{
    public void ReservarVoo()
    {
        Console.WriteLine("Reservando voo regular...");

    }

    public void CancelarReserva()
    {
        Console.WriteLine("Cancelando reserva de voo regular...");

    }

    public void VerificarStatusReserva()
    {
        Console.WriteLine("Verificando status da reserva de voo regular...");
 
    }
}