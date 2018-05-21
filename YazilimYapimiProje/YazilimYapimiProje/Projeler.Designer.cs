namespace YazilimYapimiProje
{
    partial class Projeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projeler));
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.lblProjeAdi = new DevExpress.XtraEditors.LabelControl();
            this.lviewProjeGoster = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtProjeAdi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnProjeSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.ImageOptions.Image")));
            this.btnAra.Location = new System.Drawing.Point(217, 13);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(101, 57);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "ARA";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblProjeAdi
            // 
            this.lblProjeAdi.Location = new System.Drawing.Point(13, 12);
            this.lblProjeAdi.Name = "lblProjeAdi";
            this.lblProjeAdi.Size = new System.Drawing.Size(47, 13);
            this.lblProjeAdi.TabIndex = 2;
            this.lblProjeAdi.Text = "Proje Adı:";
            // 
            // lviewProjeGoster
            // 
            this.lviewProjeGoster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lviewProjeGoster.Location = new System.Drawing.Point(13, 76);
            this.lviewProjeGoster.Name = "lviewProjeGoster";
            this.lviewProjeGoster.Size = new System.Drawing.Size(335, 173);
            this.lviewProjeGoster.TabIndex = 4;
            this.lviewProjeGoster.UseCompatibleStateImageBehavior = false;
            this.lviewProjeGoster.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Proje Nu";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Proje Adı";
            this.columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bitme Yüzdesi";
            this.columnHeader3.Width = 86;
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.EditValue = "";
            this.txtProjeAdi.Location = new System.Drawing.Point(13, 32);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProjeAdi.Size = new System.Drawing.Size(198, 20);
            this.txtProjeAdi.TabIndex = 5;
            // 
            // btnProjeSil
            // 
            this.btnProjeSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProjeSil.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProjeSil.Appearance.Options.UseFont = true;
            this.btnProjeSil.Appearance.Options.UseForeColor = true;
            this.btnProjeSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnProjeSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProjeSil.ImageOptions.Image")));
            this.btnProjeSil.Location = new System.Drawing.Point(324, 12);
            this.btnProjeSil.Name = "btnProjeSil";
            this.btnProjeSil.Size = new System.Drawing.Size(24, 58);
            this.btnProjeSil.TabIndex = 6;
            this.btnProjeSil.Text = "Anasayfa";
            this.btnProjeSil.Click += new System.EventHandler(this.btnProjeSil_Click);
            // 
            // Projeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 261);
            this.Controls.Add(this.btnProjeSil);
            this.Controls.Add(this.lviewProjeGoster);
            this.Controls.Add(this.lblProjeAdi);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtProjeAdi);
            this.Name = "Projeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeler";
            this.Load += new System.EventHandler(this.Projeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.LabelControl lblProjeAdi;
        private System.Windows.Forms.ListView lviewProjeGoster;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private DevExpress.XtraEditors.ComboBoxEdit txtProjeAdi;
        private DevExpress.XtraEditors.SimpleButton btnProjeSil;
    }
}