namespace SimpleApp_Lucas.Models;

public class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public string ApellidoP { get; set; } = string.Empty;

    public Cuenta Cuenta { get; set; } = new CuentaCorriente();
}