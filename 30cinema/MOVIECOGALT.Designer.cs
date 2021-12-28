
namespace _30cinema
{
    partial class MOVIECOGALT
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
            this.cbMovieName = new System.Windows.Forms.ComboBox();
            this.cbHall = new System.Windows.Forms.ComboBox();
            this.cbSeans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMovieName
            // 
            this.cbMovieName.FormattingEnabled = true;
            this.cbMovieName.Location = new System.Drawing.Point(147, 62);
            this.cbMovieName.Margin = new System.Windows.Forms.Padding(4);
            this.cbMovieName.Name = "cbMovieName";
            this.cbMovieName.Size = new System.Drawing.Size(361, 26);
            this.cbMovieName.TabIndex = 0;
            // 
            // cbHall
            // 
            this.cbHall.FormattingEnabled = true;
            this.cbHall.Location = new System.Drawing.Point(147, 174);
            this.cbHall.Margin = new System.Windows.Forms.Padding(4);
            this.cbHall.Name = "cbHall";
            this.cbHall.Size = new System.Drawing.Size(361, 26);
            this.cbHall.TabIndex = 1;
            // 
            // cbSeans
            // 
            this.cbSeans.FormattingEnabled = true;
            this.cbSeans.Location = new System.Drawing.Point(147, 273);
            this.cbSeans.Margin = new System.Windows.Forms.Padding(4);
            this.cbSeans.Name = "cbSeans";
            this.cbSeans.Size = new System.Drawing.Size(361, 26);
            this.cbSeans.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gösterilecek Salon";
            // 
            // dgvlist
            // 
            this.dgvlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlist.Location = new System.Drawing.Point(543, 62);
            this.dgvlist.Margin = new System.Windows.Forms.Padding(4);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlist.Size = new System.Drawing.Size(639, 490);
            this.dgvlist.TabIndex = 4;
            this.dgvlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlist_CellDoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(150, 334);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 32);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gösterilecek Film";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gösterilecek Seans";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(150, 373);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 32);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(150, 411);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 32);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // MOVIECOGALT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSeans);
            this.Controls.Add(this.cbHall);
            this.Controls.Add(this.cbMovieName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MOVIECOGALT";
            this.Text = "MOVIECOGALT";
            this.Load += new System.EventHandler(this.MOVIECOGALT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMovieName;
        private System.Windows.Forms.ComboBox cbHall;
        private System.Windows.Forms.ComboBox cbSeans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}