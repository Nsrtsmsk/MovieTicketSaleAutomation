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
    public partial class ENMAIN : Form
    {
        public ENMAIN()
        {
            InitializeComponent();
        }

        private void bİLETSATIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAIN M = new MAIN();
            AcilacakForm(M);
        }



        private void AcilacakForm(Form AcilmakIstenen)
        {

            bool Durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                
                if (eleman.Name == AcilmakIstenen.Name)
                {
                    
                    Durum = true;
                }
                else
                {
                    eleman.Hide(); 
                    Durum = false;
                }
            }
            
            if (!Durum) 
            {
                AcilmakIstenen.MdiParent = this; 
                AcilmakIstenen.StartPosition = FormStartPosition.CenterScreen;
                AcilmakIstenen.Show(); 
            }

        }

        private void sATIŞDÖKÜMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMTICKETDETAIL t = new FRMTICKETDETAIL();
            AcilacakForm(t);
        }

        private void fİLMEKLEÇIKARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDMOVIE A = new ADDMOVIE();
            AcilacakForm(A);
        }

        private void gÖSTERİMEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MOVIECOGALT M = new MOVIECOGALT();
            AcilacakForm(M);
        }

        private void ENMAIN_Load(object sender, EventArgs e)
        {

        }

        private void kULLANICIİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDUSER A = new ADDUSER();
            AcilacakForm(A);
        }
     

        private void ENMAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
