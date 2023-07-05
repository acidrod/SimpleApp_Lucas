namespace SimpleApp_Lucas.Models;
public class SmsNotification : INotificacion
{
    public void Notify(string mensaje)
    {
        Console.WriteLine($"Enviando SMS a cliente {mensaje}");
    }
}
