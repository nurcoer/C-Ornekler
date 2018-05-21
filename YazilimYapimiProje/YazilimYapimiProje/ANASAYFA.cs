using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazilimYapimiProje
{
    public partial class ANASAYFA : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ANASAYFA()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=Yazilim_Yapimi;Integrated Security=True");
        public SqlDataReader verioku(string sql)
        {
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            return oku;
        }
        public SqlCommand veriislem(string sql)
        {
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            return komut;

        }
        private void btnProjeler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Projeler frm = new Projeler();
            frm.Show();
            this.Hide();
        }

        private void btnYeniProje_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YENİPROJE frm = new YENİPROJE();
            frm.Show();
            this.Hide();
        }

        private void ANASAYFA_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataReader oku = verioku("select Adi from Proje");

            while (oku.Read())
            {
                cboxProje.Properties.Items.Add(oku["Adi"].ToString());
            }
            baglanti.Close();
            foreach (Button b in this.pnlToDo.Controls)
            {
                b.MouseDown += new MouseEventHandler(btn_MouseDown);
            }
            foreach (Button b in this.pnlInProcess.Controls)
            {
                b.MouseDown += new MouseEventHandler(btn_MouseDown);
            }
            foreach (Button b in this.pnlDone.Controls)
            {
                b.MouseDown += new MouseEventHandler(btn_MouseDown);
            }
            foreach (Button b in this.pnltask.Controls)
            {
                b.MouseDown += new MouseEventHandler(btn_MouseDown);
            }
            this.pnlToDo.DragOver += new DragEventHandler(pnlToDo_DragOver);
            this.pnlToDo.DragOver += new DragEventHandler(pnlToDo_DragDrop);
            this.pnlDone.DragOver += new DragEventHandler(pnlDone_DragOver);
            this.pnlDone.DragOver += new DragEventHandler(pnlDone_DragDrop);
            this.pnlInProcess.DragOver += new DragEventHandler(pnlInProcess_DragDrop);
            this.pnlInProcess.DragOver += new DragEventHandler(pnlInProcess_DragOver);
            this.pnltask.DragOver += new DragEventHandler(pnltask_DragDrop);
            this.pnltask.DragOver += new DragEventHandler(pnltask_DragOver);

        }

        private void cboxProje_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnltask.Controls.Clear();
            int i = 0, j = 0;
            baglanti.Open();
            SqlDataReader taskoku = verioku("select Task.Konu,Task.Yazilimci,Story.Renk,Story.Renk_R,Story.Renk_G,Story.Renk_B from Task inner join Story on Task.StoryNu=Story.NU inner join Proje on Story.ProjeNu=Proje.NU where Proje.Adi='" + cboxProje.Text.ToString() + "' ");
            while (taskoku.Read())
            {
                Button btn = new Button();
                btn.Text = taskoku["Konu"].ToString() + "   " + taskoku["Yazilimci"].ToString();
                btn.Size = new Size(90, 90);
                btn.Location = new Point(i * 1, j * 1);
                btn.BackColor = Color.FromArgb(Int32.Parse(taskoku["Renk"].ToString()), Int32.Parse(taskoku["Renk_R"].ToString()), Int32.Parse(taskoku["Renk_G"].ToString()), Int32.Parse(taskoku["Renk_B"].ToString()));
                pnltask.Controls.Add(btn);
                btn.MouseDown += new MouseEventHandler(btn_MouseDown);
                btn.AllowDrop = true;
                i += 90;
                if (i == 180)
                {
                    i = 0;
                    j += 90;
                }
            }
            baglanti.Close();
        }
        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            /* isdragged = true;
             ((Button)sender).Cursor = Cursors.Hand;
             ptoffset = e.Location;
            if (e.Button==MouseButtons.Left)
            {
                ((Button)sender).DoDragDrop(((Button)sender), DragDropEffects.All);
            }*/
            Button b = sender as Button;
            b.DoDragDrop(b, DragDropEffects.Move);

        }

        private void pnlDone_DragDrop(object sender, DragEventArgs e)
        {
            Button b = e.Data.GetData(e.Data.GetFormats()[0]) as Button;
            if (b != null)
            {
                b.Location = this.pnlDone.PointToClient(new Point(e.X, e.Y));
                this.pnlDone.Controls.Add(b);
            }
        }

        private void pnlDone_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pnlInProcess_DragDrop(object sender, DragEventArgs e)
        {
            Button b = e.Data.GetData(e.Data.GetFormats()[0]) as Button;
            if (b != null)
            {
                b.Location = this.pnlInProcess.PointToClient(new Point(e.X, e.Y));
                this.pnlInProcess.Controls.Add(b);
            }
        }

        private void pnlToDo_DragDrop(object sender, DragEventArgs e)
        {
            Button b = e.Data.GetData(e.Data.GetFormats()[0]) as Button;
            if (b != null)
            {
                b.Location = this.pnlToDo.PointToClient(new Point(e.X, e.Y));
                this.pnlToDo.Controls.Add(b);
            }
        }



        private void pnlInProcess_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pnlToDo_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pnltask_DragDrop(object sender, DragEventArgs e)
        {
            Button b = e.Data.GetData(e.Data.GetFormats()[0]) as Button;
            if (b != null)
            {
                b.Location = this.pnltask.PointToClient(new Point(e.X, e.Y));
                this.pnltask.Controls.Add(b);
            }
        }

        private void pnltask_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
    

