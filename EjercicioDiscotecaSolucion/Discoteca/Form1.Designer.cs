namespace Discoteca
{
    partial class DiscotecaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DiscoDataGridView = new System.Windows.Forms.DataGridView();
            this.DiscoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DiscoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DiscoDataGridView
            // 
            this.DiscoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscoDataGridView.Location = new System.Drawing.Point(12, 294);
            this.DiscoDataGridView.Name = "DiscoDataGridView";
            this.DiscoDataGridView.Size = new System.Drawing.Size(644, 231);
            this.DiscoDataGridView.TabIndex = 0;
            this.DiscoDataGridView.SelectionChanged += new System.EventHandler(this.DiscoDataGridView_SelectionChanged);
            // 
            // DiscoPictureBox
            // 
            this.DiscoPictureBox.Location = new System.Drawing.Point(210, 12);
            this.DiscoPictureBox.Name = "DiscoPictureBox";
            this.DiscoPictureBox.Size = new System.Drawing.Size(266, 266);
            this.DiscoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiscoPictureBox.TabIndex = 1;
            this.DiscoPictureBox.TabStop = false;
            // 
            // DiscotecaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 540);
            this.Controls.Add(this.DiscoPictureBox);
            this.Controls.Add(this.DiscoDataGridView);
            this.Name = "DiscotecaForm";
            this.Text = "Discoteca";
            this.Load += new System.EventHandler(this.DiscotecaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiscoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DiscoDataGridView;
        private System.Windows.Forms.PictureBox DiscoPictureBox;
    }
}

