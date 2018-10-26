namespace Test
{
    partial class FrmLector
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
            this.rtbPagina = new System.Windows.Forms.RichTextBox();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tspAvance = new System.Windows.Forms.ToolStripProgressBar();
            this.tssPaginas = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbPagina
            // 
            this.rtbPagina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPagina.Location = new System.Drawing.Point(0, 46);
            this.rtbPagina.Name = "rtbPagina";
            this.rtbPagina.ReadOnly = true;
            this.rtbPagina.Size = new System.Drawing.Size(464, 482);
            this.rtbPagina.TabIndex = 0;
            this.rtbPagina.Text = "";
            // 
            // cmbLibros
            // 
            this.cmbLibros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(13, 13);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(439, 21);
            this.cmbLibros.TabIndex = 1;
            this.cmbLibros.SelectedIndexChanged += new System.EventHandler(this.cmbLibros_SelectedIndexChanged);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(377, 534);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 2;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(12, 534);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspAvance,
            this.tssPaginas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tspAvance
            // 
            this.tspAvance.Name = "tspAvance";
            this.tspAvance.Size = new System.Drawing.Size(100, 16);
            // 
            // tssPaginas
            // 
            this.tssPaginas.Name = "tssPaginas";
            this.tssPaginas.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmLector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 587);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.cmbLibros);
            this.Controls.Add(this.rtbPagina);
            this.Name = "FrmLector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lector";
            this.Load += new System.EventHandler(this.FrmLector_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPagina;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tspAvance;
        private System.Windows.Forms.ToolStripStatusLabel tssPaginas;
    }
}

