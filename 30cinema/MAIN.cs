using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _30cinema.Enums;
using System.Collections.Generic;

namespace _30cinema
{
    public partial class MAIN : Form
    {
        CinemaaEntities db = new CinemaaEntities();
        public MAIN()
        {
            InitializeComponent();
        }
        private void CBFill()
        {
                cbMovie.ValueMember = "ID";
                cbMovie.DisplayMember = "MOVIENAME";
                cbMovie.DataSource = db.MOVIE.Where(x=>x.STATUS==true).ToList();
            if (cbMovie.SelectedItem != null)
            {
                FillSession();
            } 
             
            if (cbMovie.SelectedItem != null && cbSession.SelectedItem!=null)
            {
                FillHall();
            } 



        }

        private void MAIN_Load(object sender, EventArgs e)
        {
            CBFill();
            
        }
        private void lvSeat_DoubleClick(object sender, EventArgs e)
        {
            string secilen1 = lvSeat.SelectedItems[0].Text;


            if (txtSecilenKoltuk1.Text!=null)
            {
                if (lvSeat.SelectedItems[0].ImageIndex == 0)
                {
                    SEAT se = new SEAT();
                    lvSeat.SelectedItems[0].ImageIndex = 1;
                    txtSecilenKoltuk1.Text = secilen1;
                    lblPrice.Text = db.SEAT.Where(X => X.SEATNO == secilen1).First().PRICE.ToString();

                }
                else
                {
                    //lvSeat.SelectedItems[0].ImageIndex = 0;
                    //txtSecilenKoltuk1.Text = "";
                    //lblPrice.Text = "";
                    MessageBox.Show("Başka Koltuk seçiniz ya da koltuk planını güncelleyiniz.","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    lblPrice.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Her İşlemde Sadece Tek Koltuk Satılabilir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            int m = (int)cbMovie.SelectedValue;
            int h = (int)cbHall.SelectedValue;
            int s = (int)cbSession.SelectedValue;

            var mhs = db.MHS.FirstOrDefault(X =>
            X.MOVIEID == m &&
            X.HALLID == h &&
            X.SESSIONID == s);
            if (mhs != null)
            {
                int mhsID = mhs.ID;
                var selectedSeat = txtSecilenKoltuk1.Text;

                MHSS mhss = new MHSS()
                {
                    MHSID = mhsID,
                    SEATNO = selectedSeat
                };
                db.MHSS.Add(mhss);

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Koltuk Seçildi.", ""
                        );

                   
                    TICKET t = new TICKET();
                    t.MHSSID = mhss.ID;
                    t.USERID = Properties.Settings.Default.USERID;
                    db.TICKET.Add(t); 
                    TICKETDETAILS td = new TICKETDETAILS();
                    td.TICKETID = t.ID;
                    td.PAYMENTTOTAL = Convert.ToDecimal(lblPrice.Text);
                    td.PAYMENTTYPE = (rbNakit.Checked)?true:false;
                    td.DATE = DateTime.Now;
                    db.TICKETDETAILS.Add(td);
                    db.SaveChanges();
                    

                }
                else
                {
                    MessageBox.Show("Koltuk Seçimi Başarısız!", "");
                }

            }


        }

        private void btnKoltukGetir_Click(object sender, EventArgs e)
        {
             
            int m = (int)cbMovie.SelectedValue;
            int h = (int)cbHall.SelectedValue;
            int s = (int)cbSession.SelectedValue;

            var mhs = db.MHS.FirstOrDefault(X =>
            X.MOVIEID == m &&
            X.HALLID == h &&
            X.SESSIONID == s);

            if (mhs != null)
            {
                int mhsID = mhs.ID;

                List<MHSS> mhssList = db.MHSS.Where(i => i.MHSID == mhsID).ToList();

                for (int i = 0; i < lvSeat.Items.Count; i++)
                {
                    lvSeat.Items[i].ImageIndex = 0;
                }                   


                foreach (var mhss in mhssList)
                {
                    for (int i = 0; i < lvSeat.Items.Count; i++)
                    {
                        if (lvSeat.Items[i].Text == mhss.SEATNO)
                        {
                            lvSeat.Items[i].ImageIndex = 1;
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtSecilenKoltuk1.Text = "";
        }

        private void cbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenfilm = (int)cbMovie.SelectedValue;

            pbMovies.ImageLocation = db.MOVIE.FirstOrDefault(x => x.ID == secilenfilm).IMAGE;
            FillSession();
            FillHall();

        }

        private void FillSession()
        {
            var mhsList = db.MHS.Where(x => x.MOVIEID == (int?)cbMovie.SelectedValue).ToList();
            if (mhsList != null)
            {
                cbSession.ValueMember = "ID";
                cbSession.DisplayMember = "SESSIONTIME";
                if (cbMovie.SelectedItem != null)
                {
                    cbSession.Enabled = true;
                }

                var sessionIdList = mhsList.Select(x => x.SESSIONID).ToList();


                cbSession.DataSource = db.SESSION.Where(x => sessionIdList.Contains(x.ID)).ToList();              
                
            }
        }

        private void FillHall()
        {
            var mhsList = db.MHS.Where(x => x.MOVIEID == (int?)cbMovie.SelectedValue).ToList();
            if (mhsList != null)
            {
                cbHall.ValueMember = "ID";
                cbHall.DisplayMember = "HALLNAME";
                if (cbMovie.SelectedItem != null)
                {
                    cbHall.Enabled = true;
                }
                var hallIdList = mhsList.GroupBy(x => x.HALL.HALLNAME)
                    .OrderBy(c=>c.Key)
                    .Select(x=>Convert.ToInt32( x.Key)).ToList();

                cbHall.DataSource = db.HALL.Where(x => hallIdList.Contains(x.ID)).ToList();
                 
            }
        }
    }













}






