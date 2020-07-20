namespace Proyecto_EIPG
{
    partial class ReporteriaAlumnos
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
            this.reportalumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet = new Proyecto_EIPG.finalDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportalumTableAdapter = new Proyecto_EIPG.finalDataSetTableAdapters.reportalumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportalumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportalumBindingSource
            // 
            this.reportalumBindingSource.DataMember = "reportalum";
            this.reportalumBindingSource.DataSource = this.finalDataSet;
            // 
            // finalDataSet
            // 
            this.finalDataSet.DataSetName = "finalDataSet";
            this.finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportalumBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_EIPG.reportalumno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(684, 432);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportalumTableAdapter
            // 
            this.reportalumTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteriaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteriaAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteriaAlumnos";
            this.Load += new System.EventHandler(this.ReporteriaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportalumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportalumBindingSource;
        private finalDataSet finalDataSet;
        private finalDataSetTableAdapters.reportalumTableAdapter reportalumTableAdapter;
    }
}