namespace F3_SettingKullanimi
{
    partial class Anaform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYeniSifre1 = new System.Windows.Forms.TextBox();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.txtYeniSifre2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYeniSifre2);
            this.groupBox1.Controls.Add(this.txtYeniSifre1);
            this.groupBox1.Controls.Add(this.txtEskiSifre);
            this.groupBox1.Controls.Add(this.btnDegistir);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sifrenizi Değiştirin";
            // 
            // txtYeniSifre1
            // 
            this.txtYeniSifre1.Location = new System.Drawing.Point(19, 47);
            this.txtYeniSifre1.Name = "txtYeniSifre1";
            this.txtYeniSifre1.PasswordChar = '*';
            this.txtYeniSifre1.Size = new System.Drawing.Size(224, 20);
            this.txtYeniSifre1.TabIndex = 4;
            this.txtYeniSifre1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(19, 19);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.PasswordChar = '*';
            this.txtEskiSifre.Size = new System.Drawing.Size(224, 20);
            this.txtEskiSifre.TabIndex = 3;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(168, 99);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.Text = "Değistir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // txtYeniSifre2
            // 
            this.txtYeniSifre2.Location = new System.Drawing.Point(19, 73);
            this.txtYeniSifre2.Name = "txtYeniSifre2";
            this.txtYeniSifre2.PasswordChar = '*';
            this.txtYeniSifre2.Size = new System.Drawing.Size(224, 20);
            this.txtYeniSifre2.TabIndex = 4;
            this.txtYeniSifre2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 153);
            this.Controls.Add(this.groupBox1);
            this.Name = "Anaform";
            this.Text = "Anaform";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYeniSifre1;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.TextBox txtYeniSifre2;
    }
}