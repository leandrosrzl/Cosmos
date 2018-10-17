namespace COSMOS
{
    partial class frmRelPedidos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelPedidos));
            this.rpvViewerPedidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsRelDataSet = new COSMOS.dtsRelDataSet();
            this.VENDASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ITENS_VENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VENDEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtsRelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_VENDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDEDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USUARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvViewerPedidos
            // 
            this.rpvViewerPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvViewerPedidos.DocumentMapWidth = 89;
            reportDataSource1.Name = "dtsRelDataSetVendas";
            reportDataSource1.Value = this.VENDASBindingSource;
            reportDataSource2.Name = "dtsRelDataSetItens_Venda";
            reportDataSource2.Value = this.ITENS_VENDABindingSource;
            reportDataSource3.Name = "dtsRelDataSetVendedores";
            reportDataSource3.Value = this.VENDEDORESBindingSource;
            reportDataSource4.Name = "dtsRelDataSetUsuarios";
            reportDataSource4.Value = this.USUARIOSBindingSource;
            this.rpvViewerPedidos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvViewerPedidos.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvViewerPedidos.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvViewerPedidos.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvViewerPedidos.LocalReport.ReportEmbeddedResource = "COSMOS.rRelPedidos.rdlc";
            this.rpvViewerPedidos.Location = new System.Drawing.Point(0, 0);
            this.rpvViewerPedidos.Name = "rpvViewerPedidos";
            this.rpvViewerPedidos.ServerReport.DisplayName = "Relatório de Pedidos";
            this.rpvViewerPedidos.ShowBackButton = false;
            this.rpvViewerPedidos.ShowContextMenu = false;
            this.rpvViewerPedidos.ShowCredentialPrompts = false;
            this.rpvViewerPedidos.ShowDocumentMapButton = false;
            this.rpvViewerPedidos.ShowFindControls = false;
            this.rpvViewerPedidos.ShowParameterPrompts = false;
            this.rpvViewerPedidos.ShowProgress = false;
            this.rpvViewerPedidos.ShowPromptAreaButton = false;
            this.rpvViewerPedidos.ShowRefreshButton = false;
            this.rpvViewerPedidos.ShowStopButton = false;
            this.rpvViewerPedidos.Size = new System.Drawing.Size(910, 692);
            this.rpvViewerPedidos.TabIndex = 0;
            // 
            // dtsRelDataSet
            // 
            this.dtsRelDataSet.DataSetName = "dtsRelDataSet";
            this.dtsRelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VENDASBindingSource
            // 
            this.VENDASBindingSource.DataMember = "VENDAS";
            this.VENDASBindingSource.DataSource = this.dtsRelDataSet;
            // 
            // ITENS_VENDABindingSource
            // 
            this.ITENS_VENDABindingSource.DataMember = "ITENS_VENDA";
            this.ITENS_VENDABindingSource.DataSource = this.dtsRelDataSet;
            // 
            // VENDEDORESBindingSource
            // 
            this.VENDEDORESBindingSource.DataMember = "VENDEDORES";
            this.VENDEDORESBindingSource.DataSource = this.dtsRelDataSet;
            // 
            // USUARIOSBindingSource
            // 
            this.USUARIOSBindingSource.DataMember = "USUARIOS";
            this.USUARIOSBindingSource.DataSource = this.dtsRelDataSet;
            // 
            // frmRelPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 692);
            this.Controls.Add(this.rpvViewerPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmRelPedidos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão de pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsRelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITENS_VENDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VENDEDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USUARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvViewerPedidos;
        private System.Windows.Forms.BindingSource VENDASBindingSource;
        private dtsRelDataSet dtsRelDataSet;
        private System.Windows.Forms.BindingSource ITENS_VENDABindingSource;
        private System.Windows.Forms.BindingSource VENDEDORESBindingSource;
        private System.Windows.Forms.BindingSource USUARIOSBindingSource;
    }
}