using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazilimYapimiProje
{
    public partial class YENİPROJE : Form
    {
        public YENİPROJE()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=Yazilim_Yapimi;Integrated Security=True");
        public SqlDataReader verioku(string sql)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
          
            return oku;
        }
        public SqlCommand veriislem(string sql)
        {
            baglanti.Open();
                SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            return komut;
        }
        private void YENİPROJE_Load(object sender, EventArgs e)
        {
            SqlDataReader oku = verioku("select Adi from Yazilimci ");
            while (oku.Read())
            {
                txtYazilimci.Properties.Items.Add(oku["Adi"].ToString());
            }
            baglanti.Close();

        }
        
        private void btnProjeOlustur_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtYuzde.Text)<0|| int.Parse(txtYuzde.Text)>100)
            {
                MessageBox.Show("Lütfen 0-100 arası deger giriniz.","Uyarı");
            }
            else
            {
                if (txtProjeAdi.Text != "")
                {
                    SqlCommand islem = veriislem("insert into Proje(Adi,Yuzde) values ('" + txtProjeAdi.Text + "','" + txtYuzde.Text + "')");
                
                }
                   
                baglanti.Close();
                gbstory.Enabled = true;
                gbTask.Enabled = true;
                gbProje.Enabled = false;
                txtProjeAdi.Text = "";
                txtYuzde.Text = "";
            }
           

        }
        int projenu = 1, storynu = 0;
        
        public int maxbul(SqlDataReader oku)
        {
            int max = 0;
            while (oku.Read())
            {
                if (max <oku["NU"].GetHashCode())
                {
                    max =oku["NU"].GetHashCode();
                }
            }
            return max;
        }
        public Color renkdonustur()
        {
            Color temp = Color.FromArgb(Convert.ToInt32(txtcolor.Color.A), Convert.ToInt32(txtcolor.Color.R), Convert.ToInt32(txtcolor.Color.G), Convert.ToInt32(txtcolor.Color.B));
            return temp;
        }
        
        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            TimeSpan fark = (dtpbitisTarihi.Value) - (dtpbaslamaTarihi.Value);
            if (txtKonu.Text!=""&& fark.Days>0 )
            {
               
                SqlDataReader ProjeOku = verioku("select NU  from Proje");
                projenu = maxbul(ProjeOku);
                baglanti.Close();
                dtpbaslamaTarihi.Format = DateTimePickerFormat.Custom;
                dtpbaslamaTarihi.CustomFormat = "yyyy-MM-dd";
                dtpbitisTarihi.Format = DateTimePickerFormat.Custom;
                dtpbitisTarihi.CustomFormat = "yyyy-MM-dd";
                
                SqlCommand StoryEkle = veriislem("insert into Story(ProjeNu,Konu,BaslamaTarihi,BitisTarihi,Renk,Renk_R,Renk_G,Renk_B) values ('" + projenu  + "','" + txtKonu.Text + "','" +dtpbaslamaTarihi.Text + "','" + dtpbitisTarihi.Text+ "','" +(txtcolor.Color.A).ToString() + "','" +(txtcolor.Color.R).ToString() + "','" + (txtcolor.Color.G).ToString() + "','" +(txtcolor.Color.B).ToString() + "')");
                btnStoryGorsel.BackColor = renkdonustur();
                btnStoryGorsel.Text = txtKonu.Text + "         " + dtpbitisTarihi.Value;
                storynu++;
            }
            txtKonu.Text = "";
            baglanti.Close();
            btnTaskekle.Enabled = true;
        }
        
        private void btnTaskekle_Click(object sender, EventArgs e)
        {
            
            if (txtTaskKonu.Text!="")
            {
                SqlDataReader ProjeOku = verioku("select NU  from Proje");
                projenu = maxbul(ProjeOku);
                baglanti.Close();
                SqlDataReader StoryOku = verioku("select NU  from Story");
                storynu = maxbul(StoryOku);
                baglanti.Close();
                SqlCommand TaskEkle = veriislem("insert into Task(StoryNu,Konu,Durum,Yazilimci,ProjeNum) values ('" + storynu + "','" + txtTaskKonu.Text + "','" + txtDurum.Text + "','" + txtYazilimci.Text + "','"+projenu+"')");
                btnTaskDeneme.BackColor = renkdonustur();
                btnTaskDeneme.Text = txtTaskKonu.Text + "      " + txtYazilimci.Text;
                baglanti.Close();
            }
            txtTaskKonu.Text = "";
        }

        private void btnYeniProje_Click(object sender, EventArgs e)
        {
            gbProje.Enabled = true;
            gbstory.Enabled = false;
            gbTask.Enabled = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gbProje.Enabled = false;
            gbstory.Enabled = true;
            gbTask.Enabled = true;
            btnTaskekle.Enabled = true;
        }

        private void btnProjeSil_Click(object sender, EventArgs e)
        {
            ANASAYFA frm = new ANASAYFA();
            frm.Show();
            this.Close();
        }
    }
}
