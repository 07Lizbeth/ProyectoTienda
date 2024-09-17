using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace ProyectoTienda
{
    public partial class FrmAddProductos : Form
    {
        ManejadorProductos mp;
        Productos productos = null;
        public FrmAddProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mp.Guardar(new Productos(FrmProductos.productos.IdProducto, txtNombre.Text, txtDescripcion.Text,
                double.Parse(txtPrecio.Text)));
            Close();
        }
    }
}
