namespace SistemaInscripcion
{
    partial class PlataformaAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlataformaAlumno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.txtCIalumno = new System.Windows.Forms.TextBox();
            this.btnVerNotasAlu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btnCerrarSessionAlu = new System.Windows.Forms.Button();
            this.btnCambiarPassAlu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Grado = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.acurso = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.Label();
            this.panelNotas = new System.Windows.Forms.Panel();
            this.btnListarTodo = new System.Windows.Forms.Button();
            this.cbxMateriaAlu = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.datosAlumnoPlataformaAlumno = new System.Windows.Forms.DataGridView();
            this.panelCambiarPass = new System.Windows.Forms.Panel();
            this.txtCodCambiarPass = new System.Windows.Forms.TextBox();
            this.btnGuardarPass = new System.Windows.Forms.Button();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCambiarCod = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtContraseña1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlumnoPlataformaAlumno)).BeginInit();
            this.panelCambiarPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(85)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.txtCIalumno);
            this.panel1.Controls.Add(this.btnVerNotasAlu);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnCerrarSessionAlu);
            this.panel1.Controls.Add(this.btnCambiarPassAlu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 499);
            this.panel1.TabIndex = 3;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.Location = new System.Drawing.Point(0, 103);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(19, 48);
            this.sidePanel.TabIndex = 117;
            // 
            // txtCIalumno
            // 
            this.txtCIalumno.Location = new System.Drawing.Point(24, 13);
            this.txtCIalumno.Name = "txtCIalumno";
            this.txtCIalumno.Size = new System.Drawing.Size(180, 20);
            this.txtCIalumno.TabIndex = 116;
            this.txtCIalumno.Visible = false;
            // 
            // btnVerNotasAlu
            // 
            this.btnVerNotasAlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(85)))), ((int)(((byte)(124)))));
            this.btnVerNotasAlu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(85)))), ((int)(((byte)(124)))));
            this.btnVerNotasAlu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btnVerNotasAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerNotasAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerNotasAlu.ForeColor = System.Drawing.Color.Transparent;
            this.btnVerNotasAlu.Location = new System.Drawing.Point(2, 103);
            this.btnVerNotasAlu.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerNotasAlu.Name = "btnVerNotasAlu";
            this.btnVerNotasAlu.Size = new System.Drawing.Size(225, 48);
            this.btnVerNotasAlu.TabIndex = 115;
            this.btnVerNotasAlu.Text = "NOTAS";
            this.btnVerNotasAlu.UseVisualStyleBackColor = false;
            this.btnVerNotasAlu.Click += new System.EventHandler(this.BtnVerNotasAlu_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblTexto);
            this.panel4.Controls.Add(this.picture);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 425);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 74);
            this.panel4.TabIndex = 114;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(93, 27);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(0, 20);
            this.lblTexto.TabIndex = 114;
            // 
            // picture
            // 
            this.picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture.BackgroundImage")));
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture.Location = new System.Drawing.Point(24, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(59, 68);
            this.picture.TabIndex = 113;
            this.picture.TabStop = false;
            // 
            // btnCerrarSessionAlu
            // 
            this.btnCerrarSessionAlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(85)))), ((int)(((byte)(124)))));
            this.btnCerrarSessionAlu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(85)))), ((int)(((byte)(124)))));
            this.btnCerrarSessionAlu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btnCerrarSessionAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSessionAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSessionAlu.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarSessionAlu.Location = new System.Drawing.Point(2, 198);
            this.btnCerrarSessionAlu.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSessionAlu.Name = "btnCerrarSessionAlu";
            this.btnCerrarSessionAlu.Size = new System.Drawing.Size(225, 48);
            this.btnCerrarSessionAlu.TabIndex = 5;
            this.btnCerrarSessionAlu.Text = "CERRAR SESSION";
            this.btnCerrarSessionAlu.UseVisualStyleBackColor = false;
            this.btnCerrarSessionAlu.Click += new System.EventHandler(this.BtnCerrarSessionAlu_Click);
            // 
            // btnCambiarPassAlu
            // 
            this.btnCambiarPassAlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(85)))), ((int)(((byte)(124)))));
            this.btnCambiarPassAlu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(85)))), ((int)(((byte)(124)))));
            this.btnCambiarPassAlu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.btnCambiarPassAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarPassAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarPassAlu.ForeColor = System.Drawing.Color.Transparent;
            this.btnCambiarPassAlu.Location = new System.Drawing.Point(2, 150);
            this.btnCambiarPassAlu.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarPassAlu.Name = "btnCambiarPassAlu";
            this.btnCambiarPassAlu.Size = new System.Drawing.Size(225, 48);
            this.btnCambiarPassAlu.TabIndex = 4;
            this.btnCambiarPassAlu.Text = "PASSWORD";
            this.btnCambiarPassAlu.UseVisualStyleBackColor = false;
            this.btnCambiarPassAlu.Click += new System.EventHandler(this.BtnCambiarPassAlu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Grado);
            this.panel2.Controls.Add(this.Nombre);
            this.panel2.Controls.Add(this.a);
            this.panel2.Controls.Add(this.acurso);
            this.panel2.Controls.Add(this.n);
            this.panel2.Controls.Add(this.g);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(229, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 33);
            this.panel2.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(479, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 135;
            this.label1.Text = "Año Curso";
            // 
            // Grado
            // 
            this.Grado.AutoSize = true;
            this.Grado.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grado.ForeColor = System.Drawing.Color.Black;
            this.Grado.Location = new System.Drawing.Point(298, 5);
            this.Grado.Name = "Grado";
            this.Grado.Size = new System.Drawing.Size(67, 25);
            this.Grado.TabIndex = 134;
            this.Grado.Text = "Grado";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.Black;
            this.Nombre.Location = new System.Drawing.Point(29, 4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(79, 25);
            this.Nombre.TabIndex = 133;
            this.Nombre.Text = "Nombre";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.Black;
            this.a.Location = new System.Drawing.Point(201, 9);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(53, 19);
            this.a.TabIndex = 130;
            this.a.Text = "apell";
            // 
            // acurso
            // 
            this.acurso.AutoSize = true;
            this.acurso.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acurso.ForeColor = System.Drawing.Color.Black;
            this.acurso.Location = new System.Drawing.Point(577, 10);
            this.acurso.Name = "acurso";
            this.acurso.Size = new System.Drawing.Size(65, 19);
            this.acurso.TabIndex = 132;
            this.acurso.Text = "curso";
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.ForeColor = System.Drawing.Color.Black;
            this.n.Location = new System.Drawing.Point(106, 9);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(77, 19);
            this.n.TabIndex = 129;
            this.n.Text = "nombre";
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.ForeColor = System.Drawing.Color.Black;
            this.g.Location = new System.Drawing.Point(362, 10);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(68, 19);
            this.g.TabIndex = 131;
            this.g.Text = "grado";
            // 
            // panelNotas
            // 
            this.panelNotas.Controls.Add(this.btnListarTodo);
            this.panelNotas.Controls.Add(this.cbxMateriaAlu);
            this.panelNotas.Controls.Add(this.label26);
            this.panelNotas.Controls.Add(this.datosAlumnoPlataformaAlumno);
            this.panelNotas.Location = new System.Drawing.Point(263, 64);
            this.panelNotas.Margin = new System.Windows.Forms.Padding(2);
            this.panelNotas.Name = "panelNotas";
            this.panelNotas.Size = new System.Drawing.Size(592, 329);
            this.panelNotas.TabIndex = 111;
            this.panelNotas.Visible = false;
            // 
            // btnListarTodo
            // 
            this.btnListarTodo.BackColor = System.Drawing.Color.White;
            this.btnListarTodo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListarTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnListarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodo.ForeColor = System.Drawing.Color.Black;
            this.btnListarTodo.Location = new System.Drawing.Point(373, 14);
            this.btnListarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarTodo.Name = "btnListarTodo";
            this.btnListarTodo.Size = new System.Drawing.Size(167, 27);
            this.btnListarTodo.TabIndex = 98;
            this.btnListarTodo.Text = "Listar Todo";
            this.btnListarTodo.UseVisualStyleBackColor = false;
            this.btnListarTodo.Click += new System.EventHandler(this.BtnListarTodo_Click);
            // 
            // cbxMateriaAlu
            // 
            this.cbxMateriaAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMateriaAlu.FormattingEnabled = true;
            this.cbxMateriaAlu.Location = new System.Drawing.Point(99, 14);
            this.cbxMateriaAlu.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMateriaAlu.Name = "cbxMateriaAlu";
            this.cbxMateriaAlu.Size = new System.Drawing.Size(153, 24);
            this.cbxMateriaAlu.TabIndex = 84;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(26, 18);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 20);
            this.label26.TabIndex = 80;
            this.label26.Text = "Materia";
            // 
            // datosAlumnoPlataformaAlumno
            // 
            this.datosAlumnoPlataformaAlumno.AllowUserToDeleteRows = false;
            this.datosAlumnoPlataformaAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datosAlumnoPlataformaAlumno.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.datosAlumnoPlataformaAlumno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.datosAlumnoPlataformaAlumno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datosAlumnoPlataformaAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosAlumnoPlataformaAlumno.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.datosAlumnoPlataformaAlumno.Location = new System.Drawing.Point(26, 55);
            this.datosAlumnoPlataformaAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.datosAlumnoPlataformaAlumno.Name = "datosAlumnoPlataformaAlumno";
            this.datosAlumnoPlataformaAlumno.ReadOnly = true;
            this.datosAlumnoPlataformaAlumno.RowHeadersVisible = false;
            this.datosAlumnoPlataformaAlumno.RowHeadersWidth = 62;
            this.datosAlumnoPlataformaAlumno.RowTemplate.Height = 28;
            this.datosAlumnoPlataformaAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosAlumnoPlataformaAlumno.Size = new System.Drawing.Size(514, 256);
            this.datosAlumnoPlataformaAlumno.TabIndex = 64;
            // 
            // panelCambiarPass
            // 
            this.panelCambiarPass.BackColor = System.Drawing.Color.White;
            this.panelCambiarPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelCambiarPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCambiarPass.Controls.Add(this.txtCodCambiarPass);
            this.panelCambiarPass.Controls.Add(this.btnGuardarPass);
            this.panelCambiarPass.Controls.Add(this.txtContraseña2);
            this.panelCambiarPass.Controls.Add(this.label18);
            this.panelCambiarPass.Controls.Add(this.label17);
            this.panelCambiarPass.Controls.Add(this.txtCambiarCod);
            this.panelCambiarPass.Controls.Add(this.label16);
            this.panelCambiarPass.Controls.Add(this.txtContraseña1);
            this.panelCambiarPass.Location = new System.Drawing.Point(329, 134);
            this.panelCambiarPass.Name = "panelCambiarPass";
            this.panelCambiarPass.Size = new System.Drawing.Size(529, 262);
            this.panelCambiarPass.TabIndex = 112;
            this.panelCambiarPass.Visible = false;
            // 
            // txtCodCambiarPass
            // 
            this.txtCodCambiarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCambiarPass.Location = new System.Drawing.Point(232, 53);
            this.txtCodCambiarPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodCambiarPass.Multiline = true;
            this.txtCodCambiarPass.Name = "txtCodCambiarPass";
            this.txtCodCambiarPass.Size = new System.Drawing.Size(247, 22);
            this.txtCodCambiarPass.TabIndex = 97;
            // 
            // btnGuardarPass
            // 
            this.btnGuardarPass.BackColor = System.Drawing.Color.White;
            this.btnGuardarPass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPass.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarPass.Location = new System.Drawing.Point(162, 199);
            this.btnGuardarPass.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarPass.Name = "btnGuardarPass";
            this.btnGuardarPass.Size = new System.Drawing.Size(167, 34);
            this.btnGuardarPass.TabIndex = 80;
            this.btnGuardarPass.Text = "save";
            this.btnGuardarPass.UseVisualStyleBackColor = false;
            this.btnGuardarPass.Click += new System.EventHandler(this.BtnGuardarPass_Click);
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña2.Location = new System.Drawing.Point(232, 132);
            this.txtContraseña2.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña2.Multiline = true;
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '*';
            this.txtContraseña2.Size = new System.Drawing.Size(247, 22);
            this.txtContraseña2.TabIndex = 95;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(37, 134);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(173, 20);
            this.label18.TabIndex = 94;
            this.label18.Text = "Repita su  Password";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(37, 94);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 20);
            this.label17.TabIndex = 93;
            this.label17.Text = "Nuevo Password";
            // 
            // txtCambiarCod
            // 
            this.txtCambiarCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambiarCod.Location = new System.Drawing.Point(232, 19);
            this.txtCambiarCod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCambiarCod.Multiline = true;
            this.txtCambiarCod.Name = "txtCambiarCod";
            this.txtCambiarCod.Size = new System.Drawing.Size(247, 22);
            this.txtCambiarCod.TabIndex = 68;
            this.txtCambiarCod.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(37, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 20);
            this.label16.TabIndex = 67;
            this.label16.Text = "Ingrese su Codigo";
            // 
            // txtContraseña1
            // 
            this.txtContraseña1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña1.Location = new System.Drawing.Point(232, 92);
            this.txtContraseña1.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña1.Multiline = true;
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.PasswordChar = '*';
            this.txtContraseña1.Size = new System.Drawing.Size(247, 22);
            this.txtContraseña1.TabIndex = 92;
            // 
            // PlataformaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 499);
            this.Controls.Add(this.panelCambiarPass);
            this.Controls.Add(this.panelNotas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlataformaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlataformaAlumno";
            this.Load += new System.EventHandler(this.PlataformaAlumno_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlataformaAlumno_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelNotas.ResumeLayout(false);
            this.panelNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlumnoPlataformaAlumno)).EndInit();
            this.panelCambiarPass.ResumeLayout(false);
            this.panelCambiarPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSessionAlu;
        private System.Windows.Forms.Button btnCambiarPassAlu;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lblTexto;
        public System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnVerNotasAlu;
        public System.Windows.Forms.TextBox txtCIalumno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Grado;
        private System.Windows.Forms.Label Nombre;
        public System.Windows.Forms.Label a;
        public System.Windows.Forms.Label acurso;
        public System.Windows.Forms.Label n;
        public System.Windows.Forms.Label g;
        public System.Windows.Forms.Panel panelNotas;
        private System.Windows.Forms.ComboBox cbxMateriaAlu;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.DataGridView datosAlumnoPlataformaAlumno;
        private System.Windows.Forms.Panel panelCambiarPass;
        public System.Windows.Forms.TextBox txtCodCambiarPass;
        private System.Windows.Forms.Button btnGuardarPass;
        public System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtCambiarCod;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtContraseña1;
        private System.Windows.Forms.Button btnListarTodo;
        public System.Windows.Forms.Panel sidePanel;
    }
}