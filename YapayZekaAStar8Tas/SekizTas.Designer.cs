namespace YapayZekaAStar8Tas
{
    partial class SekizTas
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
            this.button_Uret = new System.Windows.Forms.Button();
            this.checkBox_SonDurumRandomSecilsin = new System.Windows.Forms.CheckBox();
            this.label_ProblemCozulebilirMiKontrol = new System.Windows.Forms.Label();
            this.label_RandomUretilenSayilar_Baslangic_Durumu = new System.Windows.Forms.Label();
            this.label_RandomUretilenSayilar_Bitis_Durumu = new System.Windows.Forms.Label();
            this.textBox_Adimlar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_bilgilendirme_Ekrani = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1_numaraEkrani = new System.Windows.Forms.Panel();
            this.button_Coz = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button_Numaralar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_bilgilendirme_Ekrani.SuspendLayout();
            this.panel1_numaraEkrani.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Uret
            // 
            this.button_Uret.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Uret.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button_Uret.Location = new System.Drawing.Point(12, 15);
            this.button_Uret.Name = "button_Uret";
            this.button_Uret.Size = new System.Drawing.Size(323, 87);
            this.button_Uret.TabIndex = 2;
            this.button_Uret.Text = "Üret ve Çöz";
            this.button_Uret.UseVisualStyleBackColor = false;
            this.button_Uret.Click += new System.EventHandler(this.button_Uret_Click);
            // 
            // checkBox_SonDurumRandomSecilsin
            // 
            this.checkBox_SonDurumRandomSecilsin.Checked = true;
            this.checkBox_SonDurumRandomSecilsin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SonDurumRandomSecilsin.Location = new System.Drawing.Point(90, 108);
            this.checkBox_SonDurumRandomSecilsin.Name = "checkBox_SonDurumRandomSecilsin";
            this.checkBox_SonDurumRandomSecilsin.Size = new System.Drawing.Size(157, 39);
            this.checkBox_SonDurumRandomSecilsin.TabIndex = 3;
            this.checkBox_SonDurumRandomSecilsin.Text = "Hedef Durum Sabit Olsun";
            this.checkBox_SonDurumRandomSecilsin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_SonDurumRandomSecilsin.UseVisualStyleBackColor = true;
            this.checkBox_SonDurumRandomSecilsin.CheckStateChanged += new System.EventHandler(this.checkBox_SonDurumRandomSecilsin_CheckStateChanged);
            // 
            // label_ProblemCozulebilirMiKontrol
            // 
            this.label_ProblemCozulebilirMiKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ProblemCozulebilirMiKontrol.ForeColor = System.Drawing.Color.Crimson;
            this.label_ProblemCozulebilirMiKontrol.Location = new System.Drawing.Point(4, 3);
            this.label_ProblemCozulebilirMiKontrol.Name = "label_ProblemCozulebilirMiKontrol";
            this.label_ProblemCozulebilirMiKontrol.Size = new System.Drawing.Size(266, 39);
            this.label_ProblemCozulebilirMiKontrol.TabIndex = 4;
            this.label_ProblemCozulebilirMiKontrol.Text = "Hoşgeldiniz";
            this.label_ProblemCozulebilirMiKontrol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_RandomUretilenSayilar_Baslangic_Durumu
            // 
            this.label_RandomUretilenSayilar_Baslangic_Durumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_RandomUretilenSayilar_Baslangic_Durumu.Location = new System.Drawing.Point(6, 30);
            this.label_RandomUretilenSayilar_Baslangic_Durumu.Name = "label_RandomUretilenSayilar_Baslangic_Durumu";
            this.label_RandomUretilenSayilar_Baslangic_Durumu.Size = new System.Drawing.Size(140, 232);
            this.label_RandomUretilenSayilar_Baslangic_Durumu.TabIndex = 6;
            this.label_RandomUretilenSayilar_Baslangic_Durumu.Text = "Başlangıç";
            // 
            // label_RandomUretilenSayilar_Bitis_Durumu
            // 
            this.label_RandomUretilenSayilar_Bitis_Durumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_RandomUretilenSayilar_Bitis_Durumu.Location = new System.Drawing.Point(6, 30);
            this.label_RandomUretilenSayilar_Bitis_Durumu.Name = "label_RandomUretilenSayilar_Bitis_Durumu";
            this.label_RandomUretilenSayilar_Bitis_Durumu.Size = new System.Drawing.Size(140, 232);
            this.label_RandomUretilenSayilar_Bitis_Durumu.TabIndex = 6;
            this.label_RandomUretilenSayilar_Bitis_Durumu.Text = "Bitiş";
            // 
            // textBox_Adimlar
            // 
            this.textBox_Adimlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Adimlar.Location = new System.Drawing.Point(620, 54);
            this.textBox_Adimlar.Multiline = true;
            this.textBox_Adimlar.Name = "textBox_Adimlar";
            this.textBox_Adimlar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Adimlar.Size = new System.Drawing.Size(143, 361);
            this.textBox_Adimlar.TabIndex = 7;
            this.textBox_Adimlar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(620, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adımlar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_RandomUretilenSayilar_Baslangic_Durumu);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 265);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Başlangıç Durumu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_RandomUretilenSayilar_Bitis_Durumu);
            this.groupBox2.Location = new System.Drawing.Point(183, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 265);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hedef Durum";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_ProblemCozulebilirMiKontrol);
            this.panel2.Location = new System.Drawing.Point(341, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 42);
            this.panel2.TabIndex = 5;
            // 
            // panel_bilgilendirme_Ekrani
            // 
            this.panel_bilgilendirme_Ekrani.Controls.Add(this.label6);
            this.panel_bilgilendirme_Ekrani.Controls.Add(this.label5);
            this.panel_bilgilendirme_Ekrani.Controls.Add(this.label4);
            this.panel_bilgilendirme_Ekrani.Controls.Add(this.label7);
            this.panel_bilgilendirme_Ekrani.Controls.Add(this.label8);
            this.panel_bilgilendirme_Ekrani.Location = new System.Drawing.Point(345, 57);
            this.panel_bilgilendirme_Ekrani.Name = "panel_bilgilendirme_Ekrani";
            this.panel_bilgilendirme_Ekrani.Size = new System.Drawing.Size(269, 358);
            this.panel_bilgilendirme_Ekrani.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(6, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 74);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sağ Tarafta Yer Alan Adımlar Bölmesi İşlem Sonucunda Gerçekleştirilen Adımları Gö" +
    "stermektedir.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 74);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hedef Durum Sabit Olsun Tick\'ini Kaldırarak Kendiniz Bir Hedef Durum Belirtebilir" +
    "siniz.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Üret ve Çöz Butonu ile Direk 8 Taş Problemini Çözebilrisiniz";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(76, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 42);
            this.label7.TabIndex = 8;
            this.label7.Text = "********";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(76, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 42);
            this.label8.TabIndex = 8;
            this.label8.Text = "********";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1_numaraEkrani
            // 
            this.panel1_numaraEkrani.Controls.Add(this.button_Coz);
            this.panel1_numaraEkrani.Controls.Add(this.button10);
            this.panel1_numaraEkrani.Controls.Add(this.button11);
            this.panel1_numaraEkrani.Controls.Add(this.button12);
            this.panel1_numaraEkrani.Controls.Add(this.button13);
            this.panel1_numaraEkrani.Controls.Add(this.button14);
            this.panel1_numaraEkrani.Controls.Add(this.button15);
            this.panel1_numaraEkrani.Controls.Add(this.button16);
            this.panel1_numaraEkrani.Controls.Add(this.button17);
            this.panel1_numaraEkrani.Controls.Add(this.button18);
            this.panel1_numaraEkrani.Controls.Add(this.button19);
            this.panel1_numaraEkrani.Controls.Add(this.button_Numaralar);
            this.panel1_numaraEkrani.Location = new System.Drawing.Point(345, 57);
            this.panel1_numaraEkrani.Name = "panel1_numaraEkrani";
            this.panel1_numaraEkrani.Size = new System.Drawing.Size(269, 358);
            this.panel1_numaraEkrani.TabIndex = 5;
            // 
            // button_Coz
            // 
            this.button_Coz.Location = new System.Drawing.Point(11, 266);
            this.button_Coz.Name = "button_Coz";
            this.button_Coz.Size = new System.Drawing.Size(247, 72);
            this.button_Coz.TabIndex = 0;
            this.button_Coz.Text = "Çöz";
            this.button_Coz.UseVisualStyleBackColor = true;
            this.button_Coz.Click += new System.EventHandler(this.button_Coz_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(11, 215);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(247, 45);
            this.button10.TabIndex = 0;
            this.button10.Text = "Hedef Durumunu Temizle";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(221, 9);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(37, 200);
            this.button11.TabIndex = 0;
            this.button11.Text = "?";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_info_sifir_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(151, 145);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(64, 64);
            this.button12.TabIndex = 0;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Numaralar_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(151, 75);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(64, 64);
            this.button13.TabIndex = 0;
            this.button13.Text = "6";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_Numaralar_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(151, 9);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(64, 64);
            this.button14.TabIndex = 0;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_Numaralar_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(81, 145);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(64, 64);
            this.button15.TabIndex = 0;
            this.button15.Text = "8";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button_Numaralar_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(81, 75);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(64, 64);
            this.button16.TabIndex = 0;
            this.button16.Text = "5";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button_Numaralar_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(81, 9);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(64, 64);
            this.button17.TabIndex = 0;
            this.button17.Text = "2";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button_Numaralar_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(11, 145);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(64, 64);
            this.button18.TabIndex = 0;
            this.button18.Text = "7";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button_Numaralar_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(11, 75);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(64, 64);
            this.button19.TabIndex = 0;
            this.button19.Text = "4";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button_Numaralar_Click);
            // 
            // button_Numaralar
            // 
            this.button_Numaralar.Location = new System.Drawing.Point(11, 9);
            this.button_Numaralar.Name = "button_Numaralar";
            this.button_Numaralar.Size = new System.Drawing.Size(64, 64);
            this.button_Numaralar.TabIndex = 0;
            this.button_Numaralar.Text = "1";
            this.button_Numaralar.UseVisualStyleBackColor = true;
            this.button_Numaralar.Click += new System.EventHandler(this.button_Numaralar_Click);
            // 
            // SekizTas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_SonDurumRandomSecilsin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Uret);
            this.Controls.Add(this.textBox_Adimlar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1_numaraEkrani);
            this.Controls.Add(this.panel_bilgilendirme_Ekrani);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(789, 467);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(789, 467);
            this.Name = "SekizTas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A Star Algoritması, 8 Taş Problemi";
            this.Load += new System.EventHandler(this.SekizTas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_bilgilendirme_Ekrani.ResumeLayout(false);
            this.panel1_numaraEkrani.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Uret;
        private System.Windows.Forms.CheckBox checkBox_SonDurumRandomSecilsin;
        private System.Windows.Forms.Label label_ProblemCozulebilirMiKontrol;
        private System.Windows.Forms.Label label_RandomUretilenSayilar_Baslangic_Durumu;
        private System.Windows.Forms.Label label_RandomUretilenSayilar_Bitis_Durumu;
        private System.Windows.Forms.TextBox textBox_Adimlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_bilgilendirme_Ekrani;
        private System.Windows.Forms.Panel panel1_numaraEkrani;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button_Numaralar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Coz;
    }
}

