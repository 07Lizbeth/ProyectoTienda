﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejadores
{
    public class ManejadorProductos : IManejador
    {
        AccesoProductos ap = new AccesoProductos();
        Grafico g = new Grafico();
        public void Actualizar(dynamic Entidad)
        {
            ap.Actualizar(Entidad);
            g.Mensaje("Producto actualizado", "¡atecion¡", MessageBoxIcon.Information);
        }

        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("Estas seguro de borrar: {0}", Entidad.Nombre), "!Atencion!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ap.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            ap.Guardar(Entidad);
            g.Mensaje("Producto guardado", "¡atecion¡", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ap.Mostrar().Tables["productos"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Red));
        }
    }
    public class Grafico
    {
        public void Mensaje(string t, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(t, titulo, MessageBoxButtons.OK, icono);
        }
        public DataGridViewButtonColumn Boton(string titulo, Color color)
        {
            DataGridViewButtonColumn c = new DataGridViewButtonColumn();
            c.Text = titulo;
            c.DefaultCellStyle.BackColor = color;
            c.UseColumnTextForButtonValue = true;
            return c;
        }
    }
}
