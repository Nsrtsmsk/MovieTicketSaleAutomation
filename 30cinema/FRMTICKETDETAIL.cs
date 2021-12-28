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
    public partial class FRMTICKETDETAIL : Form
    {
        CinemaaEntities db = new CinemaaEntities();
        public FRMTICKETDETAIL()
        {
            InitializeComponent();
        }
        private void FillUp()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("BİLET NUMARASI");
            dt.Columns.Add("ÖDEME TÜRÜ");
            dt.Columns.Add("TUTAR");
            dt.Columns.Add("İŞLEM TARİHİ");
            foreach (var item in db.TICKETDETAILS.ToList())
            {
                DataRow dr = dt.NewRow();
                dr[0] = item.ID;
                dr[1] = item.TICKETID;
                dr[2] = item.PAYMENTTYPE==true?"Nakit":"Kredi Kartı";
                dr[3] = item.PAYMENTTOTAL;
                dr[4] = item.DATE;
                dt.Rows.Add(dr);
            }
            dgvTotalList.DataSource = dt;
            
        }

        
        private void FRMTICKETDETAIL_Load(object sender, EventArgs e)
        {
            FillUp();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Decimal CiroToplam = 0;
            string AA = dateTimePicker1.Text;
            string Tarih = Convert.ToDateTime(AA).ToString("yyyy-MM-dd");
            string SQLSorgu = "Select * From TICKETDETAILS Where DATE = ";
            SQLSorgu = SQLSorgu + "'" + Tarih + "'";
            DataTable dti = new DataTable();
            dti.Columns.Add("ID");
            dti.Columns.Add("BİLET NUMARASI");
            dti.Columns.Add("ÖDEME TÜRÜ");
            dti.Columns.Add("TUTAR");
            dti.Columns.Add("İŞLEM TARİHİ");
            foreach (var item in db.Database.SqlQuery<TICKETDETAILS>(SQLSorgu).ToList())
            {
                DataRow dr = dti.NewRow();
                dr[0] = item.ID;
                dr[1] = item.TICKETID;
                dr[2] = item.PAYMENTTYPE == true ? "Nakit" : "Kredi Kartı";
                dr[3] = item.PAYMENTTOTAL;
                dr[4] = item.DATE;
                CiroToplam+=Convert.ToDecimal( item. PAYMENTTOTAL);
                dti.Rows.Add(dr);
            }
            lblToplam.Text = Convert.ToString (" Günlük Toplam : "+ CiroToplam+ " TL ");

            dgvFilteredList.DataSource = dti;
        }
    }
}
