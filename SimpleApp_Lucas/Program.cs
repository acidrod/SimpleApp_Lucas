using SimpleApp_Lucas.Models;

namespace SimpleApp_Lucas;

class Program
{
    static void Main(string[] args)
    {
        List<Cliente> clientes = new();
        var cliente1 = new Cliente();
        cliente1.Nombre = "Julian";
        cliente1.sexo = Sexo.MASCULINO;
        cliente1.FechaNac = new DateTime(2000, 10, 24);

        cliente1.Autos = new List<Auto>() {
            new Auto() {
                Id = 1,
                Marca = "Mazda",
                Modelo = "MX5",
                Cilindrada = 1.8
            }
        };


        var cliente2 = new Cliente();
        cliente2.sexo = Sexo.FEMENINO;
        cliente2.Autos = new Queue<Auto>();

        clientes.Add(cliente1);
        clientes.Add(cliente2);

        foreach (var cli in clientes)
        {
            Console.WriteLine($"Notificando a cliente Id {cli.Id}");
            foreach (var item in cli.Autos)
            {
                Console.WriteLine($"Consumo auto {item.Modelo} => {item.Consumo()}");
            }
        }
    }
}