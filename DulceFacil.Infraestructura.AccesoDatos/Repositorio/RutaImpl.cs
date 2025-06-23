using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFacil.Dominio.Modelos.Abstracciones;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class RutaImpl : RepositoryImpl<Ruta>, InterfaceRutaRepository
    {
        public RutaImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }
    }
    
   
}
