﻿
namespace SearchingBooksDatabase
{
    partial class frmBooks
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBooks
            // 
            this.grdBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooks.Location = new System.Drawing.Point(5, 7);
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.RowTemplate.Height = 25;
            this.grdBooks.Size = new System.Drawing.Size(685, 211);
            this.grdBooks.TabIndex = 0;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(453, 297);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(230, 25);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "Show All Records";
            this.btnAll.Click += new System.EventHandler(this.btnSQL_Click);
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 325);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.grdBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBooks_FormClosing);
            this.Load += new System.EventHandler(this.frmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.Button btnAll;
    }
}

