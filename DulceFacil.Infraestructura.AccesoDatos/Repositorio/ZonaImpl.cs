using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFacil.Dominio.Modelos.Abstracciones;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class ZonaImpl : RepositoryImpl<Zona>, InterfaceZonaRepository
    {
        public ZonaImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }
    }
    
}
