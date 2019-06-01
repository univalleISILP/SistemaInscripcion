namespace SistemaInscripcion
{
    partial class PlataformaUser
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
            this.txtEdadAlu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAñoCursoAlu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveAlumno = new System.Windows.Forms.Button();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.radioVaron = new System.Windows.Forms.RadioButton();
            this.txtGradoAlu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datosGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidosDoc = new System.Windows.Forms.TextBox();
            this.txtApellAlu = new System.Windows.Forms.Label();
            this.txtNombreAlu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCIAlu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateAlu = new System.Windows.Forms.Button();
            this.DeleteAlu = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(247, 672);
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
            this.panelProductos.Controls.Add(this.txtEdadAlu);
            this.panelProductos.Controls.Add(this.label6);
            this.panelProductos.Controls.Add(this.txtAñoCursoAlu);
            this.panelProductos.Controls.Add(this.label9);
            this.panelProductos.Controls.Add(this.btnSaveAlumno);
            this.panelProductos.Controls.Add(this.radioMujer);
            this.panelProductos.Controls.Add(this.radioVaron);
            this.panelProductos.Controls.Add(this.txtGradoAlu);
            this.panelProductos.Controls.Add(this.label8);
            this.panelProductos.Controls.Add(this.label5);
            this.panelProductos.Controls.Add(this.datosGridView);
            this.panelProductos.Controls.Add(this.label4);
            this.panelProductos.Controls.Add(this.txtApellidosDoc);
            this.panelProductos.Controls.Add(this.txtApellAlu);
            this.panelProductos.Controls.Add(this.txtNombreAlu);
            this.panelProductos.Controls.Add(this.label2);
            this.panelProductos.Controls.Add(this.txtCIAlu);
            this.panelProductos.Controls.Add(this.label1);
            this.panelProductos.Controls.Add(this.UpdateAlu);
            this.panelProductos.Controls.Add(this.DeleteAlu);
            this.panelProductos.Location = new System.Drawing.Point(268, 35);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(1447, 581);
            this.panelProductos.TabIndex = 40;
            // 
            // txtEdadAlu
            // 
            this.txtEdadAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadAlu.Location = new System.Drawing.Point(1065, 219);
            this.txtEdadAlu.Multiline = true;
            this.txtEdadAlu.Name = "txtEdadAlu";
            this.txtEdadAlu.Size = new System.Drawing.Size(326, 31);
            this.txtEdadAlu.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(874, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 29);
            this.label6.TabIndex = 87;
            this.label6.Text = "Edad";
            // 
            // txtAñoCursoAlu
            // 
            this.txtAñoCursoAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAñoCursoAlu.Location = new System.Drawing.Point(1065, 386);
            this.txtAñoCursoAlu.Multiline = true;
            this.txtAñoCursoAlu.Name = "txtAñoCursoAlu";
            this.txtAñoCursoAlu.Size = new System.Drawing.Size(326, 31);
            this.txtAñoCursoAlu.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(874, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 29);
            this.label9.TabIndex = 85;
            this.label9.Text = "Año Curso";
            // 
            // btnSaveAlumno
            // 
            this.btnSaveAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAlumno.Location = new System.Drawing.Point(1011, 486);
            this.btnSaveAlumno.Name = "btnSaveAlumno";
            this.btnSaveAlumno.Size = new System.Drawing.Size(393, 53);
            this.btnSaveAlumno.TabIndex = 73;
            this.btnSaveAlumno.Text = "save";
            this.btnSaveAlumno.UseVisualStyleBackColor = true;
            this.btnSaveAlumno.Click += new System.EventHandler(this.BtnSaveAlumno_Click);
            // 
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMujer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioMujer.Location = new System.Drawing.Point(1224, 273);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(99, 33);
            this.radioMujer.TabIndex = 83;
            this.radioMujer.TabStop = true;
            this.radioMujer.Text = "Mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            // 
            // radioVaron
            // 
            this.radioVaron.AutoSize = true;
            this.radioVaron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVaron.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioVaron.Location = new System.Drawing.Point(1103, 273);
            this.radioVaron.Name = "radioVaron";
            this.radioVaron.Size = new System.Drawing.Size(101, 33);
            this.radioVaron.TabIndex = 81;
            this.radioVaron.TabStop = true;
            this.radioVaron.Text = "Varon";
            this.radioVaron.UseVisualStyleBackColor = true;
            // 
            // txtGradoAlu
            // 
            this.txtGradoAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradoAlu.Location = new System.Drawing.Point(1065, 331);
            this.txtGradoAlu.Multiline = true;
            this.txtGradoAlu.Name = "txtGradoAlu";
            this.txtGradoAlu.Size = new System.Drawing.Size(326, 31);
            this.txtGradoAlu.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(874, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 29);
            this.label8.TabIndex = 77;
            this.label8.Text = "Grado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(760, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 74;
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
            this.datosGridView.Size = new System.Drawing.Size(813, 414);
            this.datosGridView.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(874, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 71;
            this.label4.Text = "Genero";
            // 
            // txtApellidosDoc
            // 
            this.txtApellidosDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosDoc.Location = new System.Drawing.Point(1065, 160);
            this.txtApellidosDoc.Multiline = true;
            this.txtApellidosDoc.Name = "txtApellidosDoc";
            this.txtApellidosDoc.Size = new System.Drawing.Size(326, 31);
            this.txtApellidosDoc.TabIndex = 70;
            // 
            // txtApellAlu
            // 
            this.txtApellAlu.AutoSize = true;
            this.txtApellAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellAlu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtApellAlu.Location = new System.Drawing.Point(874, 160);
            this.txtApellAlu.Name = "txtApellAlu";
            this.txtApellAlu.Size = new System.Drawing.Size(110, 29);
            this.txtApellAlu.TabIndex = 69;
            this.txtApellAlu.Text = "Apellido";
            // 
            // txtNombreAlu
            // 
            this.txtNombreAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlu.Location = new System.Drawing.Point(1065, 102);
            this.txtNombreAlu.Multiline = true;
            this.txtNombreAlu.Name = "txtNombreAlu";
            this.txtNombreAlu.Size = new System.Drawing.Size(326, 31);
            this.txtNombreAlu.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(874, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 67;
            this.label2.Text = "Nombre";
            // 
            // txtCIAlu
            // 
            this.txtCIAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIAlu.Location = new System.Drawing.Point(1065, 45);
            this.txtCIAlu.Multiline = true;
            this.txtCIAlu.Name = "txtCIAlu";
            this.txtCIAlu.Size = new System.Drawing.Size(326, 31);
            this.txtCIAlu.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(874, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 65;
            this.label1.Text = "CI Alumno";
            // 
            // UpdateAlu
            // 
            this.UpdateAlu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UpdateAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAlu.ForeColor = System.Drawing.Color.Black;
            this.UpdateAlu.Location = new System.Drawing.Point(142, 486);
            this.UpdateAlu.Name = "UpdateAlu";
            this.UpdateAlu.Size = new System.Drawing.Size(243, 53);
            this.UpdateAlu.TabIndex = 63;
            this.UpdateAlu.Text = "update";
            this.UpdateAlu.UseVisualStyleBackColor = false;
            this.UpdateAlu.Click += new System.EventHandler(this.UpdateAlu_Click);
            // 
            // DeleteAlu
            // 
            this.DeleteAlu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAlu.ForeColor = System.Drawing.Color.Black;
            this.DeleteAlu.Location = new System.Drawing.Point(480, 486);
            this.DeleteAlu.Name = "DeleteAlu";
            this.DeleteAlu.Size = new System.Drawing.Size(251, 53);
            this.DeleteAlu.TabIndex = 62;
            this.DeleteAlu.Text = "delete";
            this.DeleteAlu.UseVisualStyleBackColor = false;
            this.DeleteAlu.Click += new System.EventHandler(this.DeleteAlu_Click);
            // 
            // PlataformaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1744, 672);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.panel1);
            this.Name = "PlataformaUser";
            this.Text = "PlataformaUser";
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
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.RadioButton radioVaron;
        private System.Windows.Forms.TextBox txtGradoAlu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView datosGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidosDoc;
        private System.Windows.Forms.Label txtApellAlu;
        private System.Windows.Forms.TextBox txtNombreAlu;
        private System.Windows.Forms.Button btnSaveAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCIAlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateAlu;
        private System.Windows.Forms.Button DeleteAlu;
        private System.Windows.Forms.TextBox txtAñoCursoAlu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEdadAlu;
    }
}