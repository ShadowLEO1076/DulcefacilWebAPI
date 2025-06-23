using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFacil.Dominio.Modelos.Abstracciones;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    internal class CategoriaClienteRepositoryImpl : RepositoryImpl<CategoriaCliente>, InterfaceCategoriaClienteRepository
    {
        public CategoriaClienteRepositoryImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }
    }
}
