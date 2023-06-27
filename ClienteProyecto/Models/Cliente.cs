using System;
using System.Collections.Generic;

namespace ClienteProyecto.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Direccion { get; set; }

    public int? Telefono { get; set; }

    public int? FechaNacimiento { get; set; }

    public string? Estado { get; set; }
}
