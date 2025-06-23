using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFacil.Dominio.Modelos.Abstracciones;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class ProductoImpl : RepositoryImpl<Producto>, InterfaceProductoRepository
    {
        public ProductoImpl(DulceFacilDBContext contexto) : base(contexto)
        {
        }
    }
    
}
