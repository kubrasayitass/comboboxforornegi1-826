namespace combobox_for_örneği1_826
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
            this.cmbCiftSayilar = new System.Windows.Forms.ComboBox();
            this.lbSayılar = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCiftSayilar
            // 
            this.cmbCiftSayilar.AllowDrop = true;
            this.cmbCiftSayilar.FormattingEnabled = true;
            this.cmbCiftSayilar.Location = new System.Drawing.Point(28, 269);
            this.cmbCiftSayilar.Name = "cmbCiftSayilar";
            this.cmbCiftSayilar.Size = new System.Drawing.Size(121, 21);
            this.cmbCiftSayilar.TabIndex = 0;
            // 
            // lbSayılar
            // 
            this.lbSayılar.FormattingEnabled = true;
            this.lbSayılar.Location = new System.Drawing.Point(28, 32);
            this.lbSayılar.Name = "lbSayılar";
            this.lbSayılar.Size = new System.Drawing.Size(120, 212);
            this.lbSayılar.TabIndex = 1;
            this.lbSayılar.SelectedIndexChanged += new System.EventHandler(this.lbSayılar_SelectedIndexChanged);
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(28, 313);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(120, 54);
            this.btnAktar.TabIndex = 2;
            this.btnAktar.Text = "çift sayıları aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lbSayılar);
            this.Controls.Add(this.cmbCiftSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCiftSayilar;
        private System.Windows.Forms.ListBox lbSayılar;
        private System.Windows.Forms.Button btnAktar;
    }
}

