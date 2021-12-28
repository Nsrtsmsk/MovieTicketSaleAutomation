
namespace _30cinema
{
    partial class MAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("A1", 0);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("A2", 0);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("A3", 0);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("A4", 0);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("B1", 0);
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("B2", 0);
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("B3", 0);
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("B4", 0);
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("C1", 0);
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("C2", 0);
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("C3", 0);
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("C4", 0);
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("D1", 0);
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem("D2", 0);
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem("D3", 0);
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem("D4", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.lvSeat = new System.Windows.Forms.ListView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMovie = new System.Windows.Forms.ComboBox();
            this.cbSession = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHall = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecilenKoltuk1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBiletSat = new System.Windows.Forms.Button();
            this.btnKoltukGetir = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.rbKredi = new System.Windows.Forms.RadioButton();
            this.pbMovies = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // lvSeat
            // 
            this.lvSeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSeat.HideSelection = false;
            this.lvSeat.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29,
            listViewItem30,
            listViewItem31,
            listViewItem32});
            this.lvSeat.LargeImageList = this.ımageList1;
            this.lvSeat.Location = new System.Drawing.Point(3, 16);
            this.lvSeat.Name = "lvSeat";
            this.lvSeat.Size = new System.Drawing.Size(448, 549);
            this.lvSeat.SmallImageList = this.ımageList1;
            this.lvSeat.TabIndex = 0;
            this.lvSeat.UseCompatibleStateImageBehavior = false;
            this.lvSeat.DoubleClick += new System.EventHandler(this.lvSeat_DoubleClick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "BOSKOLTUK.png");
            this.ımageList1.Images.SetKeyName(1, "DOLUKOLTUK.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvSeat);
            this.groupBox1.Location = new System.Drawing.Point(59, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 568);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Koltuk Seçimi";
            // 
            // cbMovie
            // 
            this.cbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMovie.FormattingEnabled = true;
            this.cbMovie.Location = new System.Drawing.Point(528, 89);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(256, 28);
            this.cbMovie.TabIndex = 2;
            this.cbMovie.SelectedIndexChanged += new System.EventHandler(this.cbMovie_SelectedIndexChanged);
            // 
            // cbSession
            // 
            this.cbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSession.FormattingEnabled = true;
            this.cbSession.Location = new System.Drawing.Point(528, 141);
            this.cbSession.Name = "cbSession";
            this.cbSession.Size = new System.Drawing.Size(256, 28);
            this.cbSession.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(528, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seans";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(528, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Film Adı";
            // 
            // cbHall
            // 
            this.cbHall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbHall.FormattingEnabled = true;
            this.cbHall.Location = new System.Drawing.Point(528, 193);
            this.cbHall.Name = "cbHall";
            this.cbHall.Size = new System.Drawing.Size(256, 28);
            this.cbHall.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(528, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salon";
            // 
            // txtSecilenKoltuk1
            // 
            this.txtSecilenKoltuk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecilenKoltuk1.Location = new System.Drawing.Point(528, 245);
            this.txtSecilenKoltuk1.Name = "txtSecilenKoltuk1";
            this.txtSecilenKoltuk1.ReadOnly = true;
            this.txtSecilenKoltuk1.Size = new System.Drawing.Size(256, 24);
            this.txtSecilenKoltuk1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(527, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Secilen Koltuk";
            // 
            // btnBiletSat
            // 
            this.btnBiletSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletSat.Location = new System.Drawing.Point(531, 401);
            this.btnBiletSat.Name = "btnBiletSat";
            this.btnBiletSat.Size = new System.Drawing.Size(253, 67);
            this.btnBiletSat.TabIndex = 9;
            this.btnBiletSat.Text = "Satış Onay";
            this.btnBiletSat.UseVisualStyleBackColor = true;
            this.btnBiletSat.Click += new System.EventHandler(this.btnBiletSat_Click);
            // 
            // btnKoltukGetir
            // 
            this.btnKoltukGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKoltukGetir.Location = new System.Drawing.Point(531, 346);
            this.btnKoltukGetir.Name = "btnKoltukGetir";
            this.btnKoltukGetir.Size = new System.Drawing.Size(253, 49);
            this.btnKoltukGetir.TabIndex = 10;
            this.btnKoltukGetir.Text = "Koltuk Getir - Yenile";
            this.btnKoltukGetir.UseVisualStyleBackColor = true;
            this.btnKoltukGetir.Click += new System.EventHandler(this.btnKoltukGetir_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(732, 272);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(13, 18);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(651, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "ÜCRET :";
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNakit.Location = new System.Drawing.Point(531, 310);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(60, 22);
            this.rbNakit.TabIndex = 13;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            // 
            // rbKredi
            // 
            this.rbKredi.AutoSize = true;
            this.rbKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKredi.Location = new System.Drawing.Point(654, 310);
            this.rbKredi.Name = "rbKredi";
            this.rbKredi.Size = new System.Drawing.Size(94, 22);
            this.rbKredi.TabIndex = 14;
            this.rbKredi.TabStop = true;
            this.rbKredi.Text = "Kredi Kartı";
            this.rbKredi.UseVisualStyleBackColor = true;
            // 
            // pbMovies
            // 
            this.pbMovies.ImageLocation = "";
            this.pbMovies.Location = new System.Drawing.Point(851, 63);
            this.pbMovies.Name = "pbMovies";
            this.pbMovies.Size = new System.Drawing.Size(260, 387);
            this.pbMovies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMovies.TabIndex = 15;
            this.pbMovies.TabStop = false;
            // 
            // MAIN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1134, 626);
            this.Controls.Add(this.pbMovies);
            this.Controls.Add(this.rbKredi);
            this.Controls.Add(this.rbNakit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnKoltukGetir);
            this.Controls.Add(this.btnBiletSat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSecilenKoltuk1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbHall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSession);
            this.Controls.Add(this.cbMovie);
            this.Controls.Add(this.groupBox1);
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MAIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSeat;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMovie;
        private System.Windows.Forms.ComboBox cbSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecilenKoltuk1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBiletSat;
        private System.Windows.Forms.Button btnKoltukGetir;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.RadioButton rbKredi;
        private System.Windows.Forms.PictureBox pbMovies;
    }
}