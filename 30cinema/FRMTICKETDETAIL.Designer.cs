
namespace _30cinema
{
    partial class FRMTICKETDETAIL
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
            this.dgvTotalList = new System.Windows.Forms.DataGridView();
            this.dgvFilteredList = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblToplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTotalList
            // 
            this.dgvTotalList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotalList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTotalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalList.Location = new System.Drawing.Point(12, 12);
            this.dgvTotalList.Name = "dgvTotalList";
            this.dgvTotalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTotalList.Size = new System.Drawing.Size(786, 158);
            this.dgvTotalList.TabIndex = 0;
            // 
            // dgvFilteredList
            // 
            this.dgvFilteredList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilteredList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFilteredList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilteredList.Location = new System.Drawing.Point(12, 202);
            this.dgvFilteredList.Name = "dgvFilteredList";
            this.dgvFilteredList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilteredList.Size = new System.Drawing.Size(786, 150);
            this.dgvFilteredList.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Gray;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToplam.Location = new System.Drawing.Point(12, 355);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(18, 20);
            this.lblToplam.TabIndex = 5;
            this.lblToplam.Text = "0";
            // 
            // FRMTICKETDETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 544);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvFilteredList);
            this.Controls.Add(this.dgvTotalList);
            this.Name = "FRMTICKETDETAIL";
            this.Text = "FRMTICKETDETAIL";
            this.Load += new System.EventHandler(this.FRMTICKETDETAIL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTotalList;
        private System.Windows.Forms.DataGridView dgvFilteredList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblToplam;
    }
}