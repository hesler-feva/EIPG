namespace Proyecto_EIPG
{
    partial class reporteriaegresos
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
            this.engresosfechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet = new Proyecto_EIPG.finalDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.engresosfechaTableAdapter = new Proyecto_EIPG.finalDataSetTableAdapters.engresosfechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.engresosfechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // engresosfechaBindingSource
            // 
            this.engresosfechaBindingSource.DataMember = "engresosfecha";
            this.engresosfechaBindingSource.DataSource = this.finalDataSet;
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
            reportDataSource1.Value = this.engresosfechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_EIPG.reportegre.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(541, 287);
            this.reportViewer1.TabIndex = 0;
            // 
            // engresosfechaTableAdapter
            // 
            this.engresosfechaTableAdapter.ClearBeforeFill = true;
            // 
            // reporteriaegresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 287);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "reporteriaegresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporteriaegresos";
            this.Load += new System.EventHandler(this.reporteriaegresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.engresosfechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource engresosfechaBindingSource;
        private finalDataSet finalDataSet;
        private finalDataSetTableAdapters.engresosfechaTableAdapter engresosfechaTableAdapter;
    }
}