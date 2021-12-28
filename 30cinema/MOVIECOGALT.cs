using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30cinema
{
    public partial class MOVIECOGALT : Form
    {
        CinemaaEntities db = new CinemaaEntities();
        int Alinanid = 0;

        public MOVIECOGALT()
        {
            InitializeComponent();
        }

        private void MOVIECOGALT_Load(object sender, EventArgs e)
        {
            Fill();
            cbHall.ValueMember = "ID";
            cbHall.DisplayMember = "HALLNAME";
            cbHall.DataSource = db.HALL.ToList();
            cbSeans.ValueMember = "ID";
            cbSeans.DisplayMember = "SESSIONTIME";
            cbSeans.DataSource = db.SESSION.ToList();
            cbMovieName.ValueMember = "ID";
            cbMovieName.DisplayMember = "MOVIENAME";
            cbMovieName.DataSource = db.MOVIE.ToList();


            
        }

        private void Fill()
        {
            if (db.MHS!=null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Film Adı");
                dt.Columns.Add("Salon");
                dt.Columns.Add("Seans");
                foreach (var item in db.MHS.ToList())
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = item.ID;
                    dr[1] = item.MOVIE.MOVIENAME;
                    dr[2] = item.HALL.HALLNAME;
                    dr[3] = item.SESSION.SESSIONTIME;
                    dt.Rows.Add(dr);
                }


                dgvlist.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Ayarlanmış bir gösterim bulunmuyor!");
            }


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (db.MHS.Any(x=>x.HALLID== (int)cbHall.SelectedValue && x.SESSIONID== (int)cbSeans.SelectedValue))
            {
                MessageBox.Show("Seçilen Seans ve Salonda başka bir gösterim bulunmaktadır!");
            }
            else
            {
                MHS m = new MHS();
                int halls = (int)cbHall.SelectedValue;
                int ses = (int)cbSeans.SelectedValue;
                int mov = (int)cbMovieName.SelectedValue;
                m.HALLID = halls;
                m.MOVIEID = mov;
                m.SESSIONID = ses;
                db.MHS.Add(m);
                db.SaveChanges();
                Fill();
            }

        }

        private void dgvlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Alinanid=int.Parse( dgvlist.Rows[e.RowIndex].Cells[0].Value.ToString());
            cbMovieName.Text = dgvlist.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbHall.Text= dgvlist.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbSeans.Text= dgvlist.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Alinanid!=0)
            {
                MHS m = db.MHS.Find(Alinanid);
                int halls = (int)cbHall.SelectedValue;
                int ses = (int)cbSeans.SelectedValue;
                int mov = (int)cbMovieName.SelectedValue;
                m.HALLID = halls;
                m.MOVIEID = mov;
                m.SESSIONID = ses;
                db.SaveChanges();
                Fill();
            }



        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Alinanid!=0)
            {
                MHS m = db.MHS.Find(Alinanid);
                db.MHS.Remove(m);
                db.SaveChanges();
                Fill();
                Alinanid = 0;
            }
          


        }
    }
}
