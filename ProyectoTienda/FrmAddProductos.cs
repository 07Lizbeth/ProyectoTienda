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
            if (FrmProductos.productos.IdProducto > 0)
            {
                txtNombre.Text = FrmProductos.productos.Nombre;
                txtDescripcion.Text = FrmProductos.productos.Descripcion;
                txtPrecio.Text = FrmProductos.productos.Precio.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmProductos.productos.IdProducto > 0)
            {
                mp.Actualizar(new Productos(FrmProductos.productos.IdProducto, txtNombre.Text, txtDescripcion.Text,
                    double.Parse(txtPrecio.Text)));
                Close();
            }
            else
            {
                mp.Guardar(new Productos(FrmProductos.productos.IdProducto, txtNombre.Text, txtDescripcion.Text,
                double.Parse(txtPrecio.Text)));
                Close();
            }
        }
    }
}
