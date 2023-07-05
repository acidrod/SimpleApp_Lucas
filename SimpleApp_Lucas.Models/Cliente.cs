namespace SimpleApp_Lucas.Models;
public class Cliente
{
    public Guid Id { get;} = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public DateTime FechaNac { get; set; }
    public IEnumerable<Auto> Autos { get; set; }
    public Sexo sexo;
}

public enum Sexo
{
    MASCULINO,
    FEMENINO
}
