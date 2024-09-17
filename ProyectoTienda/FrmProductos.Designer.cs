namespace ProyectoTienda
{
    partial class FrmProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(56, 148);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(333, 71);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar Tabla";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1050, 148);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 71);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(56, 225);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 92;
            this.dgvProductos.RowTemplate.Height = 37;
            this.dgvProductos.Size = new System.Drawing.Size(1113, 562);
            this.dgvProductos.TabIndex = 4;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellEnter);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 871);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}

