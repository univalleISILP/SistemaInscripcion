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
            this.cbxEspecialidadDoc = new System.Windows.Forms.ComboBox();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.radioVaron = new System.Windows.Forms.RadioButton();
            this.txtDirecDoc = new System.Windows.Forms.TextBox();
            this.txtTelefonoDoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datosGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidosDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreDoc = new System.Windows.Forms.TextBox();
            this.btnSaveDocentes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCIDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateDoc = new System.Windows.Forms.Button();
            this.DeleteDoc = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 487);
            this.panel1.TabIndex = 2;
            // 
            // btnAddMaterias
            // 
            this.btnAddMaterias.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddMaterias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAddMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddMaterias.ForeColor = System.Drawing.Color.Black;
            this.btnAddMaterias.Location = new System.Drawing.Point(20, 157);
            this.btnAddMaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMaterias.Name = "btnAddMaterias";
            this.btnAddMaterias.Size = new System.Drawing.Size(120, 36);
            this.btnAddMaterias.TabIndex = 5;
            this.btnAddMaterias.Text = "MATERIAS";
            this.btnAddMaterias.UseVisualStyleBackColor = false;
            // 
            // btnAddDocentes
            // 
            this.btnAddDocentes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddDocentes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddDocentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAddDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDocentes.ForeColor = System.Drawing.Color.Black;
            this.btnAddDocentes.Location = new System.Drawing.Point(20, 47);
            this.btnAddDocentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddDocentes.Name = "btnAddDocentes";
            this.btnAddDocentes.Size = new System.Drawing.Size(120, 36);
            this.btnAddDocentes.TabIndex = 3;
            this.btnAddDocentes.Text = "DOCENTES";
            this.btnAddDocentes.UseVisualStyleBackColor = false;
            // 
            // btnAddAlumnos
            // 
            this.btnAddAlumnos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddAlumnos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAddAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAlumnos.ForeColor = System.Drawing.Color.Black;
            this.btnAddAlumnos.Location = new System.Drawing.Point(20, 103);
            this.btnAddAlumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddAlumnos.Name = "btnAddAlumnos";
            this.btnAddAlumnos.Size = new System.Drawing.Size(120, 36);
            this.btnAddAlumnos.TabIndex = 4;
            this.btnAddAlumnos.Text = "ALUMNOS";
            this.btnAddAlumnos.UseVisualStyleBackColor = false;
            this.btnAddAlumnos.Click += new System.EventHandler(this.BtnAddAlumnos_Click);
            // 
            // panelProductos
            // 
            this.panelProductos.Controls.Add(this.cbxEspecialidadDoc);
            this.panelProductos.Controls.Add(this.radioMujer);
            this.panelProductos.Controls.Add(this.radioVaron);
            this.panelProductos.Controls.Add(this.txtDirecDoc);
            this.panelProductos.Controls.Add(this.txtTelefonoDoc);
            this.panelProductos.Controls.Add(this.label8);
            this.panelProductos.Controls.Add(this.label7);
            this.panelProductos.Controls.Add(this.label6);
            this.panelProductos.Controls.Add(this.label5);
            this.panelProductos.Controls.Add(this.datosGridView);
            this.panelProductos.Controls.Add(this.panel2);
            this.panelProductos.Controls.Add(this.label4);
            this.panelProductos.Controls.Add(this.txtApellidosDoc);
            this.panelProductos.Controls.Add(this.label3);
            this.panelProductos.Controls.Add(this.txtNombreDoc);
            this.panelProductos.Controls.Add(this.btnSaveDocentes);
            this.panelProductos.Controls.Add(this.label2);
            this.panelProductos.Controls.Add(this.txtCIDoc);
            this.panelProductos.Controls.Add(this.label1);
            this.panelProductos.Controls.Add(this.UpdateDoc);
            this.panelProductos.Controls.Add(this.DeleteDoc);
            this.panelProductos.Location = new System.Drawing.Point(183, 27);
            this.panelProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(876, 378);
            this.panelProductos.TabIndex = 39;
            this.panelProductos.Visible = false;
            this.panelProductos.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelProductos_Paint);
            // 
            // cbxEspecialidadDoc
            // 
            this.cbxEspecialidadDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspecialidadDoc.FormattingEnabled = true;
            this.cbxEspecialidadDoc.Location = new System.Drawing.Point(634, 177);
            this.cbxEspecialidadDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEspecialidadDoc.Name = "cbxEspecialidadDoc";
            this.cbxEspecialidadDoc.Size = new System.Drawing.Size(219, 24);
            this.cbxEspecialidadDoc.TabIndex = 84;
            // 
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMujer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioMujer.Location = new System.Drawing.Point(739, 140);
            this.radioMujer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(66, 24);
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
            this.radioVaron.Location = new System.Drawing.Point(659, 140);
            this.radioVaron.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioVaron.Name = "radioVaron";
            this.radioVaron.Size = new System.Drawing.Size(70, 24);
            this.radioVaron.TabIndex = 81;
            this.radioVaron.TabStop = true;
            this.radioVaron.Text = "Varon";
            this.radioVaron.UseVisualStyleBackColor = true;
            // 
            // txtDirecDoc
            // 
            this.txtDirecDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirecDoc.Location = new System.Drawing.Point(634, 251);
            this.txtDirecDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDirecDoc.Multiline = true;
            this.txtDirecDoc.Name = "txtDirecDoc";
            this.txtDirecDoc.Size = new System.Drawing.Size(219, 22);
            this.txtDirecDoc.TabIndex = 80;
            // 
            // txtTelefonoDoc
            // 
            this.txtTelefonoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoDoc.Location = new System.Drawing.Point(634, 215);
            this.txtTelefonoDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefonoDoc.Multiline = true;
            this.txtTelefonoDoc.Name = "txtTelefonoDoc";
            this.txtTelefonoDoc.Size = new System.Drawing.Size(219, 22);
            this.txtTelefonoDoc.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(507, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(507, 216);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 76;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(507, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 75;
            this.label6.Text = "Especialidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(507, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 74;
            // 
            // datosGridView
            // 
            this.datosGridView.AllowUserToDeleteRows = false;
            this.datosGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datosGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosGridView.Location = new System.Drawing.Point(13, 21);
            this.datosGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datosGridView.Name = "datosGridView";
            this.datosGridView.ReadOnly = true;
            this.datosGridView.RowHeadersWidth = 62;
            this.datosGridView.RowTemplate.Height = 28;
            this.datosGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosGridView.Size = new System.Drawing.Size(469, 269);
            this.datosGridView.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(493, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 270);
            this.panel2.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(507, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Genero";
            // 
            // txtApellidosDoc
            // 
            this.txtApellidosDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosDoc.Location = new System.Drawing.Point(634, 107);
            this.txtApellidosDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellidosDoc.Multiline = true;
            this.txtApellidosDoc.Name = "txtApellidosDoc";
            this.txtApellidosDoc.Size = new System.Drawing.Size(219, 22);
            this.txtApellidosDoc.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(507, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Apellido";
            // 
            // txtNombreDoc
            // 
            this.txtNombreDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDoc.Location = new System.Drawing.Point(634, 69);
            this.txtNombreDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreDoc.Multiline = true;
            this.txtNombreDoc.Name = "txtNombreDoc";
            this.txtNombreDoc.Size = new System.Drawing.Size(219, 22);
            this.txtNombreDoc.TabIndex = 68;
            // 
            // btnSaveDocentes
            // 
            this.btnSaveDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDocentes.Location = new System.Drawing.Point(575, 307);
            this.btnSaveDocentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveDocentes.Name = "btnSaveDocentes";
            this.btnSaveDocentes.Size = new System.Drawing.Size(262, 34);
            this.btnSaveDocentes.TabIndex = 73;
            this.btnSaveDocentes.Text = "save";
            this.btnSaveDocentes.UseVisualStyleBackColor = true;
            this.btnSaveDocentes.Click += new System.EventHandler(this.BtnSaveDocentes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(507, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Nombre";
            // 
            // txtCIDoc
            // 
            this.txtCIDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIDoc.Location = new System.Drawing.Point(634, 32);
            this.txtCIDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCIDoc.Multiline = true;
            this.txtCIDoc.Name = "txtCIDoc";
            this.txtCIDoc.Size = new System.Drawing.Size(219, 22);
            this.txtCIDoc.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(507, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "CI";
            // 
            // UpdateDoc
            // 
            this.UpdateDoc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UpdateDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDoc.ForeColor = System.Drawing.Color.Black;
            this.UpdateDoc.Location = new System.Drawing.Point(55, 317);
            this.UpdateDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateDoc.Name = "UpdateDoc";
            this.UpdateDoc.Size = new System.Drawing.Size(162, 34);
            this.UpdateDoc.TabIndex = 63;
            this.UpdateDoc.Text = "update";
            this.UpdateDoc.UseVisualStyleBackColor = false;
            this.UpdateDoc.Click += new System.EventHandler(this.UpdateAdmin_Click);
            // 
            // DeleteDoc
            // 
            this.DeleteDoc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteDoc.ForeColor = System.Drawing.Color.Black;
            this.DeleteDoc.Location = new System.Drawing.Point(239, 317);
            this.DeleteDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteDoc.Name = "DeleteDoc";
            this.DeleteDoc.Size = new System.Drawing.Size(167, 34);
            this.DeleteDoc.TabIndex = 62;
            this.DeleteDoc.Text = "delete";
            this.DeleteDoc.UseVisualStyleBackColor = false;
            this.DeleteDoc.Click += new System.EventHandler(this.DeleteAdmin_Click);
            // 
            // PlataformaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1052, 487);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidosDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreDoc;
        private System.Windows.Forms.Button btnSaveDocentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCIDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateDoc;
        private System.Windows.Forms.Button DeleteDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonoDoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDirecDoc;
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.RadioButton radioVaron;
        private System.Windows.Forms.ComboBox cbxEspecialidadDoc;
    }
}