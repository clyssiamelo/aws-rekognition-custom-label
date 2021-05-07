
namespace RekognitionCustomLabels
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RtxtbRetorno = new System.Windows.Forms.RichTextBox();
            this.OfdImagem = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnCarregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PBoxImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RtxtbRetorno
            // 
            this.RtxtbRetorno.Dock = System.Windows.Forms.DockStyle.Left;
            this.RtxtbRetorno.Location = new System.Drawing.Point(0, 0);
            this.RtxtbRetorno.Name = "RtxtbRetorno";
            this.RtxtbRetorno.ReadOnly = true;
            this.RtxtbRetorno.Size = new System.Drawing.Size(256, 779);
            this.RtxtbRetorno.TabIndex = 3;
            this.RtxtbRetorno.Text = "";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(256, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 779);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnConsultar);
            this.panel3.Controls.Add(this.BtnCarregar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 723);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 56);
            this.panel3.TabIndex = 1;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConsultar.Enabled = false;
            this.BtnConsultar.Location = new System.Drawing.Point(238, 3);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(236, 53);
            this.BtnConsultar.TabIndex = 9;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCarregar.Location = new System.Drawing.Point(480, 3);
            this.BtnCarregar.Name = "BtnCarregar";
            this.BtnCarregar.Size = new System.Drawing.Size(238, 53);
            this.BtnCarregar.TabIndex = 6;
            this.BtnCarregar.Text = "Carregar";
            this.BtnCarregar.UseVisualStyleBackColor = true;
            this.BtnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.PBoxImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 779);
            this.panel2.TabIndex = 0;
            // 
            // PBoxImage
            // 
            this.PBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBoxImage.Location = new System.Drawing.Point(0, 0);
            this.PBoxImage.Name = "PBoxImage";
            this.PBoxImage.Size = new System.Drawing.Size(1014, 779);
            this.PBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PBoxImage.TabIndex = 4;
            this.PBoxImage.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 779);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RtxtbRetorno);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Labels Detect";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox RtxtbRetorno;
        private System.Windows.Forms.OpenFileDialog OfdImagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnCarregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PBoxImage;
    }
}

