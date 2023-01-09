namespace Hastane_Projesi
{
    partial class deneme
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
            this.tc = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(182, 94);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(172, 20);
            this.tc.TabIndex = 0;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(182, 128);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(172, 20);
            this.sifre.TabIndex = 1;
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(393, 94);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(79, 69);
            this.kaydet.TabIndex = 2;
            this.kaydet.Text = "button1";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.tc);
            this.Name = "deneme";
            this.Text = "deneme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button kaydet;
    }
}