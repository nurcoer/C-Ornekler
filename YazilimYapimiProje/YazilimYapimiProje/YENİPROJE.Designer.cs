namespace YazilimYapimiProje
{
    partial class YENİPROJE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YENİPROJE));
            this.gbProje = new DevExpress.XtraEditors.GroupControl();
            this.txtYuzde = new DevExpress.XtraEditors.TextEdit();
            this.btnProjeOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.txtProjeAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblYuzde = new DevExpress.XtraEditors.LabelControl();
            this.lblProjeAdi = new DevExpress.XtraEditors.LabelControl();
            this.gbTask = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaskDeneme = new System.Windows.Forms.Button();
            this.btnTaskekle = new DevExpress.XtraEditors.SimpleButton();
            this.txtTaskKonu = new DevExpress.XtraEditors.TextEdit();
            this.lblYazilimci = new DevExpress.XtraEditors.LabelControl();
            this.lblDurum = new DevExpress.XtraEditors.LabelControl();
            this.lblTaskKonu = new DevExpress.XtraEditors.LabelControl();
            this.txtDurum = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtYazilimci = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gbstory = new DevExpress.XtraEditors.GroupControl();
            this.btnStoryGorsel = new System.Windows.Forms.Button();
            this.dtpbitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpbaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnStoryEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtKonu = new DevExpress.XtraEditors.TextEdit();
            this.lblRenk = new DevExpress.XtraEditors.LabelControl();
            this.BitisSayisi = new DevExpress.XtraEditors.LabelControl();
            this.lblBaslamaSayisi = new DevExpress.XtraEditors.LabelControl();
            this.lblKonu = new DevExpress.XtraEditors.LabelControl();
            this.txtcolor = new DevExpress.XtraEditors.ColorPickEdit();
            this.btnProjeSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniProje = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gbProje)).BeginInit();
            this.gbProje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYuzde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbTask)).BeginInit();
            this.gbTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaskKonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYazilimci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbstory)).BeginInit();
            this.gbstory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcolor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProje
            // 
            this.gbProje.Controls.Add(this.txtYuzde);
            this.gbProje.Controls.Add(this.btnProjeOlustur);
            this.gbProje.Controls.Add(this.txtProjeAdi);
            this.gbProje.Controls.Add(this.lblYuzde);
            this.gbProje.Controls.Add(this.lblProjeAdi);
            this.gbProje.Location = new System.Drawing.Point(12, 70);
            this.gbProje.Name = "gbProje";
            this.gbProje.Size = new System.Drawing.Size(200, 182);
            this.gbProje.TabIndex = 0;
            this.gbProje.Text = "Proje ";
            // 
            // txtYuzde
            // 
            this.txtYuzde.EditValue = "0";
            this.txtYuzde.Location = new System.Drawing.Point(6, 78);
            this.txtYuzde.Name = "txtYuzde";
            this.txtYuzde.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtYuzde.Size = new System.Drawing.Size(189, 22);
            this.txtYuzde.TabIndex = 5;
            // 
            // btnProjeOlustur
            // 
            this.btnProjeOlustur.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnProjeOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProjeOlustur.ImageOptions.Image")));
            this.btnProjeOlustur.Location = new System.Drawing.Point(39, 106);
            this.btnProjeOlustur.Name = "btnProjeOlustur";
            this.btnProjeOlustur.Size = new System.Drawing.Size(119, 41);
            this.btnProjeOlustur.TabIndex = 4;
            this.btnProjeOlustur.Text = "Projeyi Oluştur";
            this.btnProjeOlustur.Click += new System.EventHandler(this.btnProjeOlustur_Click);
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Location = new System.Drawing.Point(77, 31);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtProjeAdi.Size = new System.Drawing.Size(118, 22);
            this.txtProjeAdi.TabIndex = 2;
            // 
            // lblYuzde
            // 
            this.lblYuzde.Location = new System.Drawing.Point(49, 59);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(83, 13);
            this.lblYuzde.TabIndex = 1;
            this.lblYuzde.Text = "Proje Yuzde (%):";
            // 
            // lblProjeAdi
            // 
            this.lblProjeAdi.Location = new System.Drawing.Point(7, 40);
            this.lblProjeAdi.Name = "lblProjeAdi";
            this.lblProjeAdi.Size = new System.Drawing.Size(47, 13);
            this.lblProjeAdi.TabIndex = 0;
            this.lblProjeAdi.Text = "Proje Adı:";
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.label1);
            this.gbTask.Controls.Add(this.btnTaskDeneme);
            this.gbTask.Controls.Add(this.btnTaskekle);
            this.gbTask.Controls.Add(this.txtTaskKonu);
            this.gbTask.Controls.Add(this.lblYazilimci);
            this.gbTask.Controls.Add(this.lblDurum);
            this.gbTask.Controls.Add(this.lblTaskKonu);
            this.gbTask.Controls.Add(this.txtDurum);
            this.gbTask.Controls.Add(this.txtYazilimci);
            this.gbTask.Enabled = false;
            this.gbTask.Location = new System.Drawing.Point(0, 127);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(579, 113);
            this.gbTask.TabIndex = 1;
            this.gbTask.Text = "Task";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "!En son eklenen story\'e task eklenir .";
            // 
            // btnTaskDeneme
            // 
            this.btnTaskDeneme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTaskDeneme.Location = new System.Drawing.Point(461, 27);
            this.btnTaskDeneme.Name = "btnTaskDeneme";
            this.btnTaskDeneme.Size = new System.Drawing.Size(113, 70);
            this.btnTaskDeneme.TabIndex = 18;
            this.btnTaskDeneme.UseVisualStyleBackColor = true;
            // 
            // btnTaskekle
            // 
            this.btnTaskekle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnTaskekle.Enabled = false;
            this.btnTaskekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskekle.ImageOptions.Image")));
            this.btnTaskekle.Location = new System.Drawing.Point(358, 50);
            this.btnTaskekle.Name = "btnTaskekle";
            this.btnTaskekle.Size = new System.Drawing.Size(96, 47);
            this.btnTaskekle.TabIndex = 17;
            this.btnTaskekle.Text = "Task Ekle";
            this.btnTaskekle.Click += new System.EventHandler(this.btnTaskekle_Click);
            // 
            // txtTaskKonu
            // 
            this.txtTaskKonu.Location = new System.Drawing.Point(81, 49);
            this.txtTaskKonu.Name = "txtTaskKonu";
            this.txtTaskKonu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtTaskKonu.Size = new System.Drawing.Size(141, 22);
            this.txtTaskKonu.TabIndex = 14;
            // 
            // lblYazilimci
            // 
            this.lblYazilimci.Location = new System.Drawing.Point(243, 52);
            this.lblYazilimci.Name = "lblYazilimci";
            this.lblYazilimci.Size = new System.Drawing.Size(42, 13);
            this.lblYazilimci.TabIndex = 11;
            this.lblYazilimci.Text = "Yazılımcı:";
            // 
            // lblDurum
            // 
            this.lblDurum.Location = new System.Drawing.Point(13, 82);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(35, 13);
            this.lblDurum.TabIndex = 12;
            this.lblDurum.Text = "Durum:";
            // 
            // lblTaskKonu
            // 
            this.lblTaskKonu.Location = new System.Drawing.Point(13, 52);
            this.lblTaskKonu.Name = "lblTaskKonu";
            this.lblTaskKonu.Size = new System.Drawing.Size(28, 13);
            this.lblTaskKonu.TabIndex = 13;
            this.lblTaskKonu.Text = "Konu:";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(81, 75);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDurum.Properties.Items.AddRange(new object[] {
            "To Do",
            "İn Process",
            "Done"});
            this.txtDurum.Size = new System.Drawing.Size(141, 22);
            this.txtDurum.TabIndex = 15;
            // 
            // txtYazilimci
            // 
            this.txtYazilimci.Location = new System.Drawing.Point(243, 71);
            this.txtYazilimci.Name = "txtYazilimci";
            this.txtYazilimci.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtYazilimci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtYazilimci.Size = new System.Drawing.Size(109, 22);
            this.txtYazilimci.TabIndex = 16;
            // 
            // gbstory
            // 
            this.gbstory.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gbstory.Controls.Add(this.btnStoryGorsel);
            this.gbstory.Controls.Add(this.dtpbitisTarihi);
            this.gbstory.Controls.Add(this.dtpbaslamaTarihi);
            this.gbstory.Controls.Add(this.btnStoryEkle);
            this.gbstory.Controls.Add(this.txtKonu);
            this.gbstory.Controls.Add(this.lblRenk);
            this.gbstory.Controls.Add(this.BitisSayisi);
            this.gbstory.Controls.Add(this.lblBaslamaSayisi);
            this.gbstory.Controls.Add(this.lblKonu);
            this.gbstory.Controls.Add(this.gbTask);
            this.gbstory.Controls.Add(this.txtcolor);
            this.gbstory.Enabled = false;
            this.gbstory.Location = new System.Drawing.Point(219, 12);
            this.gbstory.Name = "gbstory";
            this.gbstory.Size = new System.Drawing.Size(579, 240);
            this.gbstory.TabIndex = 1;
            this.gbstory.Text = "Story";
            // 
            // btnStoryGorsel
            // 
            this.btnStoryGorsel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStoryGorsel.Location = new System.Drawing.Point(461, 24);
            this.btnStoryGorsel.Name = "btnStoryGorsel";
            this.btnStoryGorsel.Size = new System.Drawing.Size(113, 92);
            this.btnStoryGorsel.TabIndex = 15;
            this.btnStoryGorsel.UseVisualStyleBackColor = true;
            // 
            // dtpbitisTarihi
            // 
            this.dtpbitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbitisTarihi.Location = new System.Drawing.Point(243, 93);
            this.dtpbitisTarihi.Name = "dtpbitisTarihi";
            this.dtpbitisTarihi.Size = new System.Drawing.Size(109, 21);
            this.dtpbitisTarihi.TabIndex = 13;
            // 
            // dtpbaslamaTarihi
            // 
            this.dtpbaslamaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbaslamaTarihi.Location = new System.Drawing.Point(81, 93);
            this.dtpbaslamaTarihi.Name = "dtpbaslamaTarihi";
            this.dtpbaslamaTarihi.Size = new System.Drawing.Size(114, 21);
            this.dtpbaslamaTarihi.TabIndex = 12;
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnStoryEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStoryEkle.ImageOptions.Image")));
            this.btnStoryEkle.Location = new System.Drawing.Point(358, 37);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(96, 52);
            this.btnStoryEkle.TabIndex = 11;
            this.btnStoryEkle.Text = "Story Ekle";
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(81, 33);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtKonu.Size = new System.Drawing.Size(141, 22);
            this.txtKonu.TabIndex = 6;
            // 
            // lblRenk
            // 
            this.lblRenk.Location = new System.Drawing.Point(271, 37);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(28, 13);
            this.lblRenk.TabIndex = 5;
            this.lblRenk.Text = "Renk:";
            // 
            // BitisSayisi
            // 
            this.BitisSayisi.Location = new System.Drawing.Point(271, 66);
            this.BitisSayisi.Name = "BitisSayisi";
            this.BitisSayisi.Size = new System.Drawing.Size(52, 13);
            this.BitisSayisi.TabIndex = 4;
            this.BitisSayisi.Text = "Bitis Tarihi:";
            // 
            // lblBaslamaSayisi
            // 
            this.lblBaslamaSayisi.Location = new System.Drawing.Point(100, 66);
            this.lblBaslamaSayisi.Name = "lblBaslamaSayisi";
            this.lblBaslamaSayisi.Size = new System.Drawing.Size(72, 13);
            this.lblBaslamaSayisi.TabIndex = 3;
            this.lblBaslamaSayisi.Text = "Baslama Tarihi:";
            // 
            // lblKonu
            // 
            this.lblKonu.Location = new System.Drawing.Point(13, 37);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(28, 13);
            this.lblKonu.TabIndex = 2;
            this.lblKonu.Text = "Konu:";
            // 
            // txtcolor
            // 
            this.txtcolor.EditValue = System.Drawing.Color.White;
            this.txtcolor.Location = new System.Drawing.Point(305, 33);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.txtcolor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcolor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtcolor.Properties.ColorText = DevExpress.XtraEditors.Controls.ColorText.Integer;
            this.txtcolor.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D;
            this.txtcolor.Size = new System.Drawing.Size(47, 22);
            this.txtcolor.TabIndex = 14;
            // 
            // btnProjeSil
            // 
            this.btnProjeSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProjeSil.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProjeSil.Appearance.Options.UseFont = true;
            this.btnProjeSil.Appearance.Options.UseForeColor = true;
            this.btnProjeSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnProjeSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProjeSil.ImageOptions.Image")));
            this.btnProjeSil.Location = new System.Drawing.Point(12, 12);
            this.btnProjeSil.Name = "btnProjeSil";
            this.btnProjeSil.Size = new System.Drawing.Size(24, 23);
            this.btnProjeSil.TabIndex = 3;
            this.btnProjeSil.Text = "Anasayfa";
            this.btnProjeSil.Click += new System.EventHandler(this.btnProjeSil_Click);
            // 
            // btnYeniProje
            // 
            this.btnYeniProje.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniProje.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYeniProje.Appearance.Options.UseFont = true;
            this.btnYeniProje.Appearance.Options.UseForeColor = true;
            this.btnYeniProje.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnYeniProje.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniProje.ImageOptions.Image")));
            this.btnYeniProje.Location = new System.Drawing.Point(12, 43);
            this.btnYeniProje.Name = "btnYeniProje";
            this.btnYeniProje.Size = new System.Drawing.Size(95, 23);
            this.btnYeniProje.TabIndex = 2;
            this.btnYeniProje.Text = "Yeni Proje";
            this.btnYeniProje.Click += new System.EventHandler(this.btnYeniProje_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(51, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(148, 23);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Task ve Story Ekle";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // YENİPROJE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 264);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnYeniProje);
            this.Controls.Add(this.btnProjeSil);
            this.Controls.Add(this.gbstory);
            this.Controls.Add(this.gbProje);
            this.Name = "YENİPROJE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YENİ PROJE";
            this.Load += new System.EventHandler(this.YENİPROJE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbProje)).EndInit();
            this.gbProje.ResumeLayout(false);
            this.gbProje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYuzde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbTask)).EndInit();
            this.gbTask.ResumeLayout(false);
            this.gbTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaskKonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYazilimci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbstory)).EndInit();
            this.gbstory.ResumeLayout(false);
            this.gbstory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcolor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbProje;
        private DevExpress.XtraEditors.GroupControl gbTask;
        private DevExpress.XtraEditors.GroupControl gbstory;
        private DevExpress.XtraEditors.SimpleButton btnProjeOlustur;
        private DevExpress.XtraEditors.TextEdit txtProjeAdi;
        private DevExpress.XtraEditors.LabelControl lblYuzde;
        private DevExpress.XtraEditors.LabelControl lblProjeAdi;
        private DevExpress.XtraEditors.TextEdit txtKonu;
        private DevExpress.XtraEditors.LabelControl lblRenk;
        private DevExpress.XtraEditors.LabelControl BitisSayisi;
        private DevExpress.XtraEditors.LabelControl lblBaslamaSayisi;
        private DevExpress.XtraEditors.LabelControl lblKonu;
        private DevExpress.XtraEditors.TextEdit txtTaskKonu;
        private DevExpress.XtraEditors.LabelControl lblYazilimci;
        private DevExpress.XtraEditors.LabelControl lblDurum;
        private DevExpress.XtraEditors.LabelControl lblTaskKonu;
        private DevExpress.XtraEditors.ComboBoxEdit txtDurum;
        private DevExpress.XtraEditors.ComboBoxEdit txtYazilimci;
        private DevExpress.XtraEditors.SimpleButton btnTaskekle;
        private DevExpress.XtraEditors.SimpleButton btnStoryEkle;
        private DevExpress.XtraEditors.TextEdit txtYuzde;
        private DevExpress.XtraEditors.SimpleButton btnYeniProje;
        private DevExpress.XtraEditors.SimpleButton btnProjeSil;
        private System.Windows.Forms.DateTimePicker dtpbitisTarihi;
        private System.Windows.Forms.DateTimePicker dtpbaslamaTarihi;
        private DevExpress.XtraEditors.ColorPickEdit txtcolor;
        private System.Windows.Forms.Button btnTaskDeneme;
        private System.Windows.Forms.Button btnStoryGorsel;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}