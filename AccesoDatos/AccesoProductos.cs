using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class AccesoProductos : IEntidades
    {
        ConectarBD b = new ConectarBD("localhost", "root", "", "tienda");
        public void Actualizar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertar('{0}','{1}',{2})", Entidad.Nombre,
                Entidad.Descripcion, Entidad.Precio));
        }

        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("select * from productos;"), "productos");
        }
    }
}
