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
    public partial class LOGIN : Form
    {

        CinemaaEntities db = new CinemaaEntities();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

           



        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String kulad = txtUserName.Text;
            string sifre = txtPassword.Text;

            if (db.USER.Any(x=>x.NAME==kulad&&x.PASSWORD==sifre))
            {
                Properties.Settings.Default.USERID = db.USER.Where(x => x.NAME == kulad && x.PASSWORD == sifre).FirstOrDefault().ID;
                // Kayıt İşleminin tamamlanması lazım
                Properties.Settings.Default.Save();
                MessageBox.Show("Giriş Başarılı");
                ENMAIN m = new ENMAIN();
                this.Hide();
                m.Show();


            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız");
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
