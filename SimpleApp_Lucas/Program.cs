using SimpleApp_Lucas.Models;

namespace SimpleApp_Lucas;

class Program
{
    static void Main(string[] args)
    {
        var clientes = LlenadoInicial();

        var cuenta1 = new CuentaCorriente()
        {
            Id = 1
        };

        var cuenta2 = new CuentaCorriente()
        {
            Id = 2
        };

        clientes[0].Cuenta = cuenta1;
        clientes[1].Cuenta = cuenta2;
        Cliente clientebuscado = new();
        bool flag = true;

        while (flag)
        {
            Console.Write("Ingrese el ID del cliente:");

            if (int.TryParse(Console.ReadLine(), out int idCliente))
            {
                foreach (var cliente in clientes)
                {
                    if (cliente.Id == idCliente)
                    {
                        clientebuscado = cliente;
                        flag = false;
                        break;
                    }
                    else
                        break;
                }
            }
            else
            {
                Console.WriteLine("El Id de cliente no es válido.");
            }
        }

        flag = true;
        var ultimaTransaccion = 0;

        if (clientebuscado != null)
        {
            while (flag)
            {
                Console.Write("Ingrese un monto para la transaccion:");
                if (int.TryParse(Console.ReadLine(), out int montoTransaccion))
                {
                    if (montoTransaccion == 0)
                        break;

                    var transacciones = clientebuscado.Cuenta.Transacciones;


                    if (transacciones.Count > 0)
                    {
                        ultimaTransaccion = transacciones.Last().Id;
                        ultimaTransaccion += 1;
                    }


                    clientebuscado.Cuenta.Transacciones.Add(new Transaccion { Id = ultimaTransaccion, Fecha = DateTime.Now, Monto = montoTransaccion });
                }
                else
                {
                    Console.WriteLine("Debe ingresar un monto valido.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Detalle de las transacciones");
            Console.WriteLine("****************************");
            Console.WriteLine();

            var saldoFinal = 0;

            foreach (var t in clientebuscado.Cuenta.Transacciones)
            {
                string tipoTransaccion = "Ingreso";
                saldoFinal += t.Monto;

                if (t.Monto < 0)
                    tipoTransaccion = "Gasto";

                Console.WriteLine($"Fecha:{t.Fecha}, Monto: {Math.Abs(t.Monto)}, Tipo Transaccion: {tipoTransaccion}");
            }

            Console.WriteLine($"Saldo final en cuenta: {saldoFinal}");
        }
    }

    static List<Cliente> LlenadoInicial()
    {
        var clientes = new List<Cliente>() {
            new Cliente{ Id = 1, Nombre = "Josefa", ApellidoP = "Puebla" },
            new Cliente{ Id = 2, Nombre = "Pedro", ApellidoP = "Gomez" },
            new Cliente{ Id = 3, Nombre = "Julian", ApellidoP = "Volados" },
            new Cliente{ Id = 4, Nombre = "Fernanda", ApellidoP = "Dominguez" },
            new Cliente{ Id = 5, Nombre = "Lorena", ApellidoP = "Castro" },
            new Cliente{ Id = 6, Nombre = "Javiera", ApellidoP = "Lira" },
        };

        return clientes;
    }
}