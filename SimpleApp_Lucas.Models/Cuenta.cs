namespace SimpleApp_Lucas.Models;

public abstract class Cuenta
{
    public int Id { get; set; }
    public DateTime FechaApertura { get; set; } = DateTime.Now;
    public int Saldo { get; set; } = 0;
    public List<Transaccion> Transacciones { get; set; } = new();
}