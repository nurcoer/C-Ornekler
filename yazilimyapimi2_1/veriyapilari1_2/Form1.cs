using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriyapilari1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0, OyunBitis = 0;
        int X, Y;
        public void OyunAlani(int a)
        {
            Button[] btn = new Button[a];
            OyunBitis = a;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    btn[i] = new Button();
                    btn[i].Name = (i + 1).ToString() + (j + 1).ToString();
                    btn[i].Text = 0.ToString();
                    btn[i].BackColor = Color.White;
                    btn[i].Size = new Size(30, 30);
                    btn[i].Location = new Point(i * 30, j * 30);
                    this.Controls.Add(btn[i]);
                    btn[i].Click += new EventHandler(btn_Click);
                }
            }
            temizle();
        }
        public void temizle()
        {
            for (int i = 0; i < OyunBitis; i++)
            {
                for (int j = 0; j < OyunBitis; j++)
                {
                    if (((Button)this.Controls[(i+1).ToString() + (j+1).ToString()]).Enabled!=false)
                    {
                        ((Button)this.Controls[(i+1).ToString() + (j+1 ).ToString()]).Text = 0.ToString();
                        ((Button)this.Controls[(i+1 ).ToString() + (j+1).ToString()]).BackColor = Color.White;
                    }
                }
            }        
        }
        public void btn_Click(object sender, EventArgs e)
        {
            if (sayac==0)
            {
                ((Button)sender).Text = 1.ToString();
                X = int.Parse(((Button)sender).Name.Remove(1, 1));
                Y = int.Parse(((Button)sender).Name.Remove(0, 1));
            }
            if (((Button)sender).Text==1.ToString())
            {
                sayac++;
                ((Button)sender).Text = 1.ToString() ;
                ((Button)sender).Enabled = false;
                temizle();
                X = int.Parse(((Button)sender).Name.Substring(0, 1));
                Y = int.Parse(((Button)sender).Name.Substring(1, 1));
                int xYeni = 2, yYeni = 1, OyunDevam = 0 ;
                for (int k = 0; k < 2; k++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        if ((X - xYeni) > 0 && (Y - yYeni) > 0 && (X - xYeni) <= OyunBitis && (Y - yYeni) <= OyunBitis && ((Button)this.Controls[(X - xYeni).ToString() + (Y - yYeni).ToString()]).Text != 1.ToString())
                        {
                            ((Button)this.Controls[(X - xYeni).ToString() + (Y - yYeni).ToString()]).Text = 1.ToString();
                            ((Button)this.Controls[(X - xYeni).ToString() + (Y - yYeni).ToString()]).BackColor = Color.Blue;
                            OyunDevam++;
                        }
                        switch (j)
                        {
                            case 0:
                                yYeni *= -1;
                                break;
                            case 1:
                                xYeni *= -1;
                                break;
                            case 2:
                                yYeni *= -1;
                                break;
                            default:
                                xYeni *= -1;
                                break;
                        }
                    }
                    switch (k)
                    {
                        case 0:
                            yYeni = 2; xYeni = 1;
                            break;
                    }
                }
            ((Button)sender).BackColor = Color.Black;
                if (OyunDevam == 0)
                    lblsonuc.Text = "Game Over!.. :(";
                lblAdimSay.Visible = true;
                lblAdimSay.Text ="Tıklama sayısı="+sayac.ToString();
            }
            else MessageBox.Show("lütfen renkli noktaları seçiniz..");
            if (sayac == (OyunBitis*OyunBitis))
                lblsonuc.Text = "Kazandınız. :D";
        }
        private void lblOyunKapa_Click_1(object sender, EventArgs e)
        {
                DialogResult GirisKapanis = MessageBox.Show("programı kapatmak istediğinizden eminmisiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (GirisKapanis == DialogResult.No)
                {
                    return;
                }
                Environment.Exit(0);
        }
        private void lblYeniOyun_Click_1(object sender, EventArgs e)
        {
            Ctrl_Ekle();
            gbOyunAlani.Visible = true;
            lblAdimSay.Visible = false;
            lblOyunKapa.Visible = false;
            lblYeniOyun.Visible = false;
            sayac = 0;
        }
        public void Ctrl_Ekle()
        { 
            this.Controls.Clear();
            this.Controls.Add(gbOyunAlani);
            this.Controls.Add(lblAdimSay);
            this.Controls.Add(lblOyunKapa);
            this.Controls.Add(lblsonuc);
            this.Controls.Add(lblYeniOyun);
        }

        private void btnOyunBasla_Click(object sender, EventArgs e)
        {

            gbOyunAlani.Visible = false;
            lblOyunKapa.Visible = true;
            lblYeniOyun.Visible = true;
            if (cb5.Checked == true && cb6.Checked == false && cb7.Checked == false && cb8.Checked == false && cb9.Checked == false)
                OyunAlani(5);
            else if (cb6.Checked == true && cb5.Checked == false && cb7.Checked == false && cb8.Checked == false && cb9.Checked == false)
                OyunAlani(6);
            else if (cb7.Checked == true && cb6.Checked == false && cb5.Checked == false && cb8.Checked == false && cb9.Checked == false)
                OyunAlani(7);
            else if (cb8.Checked == true && cb6.Checked == false && cb7.Checked == false && cb5.Checked == false && cb9.Checked == false)
                OyunAlani(8);
            else if (cb9.Checked == true && cb6.Checked == false && cb7.Checked == false && cb8.Checked == false && cb5.Checked == false)
                OyunAlani(9);
            else MessageBox.Show("lütfen oyun alanınızı seçiniz.");
        }
    }
}
