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
    public partial class FrmProductos : Form
    {
        ManejadorProductos mp;
        public static Productos productos = new Productos(0, "", "", 0);
        int fila = 0, col = 0;
        public FrmProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            mp.Mostrar(dgvProductos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            productos.IdProducto = -1;
            FrmAddProductos fap = new FrmAddProductos();
            fap.ShowDialog();
        }
    }
}
