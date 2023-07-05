namespace SimpleApp_Lucas.Models;
public class EmailNotification : INotificacion
{
    public void Notify(string mensaje)
    {
        Console.WriteLine($"Enviado email a cliente {mensaje}");
    }
}
