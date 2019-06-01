namespace SistemaInscripcion
{
    partial class PlataformaAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddMaterias = new System.Windows.Forms.Button();
            this.btnAddDocentes = new System.Windows.Forms.Button();
            this.btnAddAlumnos = new System.Windows.Forms.Button();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.datosGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.btnSaveDocentes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateAdmin = new System.Windows.Forms.Button();
            this.DeleteAdmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.btnAddMaterias);
            this.panel1.Controls.Add(this.btnAddDocentes);
            this.panel1.Controls.Add(this.btnAddAlumnos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 987);
            this.panel1.TabIndex = 2;
            // 
            // btnAddMaterias
            // 
            this.btnAddMaterias.BackColor = System.Drawing.Color.Teal;
            this.btnAddMaterias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAddMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddMaterias.ForeColor = System.Drawing.Color.Black;
            this.btnAddMaterias.Location = new System.Drawing.Point(30, 242);
            this.btnAddMaterias.Name = "btnAddMaterias";
            this.btnAddMaterias.Size = new System.Drawing.Size(180, 55);
            this.btnAddMaterias.TabIndex = 5;
            this.btnAddMaterias.Text = "MATERIAS";
            this.btnAddMaterias.UseVisualStyleBackColor = false;
            // 
            // btnAddDocentes
            // 
            this.btnAddDocentes.BackColor = System.Drawing.Color.Teal;
            this.btnAddDocentes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAddDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDocentes.ForeColor = System.Drawing.Color.Black;
            this.btnAddDocentes.Location = new System.Drawing.Point(30, 72);
            this.btnAddDocentes.Name = "btnAddDocentes";
            this.btnAddDocentes.Size = new System.Drawing.Size(180, 55);
            this.btnAddDocentes.TabIndex = 3;
            this.btnAddDocentes.Text = "DOCENTES";
            this.btnAddDocentes.UseVisualStyleBackColor = false;
            // 
            // btnAddAlumnos
            // 
            this.btnAddAlumnos.BackColor = System.Drawing.Color.Teal;
            this.btnAddAlumnos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAddAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAlumnos.ForeColor = System.Drawing.Color.Black;
            this.btnAddAlumnos.Location = new System.Drawing.Point(30, 159);
            this.btnAddAlumnos.Name = "btnAddAlumnos";
            this.btnAddAlumnos.Size = new System.Drawing.Size(180, 55);
            this.btnAddAlumnos.TabIndex = 4;
            this.btnAddAlumnos.Text = "ALUMNOS";
            this.btnAddAlumnos.UseVisualStyleBackColor = false;
            // 
            // panelProductos
            // 
            this.panelProductos.Controls.Add(this.datosGridView);
            this.panelProductos.Controls.Add(this.panel2);
            this.panelProductos.Controls.Add(this.txtPrecioProducto);
            this.panelProductos.Controls.Add(this.label4);
            this.panelProductos.Controls.Add(this.txtCantidadProducto);
            this.panelProductos.Controls.Add(this.label3);
            this.panelProductos.Controls.Add(this.txtNombreProducto);
            this.panelProductos.Controls.Add(this.btnSaveDocentes);
            this.panelProductos.Controls.Add(this.label2);
            this.panelProductos.Controls.Add(this.txtCodPro);
            this.panelProductos.Controls.Add(this.label1);
            this.panelProductos.Controls.Add(this.UpdateAdmin);
            this.panelProductos.Controls.Add(this.DeleteAdmin);
            this.panelProductos.Location = new System.Drawing.Point(291, 42);
            this.panelProductos.MaximumSize = new System.Drawing.Size(1151, 440);
            this.panelProductos.MinimumSize = new System.Drawing.Size(1151, 440);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(1151, 440);
            this.panelProductos.TabIndex = 39;
            this.panelProductos.Visible = false;
            // 
            // datosGridView
            // 
            this.datosGridView.AllowUserToDeleteRows = false;
            this.datosGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datosGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosGridView.Location = new System.Drawing.Point(19, 32);
            this.datosGridView.Name = "datosGridView";
            this.datosGridView.ReadOnly = true;
            this.datosGridView.RowHeadersWidth = 62;
            this.datosGridView.RowTemplate.Height = 28;
            this.datosGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosGridView.Size = new System.Drawing.Size(637, 311);
            this.datosGridView.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(681, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 311);
            this.panel2.TabIndex = 60;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProducto.Location = new System.Drawing.Point(911, 229);
            this.txtPrecioProducto.Multiline = true;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(207, 31);
            this.txtPrecioProducto.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(720, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 71;
            this.label4.Text = "Precio";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProducto.Location = new System.Drawing.Point(911, 164);
            this.txtCantidadProducto.Multiline = true;
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(207, 31);
            this.txtCantidadProducto.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(720, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 69;
            this.label3.Text = "Cantidad";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(911, 106);
            this.txtNombreProducto.Multiline = true;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(207, 31);
            this.txtNombreProducto.TabIndex = 68;
            // 
            // btnSaveDocentes
            // 
            this.btnSaveDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDocentes.Location = new System.Drawing.Point(725, 293);
            this.btnSaveDocentes.Name = "btnSaveDocentes";
            this.btnSaveDocentes.Size = new System.Drawing.Size(393, 53);
            this.btnSaveDocentes.TabIndex = 73;
            this.btnSaveDocentes.Text = "save";
            this.btnSaveDocentes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(720, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 67;
            this.label2.Text = "Producto";
            // 
            // txtCodPro
            // 
            this.txtCodPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPro.Location = new System.Drawing.Point(911, 49);
            this.txtCodPro.Multiline = true;
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(207, 31);
            this.txtCodPro.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(720, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 65;
            this.label1.Text = "CodProducto";
            // 
            // UpdateAdmin
            // 
            this.UpdateAdmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UpdateAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAdmin.ForeColor = System.Drawing.Color.Black;
            this.UpdateAdmin.Location = new System.Drawing.Point(84, 362);
            this.UpdateAdmin.Name = "UpdateAdmin";
            this.UpdateAdmin.Size = new System.Drawing.Size(243, 53);
            this.UpdateAdmin.TabIndex = 63;
            this.UpdateAdmin.Text = "update";
            this.UpdateAdmin.UseVisualStyleBackColor = false;
            // 
            // DeleteAdmin
            // 
            this.DeleteAdmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAdmin.ForeColor = System.Drawing.Color.Black;
            this.DeleteAdmin.Location = new System.Drawing.Point(360, 362);
            this.DeleteAdmin.Name = "DeleteAdmin";
            this.DeleteAdmin.Size = new System.Drawing.Size(251, 53);
            this.DeleteAdmin.TabIndex = 62;
            this.DeleteAdmin.Text = "delete";
            this.DeleteAdmin.UseVisualStyleBackColor = false;
            // 
            // PlataformaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1477, 987);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.panel1);
            this.Name = "PlataformaAdmin";
            this.Text = "PlataformaAdmin";
            this.panel1.ResumeLayout(false);
            this.panelProductos.ResumeLayout(false);
            this.panelProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddMaterias;
        private System.Windows.Forms.Button btnAddDocentes;
        private System.Windows.Forms.Button btnAddAlumnos;
        public System.Windows.Forms.Panel panelProductos;
        public System.Windows.Forms.DataGridView datosGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Button btnSaveDocentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateAdmin;
        private System.Windows.Forms.Button DeleteAdmin;
    }
}