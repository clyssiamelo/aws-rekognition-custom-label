
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
            this.BtnCarregar = new System.Windows.Forms.Button();
            this.PBoxImage = new System.Windows.Forms.PictureBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.RtxtbRetorno = new System.Windows.Forms.RichTextBox();
            this.OfdImagem = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.Location = new System.Drawing.Point(363, 155);
            this.BtnCarregar.Name = "BtnCarregar";
            this.BtnCarregar.Size = new System.Drawing.Size(75, 53);
            this.BtnCarregar.TabIndex = 0;
            this.BtnCarregar.Text = "Carregar";
            this.BtnCarregar.UseVisualStyleBackColor = true;
            this.BtnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // PBoxImage
            // 
            this.PBoxImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.PBoxImage.Location = new System.Drawing.Point(462, 0);
            this.PBoxImage.Name = "PBoxImage";
            this.PBoxImage.Size = new System.Drawing.Size(224, 450);
            this.PBoxImage.TabIndex = 1;
            this.PBoxImage.TabStop = false;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(363, 214);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // RtxtbRetorno
            // 
            this.RtxtbRetorno.Dock = System.Windows.Forms.DockStyle.Left;
            this.RtxtbRetorno.Location = new System.Drawing.Point(0, 0);
            this.RtxtbRetorno.Name = "RtxtbRetorno";
            this.RtxtbRetorno.Size = new System.Drawing.Size(334, 450);
            this.RtxtbRetorno.TabIndex = 3;
            this.RtxtbRetorno.Text = "";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.RtxtbRetorno);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.PBoxImage);
            this.Controls.Add(this.BtnCarregar);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Labels Detect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCarregar;
        private System.Windows.Forms.PictureBox PBoxImage;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.RichTextBox RtxtbRetorno;
        private System.Windows.Forms.OpenFileDialog OfdImagem;
    }
}

