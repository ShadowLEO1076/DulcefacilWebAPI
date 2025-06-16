using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DulceFacil.Dominio.Modelos.Abstracciones;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class ClienteRepositoryImpl : RepositoryImpl<Cliente>, InterfaceClienteRepository
    {
        public ClienteRepositoryImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }
    }
}
