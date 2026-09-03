namespace CapaVista
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgbConsultaTabla = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbConsultaTabla)).BeginInit();
            this.SuspendLayout();
            //
            // dgbConsultaTabla
            //
            this.dgbConsultaTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbConsultaTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbConsultaTabla.Location = new System.Drawing.Point(12, 50);
            this.dgbConsultaTabla.Name = "dgbConsultaTabla";
            this.dgbConsultaTabla.RowTemplate.Height = 25;
            this.dgbConsultaTabla.Size = new System.Drawing.Size(660, 380);
            this.dgbConsultaTabla.TabIndex = 1;
            //
            // btnConsultar
            //
            this.btnConsultar.Location = new System.Drawing.Point(12, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 30);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar datos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            //
            // FormPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 442);
            this.Controls.Add(this.dgbConsultaTabla);
            this.Controls.Add(this.btnConsultar);
            this.Name = "FormPrincipal";
            this.Text = "Taller MVC - Tabla Curso";
            ((System.ComponentModel.ISupportInitialize)(this.dgbConsultaTabla)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgbConsultaTabla;
        private System.Windows.Forms.Button btnConsultar;
    }
}
