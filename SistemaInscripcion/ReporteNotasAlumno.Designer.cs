﻿namespace SistemaInscripcion
{
    partial class ReporteNotasAlumno
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MisDatosAlumnoNotas = new SistemaInscripcion.MisDatosAlumnoNotas();
            this.TablaNotasAlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TablaNotasAlumnoTableAdapter = new SistemaInscripcion.MisDatosAlumnoNotasTableAdapters.TablaNotasAlumnoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MisDatosAlumnoNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaNotasAlumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TablaNotasAlumnoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaInscripcion.ReporteAlumno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(553, 369);
            this.reportViewer1.TabIndex = 0;
            // 
            // MisDatosAlumnoNotas
            // 
            this.MisDatosAlumnoNotas.DataSetName = "MisDatosAlumnoNotas";
            this.MisDatosAlumnoNotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TablaNotasAlumnoBindingSource
            // 
            this.TablaNotasAlumnoBindingSource.DataMember = "TablaNotasAlumno";
            this.TablaNotasAlumnoBindingSource.DataSource = this.MisDatosAlumnoNotas;
            // 
            // TablaNotasAlumnoTableAdapter
            // 
            this.TablaNotasAlumnoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteNotasAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 369);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteNotasAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteNotasAlumno";
            this.Load += new System.EventHandler(this.ReporteNotasAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MisDatosAlumnoNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaNotasAlumnoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TablaNotasAlumnoBindingSource;
        private MisDatosAlumnoNotas MisDatosAlumnoNotas;
        private MisDatosAlumnoNotasTableAdapters.TablaNotasAlumnoTableAdapter TablaNotasAlumnoTableAdapter;
    }
}