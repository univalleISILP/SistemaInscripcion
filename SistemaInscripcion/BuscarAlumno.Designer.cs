namespace SistemaInscripcion
{
    partial class BuscarAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCIalumnoBuscar = new System.Windows.Forms.TextBox();
            this.dbgListaAlumnosBuscar = new System.Windows.Forms.DataGridView();
            this.txtNombrealumnoBuscar = new System.Windows.Forms.TextBox();
            this.btnCancelarBuscarAlu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgListaAlumnosBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCIalumnoBuscar
            // 
            this.txtCIalumnoBuscar.BackColor = System.Drawing.Color.White;
            this.txtCIalumnoBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIalumnoBuscar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCIalumnoBuscar.Location = new System.Drawing.Point(40, 50);
            this.txtCIalumnoBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCIalumnoBuscar.Multiline = true;
            this.txtCIalumnoBuscar.Name = "txtCIalumnoBuscar";
            this.txtCIalumnoBuscar.Size = new System.Drawing.Size(171, 24);
            this.txtCIalumnoBuscar.TabIndex = 91;
            this.txtCIalumnoBuscar.Text = "numero";
            this.txtCIalumnoBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCIalumnoBuscar.TextChanged += new System.EventHandler(this.TxtCIalumnoBuscar_TextChanged);
            this.txtCIalumnoBuscar.Enter += new System.EventHandler(this.TxtCIalumnoBuscar_Enter);
            this.txtCIalumnoBuscar.Leave += new System.EventHandler(this.TxtCIalumnoBuscar_Leave);
            // 
            // dbgListaAlumnosBuscar
            // 
            this.dbgListaAlumnosBuscar.AllowUserToDeleteRows = false;
            this.dbgListaAlumnosBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbgListaAlumnosBuscar.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dbgListaAlumnosBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgListaAlumnosBuscar.Location = new System.Drawing.Point(40, 84);
            this.dbgListaAlumnosBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.dbgListaAlumnosBuscar.Name = "dbgListaAlumnosBuscar";
            this.dbgListaAlumnosBuscar.ReadOnly = true;
            this.dbgListaAlumnosBuscar.RowHeadersVisible = false;
            this.dbgListaAlumnosBuscar.RowHeadersWidth = 62;
            this.dbgListaAlumnosBuscar.RowTemplate.Height = 28;
            this.dbgListaAlumnosBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbgListaAlumnosBuscar.Size = new System.Drawing.Size(751, 232);
            this.dbgListaAlumnosBuscar.TabIndex = 92;
            // 
            // txtNombrealumnoBuscar
            // 
            this.txtNombrealumnoBuscar.BackColor = System.Drawing.Color.White;
            this.txtNombrealumnoBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrealumnoBuscar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNombrealumnoBuscar.Location = new System.Drawing.Point(251, 50);
            this.txtNombrealumnoBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombrealumnoBuscar.Multiline = true;
            this.txtNombrealumnoBuscar.Name = "txtNombrealumnoBuscar";
            this.txtNombrealumnoBuscar.Size = new System.Drawing.Size(171, 24);
            this.txtNombrealumnoBuscar.TabIndex = 93;
            this.txtNombrealumnoBuscar.Text = "nombre";
            this.txtNombrealumnoBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombrealumnoBuscar.TextChanged += new System.EventHandler(this.TxtNombrealumnoBuscar_TextChanged);
            this.txtNombrealumnoBuscar.Enter += new System.EventHandler(this.TxtNombrealumnoBuscar_Enter);
            this.txtNombrealumnoBuscar.Leave += new System.EventHandler(this.TxtNombrealumnoBuscar_Leave);
            // 
            // btnCancelarBuscarAlu
            // 
            this.btnCancelarBuscarAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarBuscarAlu.Location = new System.Drawing.Point(665, 337);
            this.btnCancelarBuscarAlu.Name = "btnCancelarBuscarAlu";
            this.btnCancelarBuscarAlu.Size = new System.Drawing.Size(126, 33);
            this.btnCancelarBuscarAlu.TabIndex = 94;
            this.btnCancelarBuscarAlu.Text = "Cancelar";
            this.btnCancelarBuscarAlu.UseVisualStyleBackColor = true;
            this.btnCancelarBuscarAlu.Click += new System.EventHandler(this.BtnCancelarBuscarAlu_Click);
            // 
            // BuscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(848, 397);
            this.Controls.Add(this.btnCancelarBuscarAlu);
            this.Controls.Add(this.txtNombrealumnoBuscar);
            this.Controls.Add(this.txtCIalumnoBuscar);
            this.Controls.Add(this.dbgListaAlumnosBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarAlumno";
            this.Load += new System.EventHandler(this.BuscarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgListaAlumnosBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCIalumnoBuscar;
        public System.Windows.Forms.DataGridView dbgListaAlumnosBuscar;
        private System.Windows.Forms.TextBox txtNombrealumnoBuscar;
        private System.Windows.Forms.Button btnCancelarBuscarAlu;
    }
}