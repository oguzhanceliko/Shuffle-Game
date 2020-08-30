namespace Shuffle
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cikis_btn = new System.Windows.Forms.Button();
            this.Kullaniciadi_lbl = new System.Windows.Forms.Label();
            this.Kayıtol_btn = new System.Windows.Forms.Button();
            this.Oyna_btn = new System.Windows.Forms.Button();
            this.Sifre_lbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(406, 210);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Cikis_btn
            // 
            this.Cikis_btn.BackColor = System.Drawing.Color.Silver;
            this.Cikis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cikis_btn.Location = new System.Drawing.Point(620, 363);
            this.Cikis_btn.Name = "Cikis_btn";
            this.Cikis_btn.Size = new System.Drawing.Size(130, 50);
            this.Cikis_btn.TabIndex = 26;
            this.Cikis_btn.Text = "Çıkış";
            this.Cikis_btn.UseVisualStyleBackColor = false;
            this.Cikis_btn.Click += new System.EventHandler(this.Cikis_btn_Click);
            // 
            // Kullaniciadi_lbl
            // 
            this.Kullaniciadi_lbl.AutoSize = true;
            this.Kullaniciadi_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Kullaniciadi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullaniciadi_lbl.Location = new System.Drawing.Point(218, 210);
            this.Kullaniciadi_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kullaniciadi_lbl.Name = "Kullaniciadi_lbl";
            this.Kullaniciadi_lbl.Size = new System.Drawing.Size(150, 25);
            this.Kullaniciadi_lbl.TabIndex = 20;
            this.Kullaniciadi_lbl.Text = "Kullanıcı Adı:";
            this.Kullaniciadi_lbl.Click += new System.EventHandler(this.Kullaniciadi_lbl_Click);
            // 
            // Kayıtol_btn
            // 
            this.Kayıtol_btn.BackColor = System.Drawing.Color.Silver;
            this.Kayıtol_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayıtol_btn.Location = new System.Drawing.Point(264, 307);
            this.Kayıtol_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kayıtol_btn.Name = "Kayıtol_btn";
            this.Kayıtol_btn.Size = new System.Drawing.Size(111, 46);
            this.Kayıtol_btn.TabIndex = 24;
            this.Kayıtol_btn.Text = "Kayıt ol";
            this.Kayıtol_btn.UseVisualStyleBackColor = false;
            this.Kayıtol_btn.Click += new System.EventHandler(this.Kayıtol_btn_Click);
            // 
            // Oyna_btn
            // 
            this.Oyna_btn.BackColor = System.Drawing.Color.Silver;
            this.Oyna_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Oyna_btn.Location = new System.Drawing.Point(406, 307);
            this.Oyna_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Oyna_btn.Name = "Oyna_btn";
            this.Oyna_btn.Size = new System.Drawing.Size(131, 46);
            this.Oyna_btn.TabIndex = 19;
            this.Oyna_btn.Text = "Oyna";
            this.Oyna_btn.UseVisualStyleBackColor = false;
            this.Oyna_btn.Click += new System.EventHandler(this.Oyna_btn_Click);
            // 
            // Sifre_lbl
            // 
            this.Sifre_lbl.AutoSize = true;
            this.Sifre_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Sifre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifre_lbl.Location = new System.Drawing.Point(299, 249);
            this.Sifre_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sifre_lbl.Name = "Sifre_lbl";
            this.Sifre_lbl.Size = new System.Drawing.Size(68, 25);
            this.Sifre_lbl.TabIndex = 22;
            this.Sifre_lbl.Text = "Şifre:";
            this.Sifre_lbl.Click += new System.EventHandler(this.Sifre_lbl_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(406, 249);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 23;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 463);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cikis_btn);
            this.Controls.Add(this.Kullaniciadi_lbl);
            this.Controls.Add(this.Kayıtol_btn);
            this.Controls.Add(this.Oyna_btn);
            this.Controls.Add(this.Sifre_lbl);
            this.Controls.Add(this.textBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Cikis_btn;
        private System.Windows.Forms.Label Kullaniciadi_lbl;
        private System.Windows.Forms.Button Kayıtol_btn;
        private System.Windows.Forms.Button Oyna_btn;
        private System.Windows.Forms.Label Sifre_lbl;
        private System.Windows.Forms.TextBox textBox2;
    }
}