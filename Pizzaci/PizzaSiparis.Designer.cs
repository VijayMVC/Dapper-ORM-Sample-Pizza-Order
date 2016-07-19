namespace Pizzaci
{
    partial class PizzaSiparis
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
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.btnHesapla = new MetroFramework.Controls.MetroButton();
            this.txtAdet = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.Tutar = new MetroFramework.Controls.MetroLabel();
            this.btnSepeteEkle = new MetroFramework.Controls.MetroButton();
            this.txtTutar = new MetroFramework.Controls.MetroTextBox();
            this.lblTutar = new MetroFramework.Controls.MetroLabel();
            this.btnSiparisiOnayla = new MetroFramework.Controls.MetroButton();
            this.cmbEbatlar = new MetroFramework.Controls.MetroComboBox();
            this.cmbPizzalar = new MetroFramework.Controls.MetroComboBox();
            this.rdInceKenar = new MetroFramework.Controls.MetroRadioButton();
            this.rdKalinKenar = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lstSiparis
            // 
            this.lstSiparis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSiparis.Font = new System.Drawing.Font("Ubuntu Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.ItemHeight = 17;
            this.lstSiparis.Location = new System.Drawing.Point(375, 63);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(487, 274);
            this.lstSiparis.TabIndex = 5;
            // 
            // btnHesapla
            // 
            this.btnHesapla.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnHesapla.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnHesapla.Location = new System.Drawing.Point(138, 380);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(107, 29);
            this.btnHesapla.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnHesapla.TabIndex = 18;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnHesapla.UseSelectable = true;
            this.btnHesapla.UseStyleColors = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtAdet
            // 
            // 
            // 
            // 
            this.txtAdet.CustomButton.Image = null;
            this.txtAdet.CustomButton.Location = new System.Drawing.Point(32, 1);
            this.txtAdet.CustomButton.Name = "";
            this.txtAdet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdet.CustomButton.TabIndex = 1;
            this.txtAdet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdet.CustomButton.UseSelectable = true;
            this.txtAdet.CustomButton.Visible = false;
            this.txtAdet.Lines = new string[0];
            this.txtAdet.Location = new System.Drawing.Point(78, 383);
            this.txtAdet.MaxLength = 32767;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.PasswordChar = '\0';
            this.txtAdet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdet.SelectedText = "";
            this.txtAdet.SelectionLength = 0;
            this.txtAdet.SelectionStart = 0;
            this.txtAdet.Size = new System.Drawing.Size(54, 23);
            this.txtAdet.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtAdet.TabIndex = 19;
            this.txtAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdet.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAdet.UseSelectable = true;
            this.txtAdet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel11.Location = new System.Drawing.Point(35, 68);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(50, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel11.TabIndex = 0;
            this.metroLabel11.Text = "Ebatlar";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // Tutar
            // 
            this.Tutar.AutoSize = true;
            this.Tutar.BackColor = System.Drawing.Color.Transparent;
            this.Tutar.ForeColor = System.Drawing.Color.DarkGray;
            this.Tutar.Location = new System.Drawing.Point(256, 383);
            this.Tutar.Name = "Tutar";
            this.Tutar.Size = new System.Drawing.Size(37, 19);
            this.Tutar.Style = MetroFramework.MetroColorStyle.Orange;
            this.Tutar.TabIndex = 0;
            this.Tutar.Text = "Tutar";
            this.Tutar.UseCustomBackColor = true;
            this.Tutar.UseCustomForeColor = true;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Enabled = false;
            this.btnSepeteEkle.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSepeteEkle.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSepeteEkle.Location = new System.Drawing.Point(385, 380);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(107, 29);
            this.btnSepeteEkle.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSepeteEkle.TabIndex = 18;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSepeteEkle.UseSelectable = true;
            this.btnSepeteEkle.UseStyleColors = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // txtTutar
            // 
            // 
            // 
            // 
            this.txtTutar.CustomButton.Image = null;
            this.txtTutar.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtTutar.CustomButton.Name = "";
            this.txtTutar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTutar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTutar.CustomButton.TabIndex = 1;
            this.txtTutar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTutar.CustomButton.UseSelectable = true;
            this.txtTutar.CustomButton.Visible = false;
            this.txtTutar.Enabled = false;
            this.txtTutar.Lines = new string[0];
            this.txtTutar.Location = new System.Drawing.Point(299, 383);
            this.txtTutar.MaxLength = 32767;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.PasswordChar = '\0';
            this.txtTutar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTutar.SelectedText = "";
            this.txtTutar.SelectionLength = 0;
            this.txtTutar.SelectionStart = 0;
            this.txtTutar.Size = new System.Drawing.Size(80, 23);
            this.txtTutar.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtTutar.TabIndex = 19;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTutar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTutar.UseSelectable = true;
            this.txtTutar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTutar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblTutar.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTutar.Location = new System.Drawing.Point(695, 346);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(0, 0);
            this.lblTutar.TabIndex = 0;
            this.lblTutar.UseCustomBackColor = true;
            this.lblTutar.UseCustomForeColor = true;
            // 
            // btnSiparisiOnayla
            // 
            this.btnSiparisiOnayla.Enabled = false;
            this.btnSiparisiOnayla.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSiparisiOnayla.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSiparisiOnayla.Location = new System.Drawing.Point(653, 380);
            this.btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            this.btnSiparisiOnayla.Size = new System.Drawing.Size(209, 29);
            this.btnSiparisiOnayla.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSiparisiOnayla.TabIndex = 18;
            this.btnSiparisiOnayla.Text = "Siparişi Onayla";
            this.btnSiparisiOnayla.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSiparisiOnayla.UseSelectable = true;
            this.btnSiparisiOnayla.UseStyleColors = true;
            this.btnSiparisiOnayla.Click += new System.EventHandler(this.btnSiparisiOnayla_Click);
            // 
            // cmbEbatlar
            // 
            this.cmbEbatlar.FormattingEnabled = true;
            this.cmbEbatlar.ItemHeight = 23;
            this.cmbEbatlar.Location = new System.Drawing.Point(97, 63);
            this.cmbEbatlar.Name = "cmbEbatlar";
            this.cmbEbatlar.Size = new System.Drawing.Size(256, 29);
            this.cmbEbatlar.TabIndex = 20;
            this.cmbEbatlar.UseSelectable = true;
            // 
            // cmbPizzalar
            // 
            this.cmbPizzalar.FormattingEnabled = true;
            this.cmbPizzalar.ItemHeight = 23;
            this.cmbPizzalar.Location = new System.Drawing.Point(97, 98);
            this.cmbPizzalar.Name = "cmbPizzalar";
            this.cmbPizzalar.Size = new System.Drawing.Size(256, 29);
            this.cmbPizzalar.TabIndex = 20;
            this.cmbPizzalar.UseSelectable = true;
            // 
            // rdInceKenar
            // 
            this.rdInceKenar.AutoSize = true;
            this.rdInceKenar.BackColor = System.Drawing.Color.Transparent;
            this.rdInceKenar.Location = new System.Drawing.Point(138, 139);
            this.rdInceKenar.Name = "rdInceKenar";
            this.rdInceKenar.Size = new System.Drawing.Size(28, 15);
            this.rdInceKenar.Style = MetroFramework.MetroColorStyle.Orange;
            this.rdInceKenar.TabIndex = 21;
            this.rdInceKenar.Text = "-";
            this.rdInceKenar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rdInceKenar.UseSelectable = true;
            // 
            // rdKalinKenar
            // 
            this.rdKalinKenar.AutoSize = true;
            this.rdKalinKenar.BackColor = System.Drawing.Color.Transparent;
            this.rdKalinKenar.Location = new System.Drawing.Point(239, 139);
            this.rdKalinKenar.Name = "rdKalinKenar";
            this.rdKalinKenar.Size = new System.Drawing.Size(28, 15);
            this.rdKalinKenar.Style = MetroFramework.MetroColorStyle.Orange;
            this.rdKalinKenar.TabIndex = 21;
            this.rdKalinKenar.Text = "-";
            this.rdKalinKenar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rdKalinKenar.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel12.Location = new System.Drawing.Point(35, 103);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(54, 19);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel12.TabIndex = 22;
            this.metroLabel12.Text = "Pizzalar";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel14.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel14.Location = new System.Drawing.Point(22, 384);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(37, 19);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel14.TabIndex = 23;
            this.metroLabel14.Text = "Adet";
            this.metroLabel14.UseCustomBackColor = true;
            this.metroLabel14.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel2.Location = new System.Drawing.Point(35, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Kenar Tipi :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(35, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 162);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzemeler";
            // 
            // PizzaSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.rdKalinKenar);
            this.Controls.Add(this.rdInceKenar);
            this.Controls.Add(this.cmbPizzalar);
            this.Controls.Add(this.cmbEbatlar);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.btnSiparisiOnayla);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.Tutar);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lstSiparis);
            this.Name = "PizzaSiparis";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Pizza Sipariş Ekranı";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstSiparis;
        private MetroFramework.Controls.MetroButton btnHesapla;
        private MetroFramework.Controls.MetroTextBox txtAdet;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel Tutar;
        private MetroFramework.Controls.MetroButton btnSepeteEkle;
        private MetroFramework.Controls.MetroTextBox txtTutar;
        private MetroFramework.Controls.MetroLabel lblTutar;
        private MetroFramework.Controls.MetroButton btnSiparisiOnayla;
        private MetroFramework.Controls.MetroComboBox cmbEbatlar;
        private MetroFramework.Controls.MetroComboBox cmbPizzalar;
        private MetroFramework.Controls.MetroRadioButton rdInceKenar;
        private MetroFramework.Controls.MetroRadioButton rdKalinKenar;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

