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
    public partial class Projeler : Form
    {
        public Projeler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=Yazilim_Yapimi;Integrated Security=True");
        public SqlDataReader verioku(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,baglanti);
            SqlDataReader oku=cmd.ExecuteReader();
            return oku ;
        }
        public SqlCommand veriislem(string sql)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            return komut;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
                lviewProjeGoster.Items.Clear();
                baglanti.Open();
                SqlDataReader oku = verioku(" select * from Proje where Adi='" + txtProjeAdi.Text + "'");
            if (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["NU"].ToString();
                    ekle.SubItems.Add(oku["Adi"].ToString());
                    ekle.SubItems.Add(oku["Yuzde"].ToString());
                    lviewProjeGoster.Items.Add(ekle);
                }
                baglanti.Close();
        }
        private void Projeler_Load(object sender, EventArgs e)
        {
            lviewProjeGoster.Items.Clear();
            baglanti.Open();
            SqlDataReader oku = verioku(" select* from Proje");
            while (oku.Read())
            {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["NU"].ToString();
                    ekle.SubItems.Add(oku["Adi"].ToString());
                    ekle.SubItems.Add(oku["Yuzde"].ToString());
                    lviewProjeGoster.Items.Add(ekle);
                txtProjeAdi.Properties.Items.Add(oku["Adi"].ToString());
            }

            baglanti.Close();
                
        }

        private void btnProjeSil_Click(object sender, EventArgs e)
        {
            ANASAYFA frm = new ANASAYFA();
            frm.Show();
            this.Hide();
        }
    }
}

