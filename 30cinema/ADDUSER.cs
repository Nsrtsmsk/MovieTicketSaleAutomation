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
    public partial class ADDUSER : Form
    {
        int clickid = 0;
        CinemaaEntities db = new CinemaaEntities();
        public ADDUSER()
        {
            InitializeComponent();
        }

        private void ADDUSER_Load(object sender, EventArgs e)
        {
            Fill();
        }
        private void Fill()
        {


            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Kullanıcı Adı");
            dt.Columns.Add("Sifre");
            foreach (var item in db.USER.ToList() )
            {
                DataRow dr = dt.NewRow();
                dr[0] = item.ID;
                dr[1] = item.NAME;
                dr[2] = item.PASSWORD;
                dt.Rows.Add(dr);
            }
            dgvList.DataSource = dt;
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUser.Text = dgvList.Rows[e.RowIndex].Cells[1].Value.ToString();
            clickid = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtPass.Text = dgvList.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            USER U = new USER();
            U.NAME = txtUser.Text;
            U.PASSWORD = txtPass.Text;
            db.USER.Add(U);
            db.SaveChanges();
            Fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            USER U = db.USER.Find(clickid);
            U.ID = clickid;
            U.NAME = txtUser.Text;
            U.PASSWORD = txtPass.Text;
            db.SaveChanges();
            Fill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            USER U  = db.USER.Find(clickid);
            db.USER.Remove(U);
            db.SaveChanges();
            Fill();
            clickid = 0;
        }
    }
}
