﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class Ruta
{
    public int idRuta { get; set; }

    public string descripcion { get; set; }

    public DateOnly? fecha { get; set; }

    public virtual ICollection<Entrega> Entrega { get; set; } = new List<Entrega>();

    public virtual ICollection<Zona> idZona { get; set; } = new List<Zona>();
}