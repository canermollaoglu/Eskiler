namespace F4_Koleksiyonlar
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
            this.txtCompare = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnConcat = new System.Windows.Forms.Button();
            this.txtConcat = new System.Windows.Forms.TextBox();
            this.btnCopyTo = new System.Windows.Forms.Button();
            this.txtCopyTo = new System.Windows.Forms.TextBox();
            this.btnEndStart = new System.Windows.Forms.Button();
            this.txtEndStart = new System.Windows.Forms.TextBox();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtTrim = new System.Windows.Forms.TextBox();
            this.btnTrim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCompare
            // 
            this.txtCompare.Location = new System.Drawing.Point(12, 12);
            this.txtCompare.Name = "txtCompare";
            this.txtCompare.Size = new System.Drawing.Size(198, 20);
            this.txtCompare.TabIndex = 0;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(12, 38);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(198, 23);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "Compare To";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnConcat
            // 
            this.btnConcat.Location = new System.Drawing.Point(12, 108);
            this.btnConcat.Name = "btnConcat";
            this.btnConcat.Size = new System.Drawing.Size(198, 23);
            this.btnConcat.TabIndex = 2;
            this.btnConcat.Text = "Concat";
            this.btnConcat.UseVisualStyleBackColor = true;
            this.btnConcat.Click += new System.EventHandler(this.btnConcat_Click);
            // 
            // txtConcat
            // 
            this.txtConcat.Location = new System.Drawing.Point(12, 82);
            this.txtConcat.Name = "txtConcat";
            this.txtConcat.Size = new System.Drawing.Size(198, 20);
            this.txtConcat.TabIndex = 3;
            // 
            // btnCopyTo
            // 
            this.btnCopyTo.Location = new System.Drawing.Point(12, 172);
            this.btnCopyTo.Name = "btnCopyTo";
            this.btnCopyTo.Size = new System.Drawing.Size(198, 23);
            this.btnCopyTo.TabIndex = 4;
            this.btnCopyTo.Text = "Copy To";
            this.btnCopyTo.UseVisualStyleBackColor = true;
            this.btnCopyTo.Click += new System.EventHandler(this.btnCopyTo_Click);
            // 
            // txtCopyTo
            // 
            this.txtCopyTo.Location = new System.Drawing.Point(12, 146);
            this.txtCopyTo.Name = "txtCopyTo";
            this.txtCopyTo.Size = new System.Drawing.Size(198, 20);
            this.txtCopyTo.TabIndex = 5;
            // 
            // btnEndStart
            // 
            this.btnEndStart.Location = new System.Drawing.Point(12, 243);
            this.btnEndStart.Name = "btnEndStart";
            this.btnEndStart.Size = new System.Drawing.Size(198, 23);
            this.btnEndStart.TabIndex = 6;
            this.btnEndStart.Text = "Ends With - Starts With";
            this.btnEndStart.UseVisualStyleBackColor = true;
            this.btnEndStart.Click += new System.EventHandler(this.btnEndStart_Click);
            // 
            // txtEndStart
            // 
            this.txtEndStart.Location = new System.Drawing.Point(12, 217);
            this.txtEndStart.Name = "txtEndStart";
            this.txtEndStart.Size = new System.Drawing.Size(198, 20);
            this.txtEndStart.TabIndex = 7;
            // 
            // btnSubstring
            // 
            this.btnSubstring.Location = new System.Drawing.Point(12, 313);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(198, 23);
            this.btnSubstring.TabIndex = 8;
            this.btnSubstring.Text = "SubString";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(12, 287);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(198, 20);
            this.txtSub.TabIndex = 9;
            // 
            // txtTrim
            // 
            this.txtTrim.Location = new System.Drawing.Point(12, 355);
            this.txtTrim.Name = "txtTrim";
            this.txtTrim.Size = new System.Drawing.Size(198, 20);
            this.txtTrim.TabIndex = 10;
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(12, 381);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(198, 23);
            this.btnTrim.TabIndex = 11;
            this.btnTrim.Text = "Trim";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 437);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.txtTrim);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.txtEndStart);
            this.Controls.Add(this.btnEndStart);
            this.Controls.Add(this.txtCopyTo);
            this.Controls.Add(this.btnCopyTo);
            this.Controls.Add(this.txtConcat);
            this.Controls.Add(this.btnConcat);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtCompare);
            this.Name = "Form1";
            this.Text = "Hazır Fonksiyonlar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompare;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnConcat;
        private System.Windows.Forms.TextBox txtConcat;
        private System.Windows.Forms.Button btnCopyTo;
        private System.Windows.Forms.TextBox txtCopyTo;
        private System.Windows.Forms.Button btnEndStart;
        private System.Windows.Forms.TextBox txtEndStart;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtTrim;
        private System.Windows.Forms.Button btnTrim;
    }
}

