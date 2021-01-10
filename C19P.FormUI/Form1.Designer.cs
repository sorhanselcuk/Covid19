namespace C19P.FormUI
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
            this.dgwCovidVeri = new System.Windows.Forms.DataGridView();
            this.gbxVeriGirisi = new System.Windows.Forms.GroupBox();
            this.lblEntubeSayisi = new System.Windows.Forms.Label();
            this.lblIyilesenSayisi = new System.Windows.Forms.Label();
            this.btnVeriGirisi = new System.Windows.Forms.Button();
            this.tbxVakaSayisi = new System.Windows.Forms.TextBox();
            this.tbxTestSayisi = new System.Windows.Forms.TextBox();
            this.lblVefatSayisi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.tbxVefatSayisi = new System.Windows.Forms.TextBox();
            this.lblVakaSayisi = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.tbxIyilesenSayisi = new System.Windows.Forms.TextBox();
            this.tbxEntubeSayisi = new System.Windows.Forms.TextBox();
            this.lblTestSayisi = new System.Windows.Forms.Label();
            this.gbxGuncelle = new System.Windows.Forms.GroupBox();
            this.tbxGuncelleTarih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tbxGuncelleVakaSayisi = new System.Windows.Forms.TextBox();
            this.tbxGuncelleTestSayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxGuncelleVefatSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxGuncelleIyilesenSayisi = new System.Windows.Forms.TextBox();
            this.tbxGuncelleEntubeSayisi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCovidVeri)).BeginInit();
            this.gbxVeriGirisi.SuspendLayout();
            this.gbxGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCovidVeri
            // 
            this.dgwCovidVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCovidVeri.Location = new System.Drawing.Point(12, 12);
            this.dgwCovidVeri.Name = "dgwCovidVeri";
            this.dgwCovidVeri.Size = new System.Drawing.Size(776, 150);
            this.dgwCovidVeri.TabIndex = 0;
            this.dgwCovidVeri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCovidVeri_CellClick);
            this.dgwCovidVeri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCovidVeri_CellDoubleClick);
            // 
            // gbxVeriGirisi
            // 
            this.gbxVeriGirisi.Controls.Add(this.lblEntubeSayisi);
            this.gbxVeriGirisi.Controls.Add(this.lblIyilesenSayisi);
            this.gbxVeriGirisi.Controls.Add(this.btnVeriGirisi);
            this.gbxVeriGirisi.Controls.Add(this.tbxVakaSayisi);
            this.gbxVeriGirisi.Controls.Add(this.tbxTestSayisi);
            this.gbxVeriGirisi.Controls.Add(this.lblVefatSayisi);
            this.gbxVeriGirisi.Controls.Add(this.lblTarih);
            this.gbxVeriGirisi.Controls.Add(this.tbxVefatSayisi);
            this.gbxVeriGirisi.Controls.Add(this.lblVakaSayisi);
            this.gbxVeriGirisi.Controls.Add(this.dtpTarih);
            this.gbxVeriGirisi.Controls.Add(this.tbxIyilesenSayisi);
            this.gbxVeriGirisi.Controls.Add(this.tbxEntubeSayisi);
            this.gbxVeriGirisi.Controls.Add(this.lblTestSayisi);
            this.gbxVeriGirisi.Location = new System.Drawing.Point(12, 186);
            this.gbxVeriGirisi.Name = "gbxVeriGirisi";
            this.gbxVeriGirisi.Size = new System.Drawing.Size(195, 196);
            this.gbxVeriGirisi.TabIndex = 1;
            this.gbxVeriGirisi.TabStop = false;
            this.gbxVeriGirisi.Text = "Veri Girişi";
            // 
            // lblEntubeSayisi
            // 
            this.lblEntubeSayisi.AutoSize = true;
            this.lblEntubeSayisi.Location = new System.Drawing.Point(9, 68);
            this.lblEntubeSayisi.Name = "lblEntubeSayisi";
            this.lblEntubeSayisi.Size = new System.Drawing.Size(71, 13);
            this.lblEntubeSayisi.TabIndex = 0;
            this.lblEntubeSayisi.Text = "Entübe Sayısı";
            // 
            // lblIyilesenSayisi
            // 
            this.lblIyilesenSayisi.AutoSize = true;
            this.lblIyilesenSayisi.Location = new System.Drawing.Point(8, 147);
            this.lblIyilesenSayisi.Name = "lblIyilesenSayisi";
            this.lblIyilesenSayisi.Size = new System.Drawing.Size(72, 13);
            this.lblIyilesenSayisi.TabIndex = 9;
            this.lblIyilesenSayisi.Text = "İyileşen Sayısı";
            // 
            // btnVeriGirisi
            // 
            this.btnVeriGirisi.Location = new System.Drawing.Point(110, 169);
            this.btnVeriGirisi.Name = "btnVeriGirisi";
            this.btnVeriGirisi.Size = new System.Drawing.Size(75, 23);
            this.btnVeriGirisi.TabIndex = 13;
            this.btnVeriGirisi.Text = "Ekle";
            this.btnVeriGirisi.UseVisualStyleBackColor = true;
            this.btnVeriGirisi.Click += new System.EventHandler(this.btnVeriGirisi_Click);
            // 
            // tbxVakaSayisi
            // 
            this.tbxVakaSayisi.Location = new System.Drawing.Point(85, 92);
            this.tbxVakaSayisi.Name = "tbxVakaSayisi";
            this.tbxVakaSayisi.Size = new System.Drawing.Size(100, 20);
            this.tbxVakaSayisi.TabIndex = 8;
            // 
            // tbxTestSayisi
            // 
            this.tbxTestSayisi.Location = new System.Drawing.Point(85, 39);
            this.tbxTestSayisi.Name = "tbxTestSayisi";
            this.tbxTestSayisi.Size = new System.Drawing.Size(100, 20);
            this.tbxTestSayisi.TabIndex = 10;
            // 
            // lblVefatSayisi
            // 
            this.lblVefatSayisi.AutoSize = true;
            this.lblVefatSayisi.Location = new System.Drawing.Point(17, 121);
            this.lblVefatSayisi.Name = "lblVefatSayisi";
            this.lblVefatSayisi.Size = new System.Drawing.Size(62, 13);
            this.lblVefatSayisi.TabIndex = 7;
            this.lblVefatSayisi.Text = "Vefat Sayısı";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(48, 19);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 12;
            this.lblTarih.Text = "Tarih";
            // 
            // tbxVefatSayisi
            // 
            this.tbxVefatSayisi.Location = new System.Drawing.Point(85, 118);
            this.tbxVefatSayisi.Name = "tbxVefatSayisi";
            this.tbxVefatSayisi.Size = new System.Drawing.Size(100, 20);
            this.tbxVefatSayisi.TabIndex = 6;
            // 
            // lblVakaSayisi
            // 
            this.lblVakaSayisi.AutoSize = true;
            this.lblVakaSayisi.Location = new System.Drawing.Point(17, 95);
            this.lblVakaSayisi.Name = "lblVakaSayisi";
            this.lblVakaSayisi.Size = new System.Drawing.Size(62, 13);
            this.lblVakaSayisi.TabIndex = 5;
            this.lblVakaSayisi.Text = "Vaka Sayısı";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(85, 13);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(100, 20);
            this.dtpTarih.TabIndex = 11;
            // 
            // tbxIyilesenSayisi
            // 
            this.tbxIyilesenSayisi.Location = new System.Drawing.Point(85, 144);
            this.tbxIyilesenSayisi.Name = "tbxIyilesenSayisi";
            this.tbxIyilesenSayisi.Size = new System.Drawing.Size(100, 20);
            this.tbxIyilesenSayisi.TabIndex = 4;
            // 
            // tbxEntubeSayisi
            // 
            this.tbxEntubeSayisi.Location = new System.Drawing.Point(85, 65);
            this.tbxEntubeSayisi.Name = "tbxEntubeSayisi";
            this.tbxEntubeSayisi.Size = new System.Drawing.Size(100, 20);
            this.tbxEntubeSayisi.TabIndex = 2;
            // 
            // lblTestSayisi
            // 
            this.lblTestSayisi.AutoSize = true;
            this.lblTestSayisi.Location = new System.Drawing.Point(22, 42);
            this.lblTestSayisi.Name = "lblTestSayisi";
            this.lblTestSayisi.Size = new System.Drawing.Size(58, 13);
            this.lblTestSayisi.TabIndex = 3;
            this.lblTestSayisi.Text = "Test Sayısı";
            // 
            // gbxGuncelle
            // 
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleTarih);
            this.gbxGuncelle.Controls.Add(this.label1);
            this.gbxGuncelle.Controls.Add(this.label2);
            this.gbxGuncelle.Controls.Add(this.btnGuncelle);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleVakaSayisi);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleTestSayisi);
            this.gbxGuncelle.Controls.Add(this.label3);
            this.gbxGuncelle.Controls.Add(this.label4);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleVefatSayisi);
            this.gbxGuncelle.Controls.Add(this.label5);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleIyilesenSayisi);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleEntubeSayisi);
            this.gbxGuncelle.Controls.Add(this.label6);
            this.gbxGuncelle.Location = new System.Drawing.Point(593, 186);
            this.gbxGuncelle.Name = "gbxGuncelle";
            this.gbxGuncelle.Size = new System.Drawing.Size(195, 196);
            this.gbxGuncelle.TabIndex = 14;
            this.gbxGuncelle.TabStop = false;
            this.gbxGuncelle.Text = "Veri Güncelleme";
            // 
            // tbxGuncelleTarih
            // 
            this.tbxGuncelleTarih.Enabled = false;
            this.tbxGuncelleTarih.Location = new System.Drawing.Point(85, 13);
            this.tbxGuncelleTarih.Name = "tbxGuncelleTarih";
            this.tbxGuncelleTarih.Size = new System.Drawing.Size(100, 20);
            this.tbxGuncelleTarih.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entübe Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "İyileşen Sayısı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(110, 169);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbxGuncelleVakaSayisi
            // 
            this.tbxGuncelleVakaSayisi.Location = new System.Drawing.Point(85, 92);
            this.tbxGuncelleVakaSayisi.Name = "tbxGuncelleVakaSayisi";
            this.tbxGuncelleVakaSayisi.Size = new System.Drawing.Size(100, 20);
            this.tbxGuncelleVakaSayisi.TabIndex = 8;
            // 
            // tbxGuncelleTestSayisi
            // 
            this.tbxGuncelleTestSayisi.Location = new System.Drawing.Point(85, 39);
            this.tbxGuncelleTestSayisi.Name = "tbxGuncelleTestSayisi";
            this.tbxGuncelleTestSayisi.Size = new System.Drawing.Size(100, 20);
            this.tbxGuncelleTestSayisi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vefat Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tarih";
            // 
            // tbxGuncelleVefatSayisi
            // 
            this.tbxGuncelleVefatSayisi.Location = new System.Drawing.Point(85, 118);
            this.tbxGuncelleVefatSayisi.Name = "tbxGuncelleVefatSayisi";
            this.tbxGuncelleVefatSayisi.Size = new System.Drawing.Size(100, 20);
            this.tbxGuncelleVefatSayisi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vaka Sayısı";
            // 
            // tbxGuncelleIyilesenSayisi
            // 
            this.tbxGuncelleIyilesenSayisi.Location = new System.Drawing.Point(85, 144);
            this.tbxGuncelleIyilesenSayisi.Name = "tbxGuncelleIyilesenSayisi";
            this.tbxGuncelleIyilesenSayisi.Size = new System.Drawing.Size(100, 20);
            this.tbxGuncelleIyilesenSayisi.TabIndex = 4;
            // 
            // tbxGuncelleEntubeSayisi
            // 
            this.tbxGuncelleEntubeSayisi.Location = new System.Drawing.Point(85, 65);
            this.tbxGuncelleEntubeSayisi.Name = "tbxGuncelleEntubeSayisi";
            this.tbxGuncelleEntubeSayisi.Size = new System.Drawing.Size(100, 20);
            this.tbxGuncelleEntubeSayisi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Test Sayısı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxGuncelle);
            this.Controls.Add(this.gbxVeriGirisi);
            this.Controls.Add(this.dgwCovidVeri);
            this.Name = "Form1";
            this.Text = "Covid 19";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCovidVeri)).EndInit();
            this.gbxVeriGirisi.ResumeLayout(false);
            this.gbxVeriGirisi.PerformLayout();
            this.gbxGuncelle.ResumeLayout(false);
            this.gbxGuncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCovidVeri;
        private System.Windows.Forms.GroupBox gbxVeriGirisi;
        private System.Windows.Forms.Button btnVeriGirisi;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblEntubeSayisi;
        private System.Windows.Forms.TextBox tbxEntubeSayisi;
        private System.Windows.Forms.TextBox tbxIyilesenSayisi;
        private System.Windows.Forms.Label lblTestSayisi;
        private System.Windows.Forms.TextBox tbxVefatSayisi;
        private System.Windows.Forms.Label lblVakaSayisi;
        private System.Windows.Forms.TextBox tbxVakaSayisi;
        private System.Windows.Forms.Label lblVefatSayisi;
        private System.Windows.Forms.TextBox tbxTestSayisi;
        private System.Windows.Forms.Label lblIyilesenSayisi;
        private System.Windows.Forms.GroupBox gbxGuncelle;
        private System.Windows.Forms.TextBox tbxGuncelleTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tbxGuncelleVakaSayisi;
        private System.Windows.Forms.TextBox tbxGuncelleTestSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxGuncelleVefatSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxGuncelleIyilesenSayisi;
        private System.Windows.Forms.TextBox tbxGuncelleEntubeSayisi;
        private System.Windows.Forms.Label label6;
    }
}

