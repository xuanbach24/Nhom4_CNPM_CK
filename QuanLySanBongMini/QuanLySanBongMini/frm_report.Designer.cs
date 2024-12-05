namespace QuanLySanBongMini
{
    partial class frm_report
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
            this.QLSanBongDaMiniDataSet = new QuanLySanBongMini.QLSanBongDaMiniDataSet();
            this.DatSanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatSanTableAdapter = new QuanLySanBongMini.QLSanBongDaMiniDataSetTableAdapters.DatSanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLSanBongDaMiniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatSanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DatSanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySanBongMini.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1654, 550);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLSanBongDaMiniDataSet
            // 
            this.QLSanBongDaMiniDataSet.DataSetName = "QLSanBongDaMiniDataSet";
            this.QLSanBongDaMiniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatSanBindingSource
            // 
            this.DatSanBindingSource.DataMember = "DatSan";
            this.DatSanBindingSource.DataSource = this.QLSanBongDaMiniDataSet;
            // 
            // DatSanTableAdapter
            // 
            this.DatSanTableAdapter.ClearBeforeFill = true;
            // 
            // frm_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 602);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_report";
            this.Text = "frm_report";
            this.Load += new System.EventHandler(this.frm_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLSanBongDaMiniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatSanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DatSanBindingSource;
        private QLSanBongDaMiniDataSet QLSanBongDaMiniDataSet;
        private QLSanBongDaMiniDataSetTableAdapters.DatSanTableAdapter DatSanTableAdapter;
    }
}