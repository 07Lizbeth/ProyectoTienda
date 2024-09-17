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
            Actualizar();
        }
        void Actualizar()
        {
            mp.Mostrar(dgvProductos);
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (col)
            {
                case 4:
                    {
                        FrmAddProductos fap = new FrmAddProductos();
                        fap.ShowDialog();
                        Actualizar();
                    }
                    break;
                case 5:
                    {
                        mp.Borrar(productos);
                        Actualizar();
                    }
                    break;
            }
        }

        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
            productos.IdProducto = int.Parse(dgvProductos.Rows[fila].Cells[0].Value.ToString());
            productos.Nombre = dgvProductos.Rows[fila].Cells[1].Value.ToString();
            productos.Descripcion = dgvProductos.Rows[fila].Cells[2].Value.ToString();
            productos.Precio = double.Parse(dgvProductos.Rows[fila].Cells[3].Value.ToString());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            productos.IdProducto = -1;
            FrmAddProductos fap = new FrmAddProductos();
            fap.ShowDialog();
        }
    }
}
