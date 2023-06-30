namespace SimpleApp_Lucas.Models;

public class CuentaCorriente : Cuenta
{
    public bool TieneLineaCredito { get; set; }
    public bool TieneTarjetaCredito { get; set; }

}