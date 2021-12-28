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
    public partial class ADDMOVIE : Form
    {
        CinemaaEntities db = new CinemaaEntities();
       
        int clickID = 0;
        public ADDMOVIE()
        {
            InitializeComponent();
        }

        private void ADDMOVIE_Load(object sender, EventArgs e)
        {

            Fill();

            dgvMovieList.Rows[0].Cells[0].Selected = false;
        }



        public void Fill()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Film");
            dt.Columns.Add("Yönetmen");
            dt.Columns.Add("Tür");
            dt.Columns.Add("Açıklama");
            dt.Columns.Add("Resim");
            dt.Columns.Add("Süre");
            dt.Columns.Add("Gösterim");
           

            foreach (var item in db.MOVIE.ToList())
            {
                DataRow dr = dt.NewRow();
                dr[0] = item.ID;
                dr[1] = item.MOVIENAME;
                dr[2] = item.DIRECTOR;
                dr[3] = item.GENRE;
                dr[4] = item.DESCRIPTION;
                dr[5] = item.IMAGE;
                dr[6] = item.DURATION;
                dr[7] = item.STATUS;
               
                dt.Rows.Add(dr);


            }
            dgvMovieList.DataSource = dt;


        }

        private void dgvMovieList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtMovieName.Text = dgvMovieList.Rows[e.RowIndex].Cells[1].Value.ToString();
                clickID= Convert.ToInt32( dgvMovieList.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtDirector.Text= dgvMovieList.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGenre.Text= dgvMovieList.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDesription.Text = dgvMovieList.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtImage.Text = dgvMovieList.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDuration.Text = dgvMovieList.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (Convert.ToBoolean(dgvMovieList.Rows[e.RowIndex].Cells[7].Value) ==true)
                {
                    rbGosterimde.Checked = true;
                }
                else
                {
                    rbgosterimdedegil.Checked = true;
                }
            }





        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "PNG DOSYASI|*.png";
            op.ShowDialog();
            txtImage.Text = op.FileName.ToString();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMovieName.Text != "" && rbGosterimde.Checked ? true : false&&txtDirector.Text!=""&&txtGenre.Text!=""&&txtDesription.Text!=""&&txtImage.Text!=""&&txtDuration.Text!="")
            {
                MOVIE m = new MOVIE();

                m.STATUS = (rbGosterimde.Checked) ? true : false;
                m.MOVIENAME = txtMovieName.Text;
                m.DIRECTOR = txtDirector.Text;
                m.GENRE = txtGenre.Text;
                m.DESCRIPTION = txtDesription.Text;
                m.IMAGE = txtImage.Text;
                m.DURATION = txtDuration.Text;
                db.MOVIE.Add(m);
                db.SaveChanges();
                MessageBox.Show("İşlem Başarılı");
                Fill();
            }

            else
            {
                MessageBox.Show("Boş Bırakılan Alanları Doldurunuz!");
            }


            

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (clickID != 0)
            {
                MOVIE mhs = db.MOVIE.Find(clickID);
                mhs.MOVIENAME = txtMovieName.Text;
                mhs.DIRECTOR = txtDirector.Text;
                mhs.GENRE = txtGenre.Text;
                mhs.DESCRIPTION = txtDesription.Text;
                mhs.IMAGE = txtImage.Text;
                mhs.DURATION = txtDuration.Text;
                mhs.STATUS = rbGosterimde.Checked ? true : false;
              
                db.SaveChanges();
                MessageBox.Show("İşlem Başarılı");
                Fill();
            }
        }
    }
}
