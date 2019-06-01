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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddMaterias = new System.Windows.Forms.Button();
            this.btnAddDocentes = new System.Windows.Forms.Button();
            this.btnAddAlumnos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(247, 746);
            this.panel1.TabIndex = 3;
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
            // PlataformaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1500, 746);
            this.Controls.Add(this.panel1);
            this.Name = "PlataformaAlumno";
            this.Text = "PlataformaAlumno";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddMaterias;
        private System.Windows.Forms.Button btnAddDocentes;
        private System.Windows.Forms.Button btnAddAlumnos;
    }
}