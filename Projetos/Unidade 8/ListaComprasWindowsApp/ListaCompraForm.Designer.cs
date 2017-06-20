namespace ListaComprasWindowsApp
{
    partial class ListaCompraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCompraForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovaListaCompra = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVizualizarListaCompras = new System.Windows.Forms.ToolStripButton();
            this.listListaCompras = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovaListaCompra,
            this.toolStripSeparator1,
            this.btnVizualizarListaCompras});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(490, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovaListaCompra
            // 
            this.btnNovaListaCompra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNovaListaCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaListaCompra.Image")));
            this.btnNovaListaCompra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovaListaCompra.Name = "btnNovaListaCompra";
            this.btnNovaListaCompra.Size = new System.Drawing.Size(166, 64);
            this.btnNovaListaCompra.Text = "Nova Lista de Compras";
            this.btnNovaListaCompra.Click += new System.EventHandler(this.btnNovaListaCompra_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 67);
            // 
            // btnVizualizarListaCompras
            // 
            this.btnVizualizarListaCompras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnVizualizarListaCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnVizualizarListaCompras.Image")));
            this.btnVizualizarListaCompras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVizualizarListaCompras.Name = "btnVizualizarListaCompras";
            this.btnVizualizarListaCompras.Size = new System.Drawing.Size(194, 64);
            this.btnVizualizarListaCompras.Text = "Visualizar Lista de Compras";
            this.btnVizualizarListaCompras.Click += new System.EventHandler(this.btnVizualizarListaCompras_Click);
            // 
            // listListaCompras
            // 
            this.listListaCompras.FormattingEnabled = true;
            this.listListaCompras.ItemHeight = 16;
            this.listListaCompras.Location = new System.Drawing.Point(0, 60);
            this.listListaCompras.Name = "listListaCompras";
            this.listListaCompras.Size = new System.Drawing.Size(490, 324);
            this.listListaCompras.TabIndex = 1;
            // 
            // ListaCompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 386);
            this.Controls.Add(this.listListaCompras);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaCompraForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listinha App";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovaListaCompra;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnVizualizarListaCompras;
        private System.Windows.Forms.ListBox listListaCompras;
    }
}