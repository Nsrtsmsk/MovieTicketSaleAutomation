
namespace _30cinema
{
    partial class ADDMOVIE
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
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDesription = new System.Windows.Forms.TextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.dgvMovieList = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.rbGosterimde = new System.Windows.Forms.RadioButton();
            this.rbgosterimdedegil = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(946, 40);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(367, 22);
            this.txtMovieName.TabIndex = 1;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(946, 90);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(367, 22);
            this.txtDirector.TabIndex = 1;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(946, 143);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(367, 22);
            this.txtGenre.TabIndex = 1;
            // 
            // txtDesription
            // 
            this.txtDesription.Location = new System.Drawing.Point(946, 193);
            this.txtDesription.Multiline = true;
            this.txtDesription.Name = "txtDesription";
            this.txtDesription.Size = new System.Drawing.Size(367, 147);
            this.txtDesription.TabIndex = 1;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(946, 362);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(263, 22);
            this.txtImage.TabIndex = 1;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(946, 418);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(367, 22);
            this.txtDuration.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(943, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(943, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yönetmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(943, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(943, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(943, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Afiş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(943, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Süre/Dk";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(946, 562);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(161, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(1152, 562);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(161, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(1227, 359);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(86, 25);
            this.btnImage.TabIndex = 4;
            this.btnImage.Text = "Seç";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // dgvMovieList
            // 
            this.dgvMovieList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovieList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieList.Location = new System.Drawing.Point(12, 69);
            this.dgvMovieList.Name = "dgvMovieList";
            this.dgvMovieList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovieList.Size = new System.Drawing.Size(886, 545);
            this.dgvMovieList.TabIndex = 7;
            this.dgvMovieList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovieList_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(946, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gösterim";
            // 
            // rbGosterimde
            // 
            this.rbGosterimde.AutoSize = true;
            this.rbGosterimde.Location = new System.Drawing.Point(946, 477);
            this.rbGosterimde.Name = "rbGosterimde";
            this.rbGosterimde.Size = new System.Drawing.Size(96, 20);
            this.rbGosterimde.TabIndex = 9;
            this.rbGosterimde.TabStop = true;
            this.rbGosterimde.Text = "Gösterimde";
            this.rbGosterimde.UseVisualStyleBackColor = true;
            // 
            // rbgosterimdedegil
            // 
            this.rbgosterimdedegil.AutoSize = true;
            this.rbgosterimdedegil.Location = new System.Drawing.Point(1053, 477);
            this.rbgosterimdedegil.Name = "rbgosterimdedegil";
            this.rbgosterimdedegil.Size = new System.Drawing.Size(131, 20);
            this.rbgosterimdedegil.TabIndex = 9;
            this.rbgosterimdedegil.TabStop = true;
            this.rbgosterimdedegil.Text = "Gösterimde Değil";
            this.rbgosterimdedegil.UseVisualStyleBackColor = true;
            // 
            // ADDMOVIE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 634);
            this.Controls.Add(this.rbgosterimdedegil);
            this.Controls.Add(this.rbGosterimde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvMovieList);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtDesription);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtMovieName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ADDMOVIE";
            this.Text = "ADDMOVIE";
            this.Load += new System.EventHandler(this.ADDMOVIE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtDesription;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.DataGridView dgvMovieList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbGosterimde;
        private System.Windows.Forms.RadioButton rbgosterimdedegil;
    }
}