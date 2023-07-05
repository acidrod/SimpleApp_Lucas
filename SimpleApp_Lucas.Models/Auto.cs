namespace SimpleApp_Lucas.Models;
public class Auto
{
    private double _cilindrada;

    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public double Cilindrada { 
        get => _cilindrada; 
        set 
        {
            _cilindrada = value;
        }
    }

    public double Consumo()
    {
        return _cilindrada * 100;
    }
}
