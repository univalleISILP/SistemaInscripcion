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
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.datosGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.btnSaveProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 662);
            this.panel1.TabIndex = 2;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Teal;
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnReportes.ForeColor = System.Drawing.Color.Black;
            this.btnReportes.Location = new System.Drawing.Point(30, 242);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(180, 55);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Teal;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.Location = new System.Drawing.Point(30, 72);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(180, 55);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Teal;
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.Location = new System.Drawing.Point(30, 159);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(180, 55);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = false;
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
            this.panelProductos.Controls.Add(this.btnSaveProducto);
            this.panelProductos.Controls.Add(this.label2);
            this.panelProductos.Controls.Add(this.txtCodPro);
            this.panelProductos.Controls.Add(this.label1);
            this.panelProductos.Controls.Add(this.btnUpdate);
            this.panelProductos.Controls.Add(this.btnDelete);
            this.panelProductos.Location = new System.Drawing.Point(284, 72);
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
            // btnSaveProducto
            // 
            this.btnSaveProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProducto.Location = new System.Drawing.Point(725, 293);
            this.btnSaveProducto.Name = "btnSaveProducto";
            this.btnSaveProducto.Size = new System.Drawing.Size(393, 53);
            this.btnSaveProducto.TabIndex = 73;
            this.btnSaveProducto.Text = "save";
            this.btnSaveProducto.UseVisualStyleBackColor = true;
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
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(84, 362);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(243, 53);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(360, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(251, 53);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // PlataformaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1477, 662);
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
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnVentas;
        public System.Windows.Forms.Panel panelProductos;
        public System.Windows.Forms.DataGridView datosGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Button btnSaveProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}