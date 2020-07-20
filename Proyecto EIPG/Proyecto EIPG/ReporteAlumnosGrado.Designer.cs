namespace Proyecto_EIPG
{
    partial class ReporteAlumnosGrado
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
            this.finalDataSet = new Proyecto_EIPG.finalDataSet();
            this.AlumnosPorGradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AlumnosPorGradoTableAdapter = new Proyecto_EIPG.finalDataSetTableAdapters.AlumnosPorGradoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosPorGradoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AlumnosPorGradoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_EIPG.ReporteAlumnosGrado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // finalDataSet
            // 
            this.finalDataSet.DataSetName = "finalDataSet";
            this.finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AlumnosPorGradoBindingSource
            // 
            this.AlumnosPorGradoBindingSource.DataMember = "AlumnosPorGrado";
            this.AlumnosPorGradoBindingSource.DataSource = this.finalDataSet;
            // 
            // AlumnosPorGradoTableAdapter
            // 
            this.AlumnosPorGradoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteAlumnosGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteAlumnosGrado";
            this.Text = "ReporteAlumnosGrado";
            this.Load += new System.EventHandler(this.ReporteAlumnosGrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosPorGradoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AlumnosPorGradoBindingSource;
        private finalDataSet finalDataSet;
        private finalDataSetTableAdapters.AlumnosPorGradoTableAdapter AlumnosPorGradoTableAdapter;
    }
}