namespace TuDien
{
    partial class Opp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opp));
            this.picdemo = new System.Windows.Forms.PictureBox();
            this.picdic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picdemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picdemo
            // 
            this.picdemo.BackColor = System.Drawing.Color.Transparent;
            this.picdemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picdemo.Image = ((System.Drawing.Image)(resources.GetObject("picdemo.Image")));
            this.picdemo.Location = new System.Drawing.Point(420, 306);
            this.picdemo.Name = "picdemo";
            this.picdemo.Size = new System.Drawing.Size(261, 65);
            this.picdemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picdemo.TabIndex = 0;
            this.picdemo.TabStop = false;
            this.picdemo.Click += new System.EventHandler(this.picdemo_Click);
            this.picdemo.MouseEnter += new System.EventHandler(this.picdemo_MouseEnter);
            this.picdemo.MouseLeave += new System.EventHandler(this.picdemo_MouseLeave);
            // 
            // picdic
            // 
            this.picdic.BackColor = System.Drawing.Color.Transparent;
            this.picdic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picdic.Image = ((System.Drawing.Image)(resources.GetObject("picdic.Image")));
            this.picdic.Location = new System.Drawing.Point(339, 366);
            this.picdic.Name = "picdic";
            this.picdic.Size = new System.Drawing.Size(404, 71);
            this.picdic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picdic.TabIndex = 1;
            this.picdic.TabStop = false;
            this.picdic.Click += new System.EventHandler(this.picdic_Click);
            this.picdic.MouseEnter += new System.EventHandler(this.picdic_MouseEnter);
            this.picdic.MouseLeave += new System.EventHandler(this.picdic_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(703, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 115);
            this.label1.TabIndex = 3;
            this.label1.Text = "GVHD: Thầy Nguyễn Thiên Bảo\r\nSVTH:\r\n         Nguyễn Văn Huy   18110123\r\n         " +
    "Phan Chí Cường    16110030\r\n         Lê Hoàng Tuấn      18110226";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(359, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Opp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 671);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picdic);
            this.Controls.Add(this.picdemo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opp";
            this.Load += new System.EventHandler(this.Opp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picdemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picdemo;
        private System.Windows.Forms.PictureBox picdic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}