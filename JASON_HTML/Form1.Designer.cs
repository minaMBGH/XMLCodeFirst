namespace JASON_HTML
{
    partial class Form1
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
            this.btnVeriGoster = new System.Windows.Forms.Button();
            this.btnVeriaktar = new System.Windows.Forms.Button();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVeriGoster
            // 
            this.btnVeriGoster.Location = new System.Drawing.Point(24, 23);
            this.btnVeriGoster.Name = "btnVeriGoster";
            this.btnVeriGoster.Size = new System.Drawing.Size(106, 43);
            this.btnVeriGoster.TabIndex = 0;
            this.btnVeriGoster.Text = "Veri goster!";
            this.btnVeriGoster.UseVisualStyleBackColor = true;
            this.btnVeriGoster.Click += new System.EventHandler(this.btnVeriGoster_Click);
            // 
            // btnVeriaktar
            // 
            this.btnVeriaktar.Location = new System.Drawing.Point(149, 23);
            this.btnVeriaktar.Name = "btnVeriaktar";
            this.btnVeriaktar.Size = new System.Drawing.Size(126, 43);
            this.btnVeriaktar.TabIndex = 1;
            this.btnVeriaktar.Text = "Veri Aktar!";
            this.btnVeriaktar.UseVisualStyleBackColor = true;
            this.btnVeriaktar.Click += new System.EventHandler(this.btnVeriaktar_Click);
            // 
            // lstUrunler
            // 
            this.lstUrunler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(0, 107);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(287, 238);
            this.lstUrunler.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 345);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.btnVeriaktar);
            this.Controls.Add(this.btnVeriGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVeriGoster;
        private System.Windows.Forms.Button btnVeriaktar;
        private System.Windows.Forms.ListBox lstUrunler;
    }
}

