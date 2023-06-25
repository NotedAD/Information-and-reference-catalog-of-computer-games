namespace Information_and_reference_catalog_of_computer_games
{
    partial class MyUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_subtitle = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pb_icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 118);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pb_icon
            // 
            this.pb_icon.Location = new System.Drawing.Point(3, 24);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(120, 72);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icon.TabIndex = 0;
            this.pb_icon.TabStop = false;
            this.pb_icon.Click += new System.EventHandler(this.pb_icon_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoEllipsis = true;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_title.Location = new System.Drawing.Point(133, 10);
            this.lbl_title.MaximumSize = new System.Drawing.Size(260, 20);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(105, 20);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Заголовок";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            this.lbl_title.MouseHover += new System.EventHandler(this.lbl_title_MouseHover);
            // 
            // lbl_subtitle
            // 
            this.lbl_subtitle.AutoEllipsis = true;
            this.lbl_subtitle.AutoSize = true;
            this.lbl_subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_subtitle.Location = new System.Drawing.Point(134, 34);
            this.lbl_subtitle.MaximumSize = new System.Drawing.Size(260, 55);
            this.lbl_subtitle.Name = "lbl_subtitle";
            this.lbl_subtitle.Size = new System.Drawing.Size(45, 16);
            this.lbl_subtitle.TabIndex = 2;
            this.lbl_subtitle.Text = "Текст";
            this.lbl_subtitle.Click += new System.EventHandler(this.lbl_subtitle_Click);
            this.lbl_subtitle.MouseHover += new System.EventHandler(this.lbl_subtitle_MouseHover);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(286, 99);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(33, 13);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Дата";
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_Click);
            this.lbl_date.MouseHover += new System.EventHandler(this.lbl_date_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(126, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 3);
            this.panel2.TabIndex = 4;
            // 
            // MyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_subtitle);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel1);
            this.Name = "MyUserControl";
            this.Size = new System.Drawing.Size(413, 118);
            this.MouseEnter += new System.EventHandler(this.MyUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MyUserControl_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_subtitle;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Panel panel2;
    }
}
