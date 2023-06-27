using ClienteProyecto.Models;
class Program
{
    static void Main(string[] args)
    {
        agregarCliente();
        modificarCliente();
        consultarCliente();


    }

    public static void agregarCliente()
    {
        Console.WriteLine("Metodo agregar estudiante");
        ClienteproyectoContext context = new ClienteproyectoContext();
        Cliente std = new Cliente();
        std.Nombre = "Jose";
        std.Apellido= "Ordoñez";
        std.Direccion = "Urdesa";
        std.Telefono = 95074120;
        std.FechaNacimiento = 2023;
        std.Estado = "Activo";
        context.Clientes.Add(std);
        context.SaveChanges();

        Console.WriteLine("Codigo: " + std.Id + " Nombre: " + std.Nombre + "Aellido" + std.Apellido + "Dirección: " + std.Direccion + "Telefono: " + std.Telefono + "Fecha Nacimiento: " + std.FechaNacimiento + "Estado: " + std.Estado);

    }

    public static void consultarCliente()
    {
        Console.WriteLine("Metodo consultar estudiantes");
        ClienteproyectoContext context= new ClienteproyectoContext();
        List<Cliente> listClientes =context.Clientes.ToList();

        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.Id+ " Nombre: " + item.Nombre);
        }
    }

    public static void modificarCliente()
    {
        Console.WriteLine("Metodo modificar estudiante");
            ClienteproyectoContext context= new ClienteproyectoContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(1);
        std.Nombre= "Ana";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.Id + " Nombre: " + std.Nombre);

    }
}


