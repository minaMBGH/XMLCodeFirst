namespace JASON_HTML1
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
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.btnVeriCek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstKisiler
            // 
            this.lstKisiler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 18;
            this.lstKisiler.Location = new System.Drawing.Point(0, 83);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(281, 256);
            this.lstKisiler.TabIndex = 0;
            // 
            // btnVeriCek
            // 
            this.btnVeriCek.Location = new System.Drawing.Point(12, 30);
            this.btnVeriCek.Name = "btnVeriCek";
            this.btnVeriCek.Size = new System.Drawing.Size(95, 29);
            this.btnVeriCek.TabIndex = 1;
            this.btnVeriCek.Text = "Verileri Çek!";
            this.btnVeriCek.UseVisualStyleBackColor = true;
            this.btnVeriCek.Click += new System.EventHandler(this.btnVeriCek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 339);
            this.Controls.Add(this.btnVeriCek);
            this.Controls.Add(this.lstKisiler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.Button btnVeriCek;
    }
}

