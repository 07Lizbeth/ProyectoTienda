using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    internal interface IManejador
    {
        void Guardar(dynamic Entidad);
        void Actualizar(dynamic Entidad);
        void Borrar(dynamic Entidad);
        void Mostrar(DataGridView tabla);
    }
}
