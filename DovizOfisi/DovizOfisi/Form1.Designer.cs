namespace DovizOfisi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Labell = new System.Windows.Forms.Label();
            this.labeli = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDolarAlis = new System.Windows.Forms.Label();
            this.LblDolarSatis = new System.Windows.Forms.Label();
            this.LblEuroAlis = new System.Windows.Forms.Label();
            this.LblEuroSatis = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSatisTutar = new System.Windows.Forms.Button();
            this.BtnAlisTutar = new System.Windows.Forms.Button();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.TxtKur = new System.Windows.Forms.TextBox();
            this.BtnDolarAl = new System.Windows.Forms.Button();
            this.BtnDolarSat = new System.Windows.Forms.Button();
            this.BtnEuroAl = new System.Windows.Forms.Button();
            this.BtnEuroSat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış : ";
            // 
            // Labell
            // 
            this.Labell.AutoSize = true;
            this.Labell.Location = new System.Drawing.Point(23, 62);
            this.Labell.Name = "Labell";
            this.Labell.Size = new System.Drawing.Size(97, 18);
            this.Labell.TabIndex = 1;
            this.Labell.Text = "Dolar Satış : ";
            // 
            // labeli
            // 
            this.labeli.AutoSize = true;
            this.labeli.Location = new System.Drawing.Point(39, 103);
            this.labeli.Name = "labeli";
            this.labeli.Size = new System.Drawing.Size(81, 18);
            this.labeli.TabIndex = 2;
            this.labeli.Text = "Euro Alış :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Euro Satış :";
            // 
            // LblDolarAlis
            // 
            this.LblDolarAlis.AutoSize = true;
            this.LblDolarAlis.Location = new System.Drawing.Point(126, 28);
            this.LblDolarAlis.Name = "LblDolarAlis";
            this.LblDolarAlis.Size = new System.Drawing.Size(18, 18);
            this.LblDolarAlis.TabIndex = 4;
            this.LblDolarAlis.Text = "0";
//            this.LblDolarAlis.Click += new System.EventHandler(this.LblDolarAlis_Click);
            // 
            // LblDolarSatis
            // 
            this.LblDolarSatis.AutoSize = true;
            this.LblDolarSatis.Location = new System.Drawing.Point(126, 62);
            this.LblDolarSatis.Name = "LblDolarSatis";
            this.LblDolarSatis.Size = new System.Drawing.Size(18, 18);
            this.LblDolarSatis.TabIndex = 5;
            this.LblDolarSatis.Text = "0";
            // 
            // LblEuroAlis
            // 
            this.LblEuroAlis.AutoSize = true;
            this.LblEuroAlis.Location = new System.Drawing.Point(126, 103);
            this.LblEuroAlis.Name = "LblEuroAlis";
            this.LblEuroAlis.Size = new System.Drawing.Size(18, 18);
            this.LblEuroAlis.TabIndex = 6;
            this.LblEuroAlis.Text = "0";
            // 
            // LblEuroSatis
            // 
            this.LblEuroSatis.AutoSize = true;
            this.LblEuroSatis.Location = new System.Drawing.Point(126, 137);
            this.LblEuroSatis.Name = "LblEuroSatis";
            this.LblEuroSatis.Size = new System.Drawing.Size(18, 18);
            this.LblEuroSatis.TabIndex = 7;
            this.LblEuroSatis.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kur :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Miktar :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tutar :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Kalan :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSatisTutar);
            this.groupBox1.Controls.Add(this.BtnAlisTutar);
            this.groupBox1.Controls.Add(this.TxtKalan);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.TxtMiktar);
            this.groupBox1.Controls.Add(this.TxtKur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(26, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 217);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // BtnSatisTutar
            // 
            this.BtnSatisTutar.Location = new System.Drawing.Point(195, 147);
            this.BtnSatisTutar.Name = "BtnSatisTutar";
            this.BtnSatisTutar.Size = new System.Drawing.Size(81, 54);
            this.BtnSatisTutar.TabIndex = 17;
            this.BtnSatisTutar.Text = "SATIŞ TUTARI";
            this.BtnSatisTutar.UseVisualStyleBackColor = true;
            this.BtnSatisTutar.Click += new System.EventHandler(this.BtnSatisTutar_Click);
            // 
            // BtnAlisTutar
            // 
            this.BtnAlisTutar.Location = new System.Drawing.Point(86, 147);
            this.BtnAlisTutar.Name = "BtnAlisTutar";
            this.BtnAlisTutar.Size = new System.Drawing.Size(80, 54);
            this.BtnAlisTutar.TabIndex = 16;
            this.BtnAlisTutar.Text = "ALIŞ TUTARI";
            this.BtnAlisTutar.UseVisualStyleBackColor = true;
            this.BtnAlisTutar.Click += new System.EventHandler(this.BtnAlisTutar_Click);
            // 
            // TxtKalan
            // 
            this.TxtKalan.Location = new System.Drawing.Point(86, 115);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(190, 26);
            this.TxtKalan.TabIndex = 15;
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(86, 83);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(190, 26);
            this.TxtTutar.TabIndex = 14;
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(86, 51);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(190, 26);
            this.TxtMiktar.TabIndex = 13;
            // 
            // TxtKur
            // 
            this.TxtKur.Location = new System.Drawing.Point(86, 19);
            this.TxtKur.Name = "TxtKur";
            this.TxtKur.Size = new System.Drawing.Size(190, 26);
            this.TxtKur.TabIndex = 12;
            this.TxtKur.TextChanged += new System.EventHandler(this.TxtKur_TextChanged);
            // 
            // BtnDolarAl
            // 
            this.BtnDolarAl.Location = new System.Drawing.Point(253, 28);
            this.BtnDolarAl.Name = "BtnDolarAl";
            this.BtnDolarAl.Size = new System.Drawing.Size(75, 23);
            this.BtnDolarAl.TabIndex = 13;
            this.BtnDolarAl.Text = "KUR";
            this.BtnDolarAl.UseVisualStyleBackColor = true;
            this.BtnDolarAl.Click += new System.EventHandler(this.BtnDolarAl_Click);
            // 
            // BtnDolarSat
            // 
            this.BtnDolarSat.Location = new System.Drawing.Point(253, 62);
            this.BtnDolarSat.Name = "BtnDolarSat";
            this.BtnDolarSat.Size = new System.Drawing.Size(75, 23);
            this.BtnDolarSat.TabIndex = 14;
            this.BtnDolarSat.Text = "KUR";
            this.BtnDolarSat.UseVisualStyleBackColor = true;
            this.BtnDolarSat.Click += new System.EventHandler(this.BtnDolarSat_Click);
            // 
            // BtnEuroAl
            // 
            this.BtnEuroAl.Location = new System.Drawing.Point(253, 101);
            this.BtnEuroAl.Name = "BtnEuroAl";
            this.BtnEuroAl.Size = new System.Drawing.Size(75, 23);
            this.BtnEuroAl.TabIndex = 15;
            this.BtnEuroAl.Text = "KUR";
            this.BtnEuroAl.UseVisualStyleBackColor = true;
            this.BtnEuroAl.Click += new System.EventHandler(this.BtnEuroAl_Click);
            // 
            // BtnEuroSat
            // 
            this.BtnEuroSat.Location = new System.Drawing.Point(253, 135);
            this.BtnEuroSat.Name = "BtnEuroSat";
            this.BtnEuroSat.Size = new System.Drawing.Size(75, 23);
            this.BtnEuroSat.TabIndex = 16;
            this.BtnEuroSat.Text = "KUR";
            this.BtnEuroSat.UseVisualStyleBackColor = true;
            this.BtnEuroSat.Click += new System.EventHandler(this.BtnEuroSat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 428);
            this.Controls.Add(this.BtnEuroSat);
            this.Controls.Add(this.BtnEuroAl);
            this.Controls.Add(this.BtnDolarSat);
            this.Controls.Add(this.BtnDolarAl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblEuroSatis);
            this.Controls.Add(this.LblEuroAlis);
            this.Controls.Add(this.LblDolarSatis);
            this.Controls.Add(this.LblDolarAlis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labeli);
            this.Controls.Add(this.Labell);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "DÖVİZ OFİSİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labell;
        private System.Windows.Forms.Label labeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDolarAlis;
        private System.Windows.Forms.Label LblDolarSatis;
        private System.Windows.Forms.Label LblEuroAlis;
        private System.Windows.Forms.Label LblEuroSatis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSatisTutar;
        private System.Windows.Forms.Button BtnAlisTutar;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.TextBox TxtKur;
        private System.Windows.Forms.Button BtnDolarAl;
        private System.Windows.Forms.Button BtnDolarSat;
        private System.Windows.Forms.Button BtnEuroAl;
        private System.Windows.Forms.Button BtnEuroSat;
    }
}

