namespace Proyecto_EIPG
{
    partial class reporteriageneral
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ingresosfechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet = new Proyecto_EIPG.finalDataSet();
            this.engresosfechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ingresosfechaTableAdapter = new Proyecto_EIPG.finalDataSetTableAdapters.ingresosfechaTableAdapter();
            this.engresosfechaTableAdapter = new Proyecto_EIPG.finalDataSetTableAdapters.engresosfechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ingresosfechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engresosfechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ingresosfechaBindingSource
            // 
            this.ingresosfechaBindingSource.DataMember = "ingresosfecha";
            this.ingresosfechaBindingSource.DataSource = this.finalDataSet;
            // 
            // finalDataSet
            // 
            this.finalDataSet.DataSetName = "finalDataSet";
            this.finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // engresosfechaBindingSource
            // 
            this.engresosfechaBindingSource.DataMember = "engresosfecha";
            this.engresosfechaBindingSource.DataSource = this.finalDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ingresosfechaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.engresosfechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_EIPG.reportgeneral.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(736, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ingresosfechaTableAdapter
            // 
            this.ingresosfechaTableAdapter.ClearBeforeFill = true;
            // 
            // engresosfechaTableAdapter
            // 
            this.engresosfechaTableAdapter.ClearBeforeFill = true;
            // 
            // reporteriageneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "reporteriageneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporteriageneral";
            this.Load += new System.EventHandler(this.reporteriageneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ingresosfechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engresosfechaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ingresosfechaBindingSource;
        private finalDataSet finalDataSet;
        private System.Windows.Forms.BindingSource engresosfechaBindingSource;
        private finalDataSetTableAdapters.ingresosfechaTableAdapter ingresosfechaTableAdapter;
        private finalDataSetTableAdapters.engresosfechaTableAdapter engresosfechaTableAdapter;
    }
}