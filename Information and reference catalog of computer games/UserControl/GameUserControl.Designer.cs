namespace Information_and_reference_catalog_of_computer_games
{
    partial class GameUserControl
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
            this.pb_gameIcon = new System.Windows.Forms.PictureBox();
            this.gm_name = new System.Windows.Forms.Label();
            this.gm_price = new System.Windows.Forms.Label();
            this.gm_desctription = new System.Windows.Forms.Label();
            this.gm_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_gameIcon
            // 
            this.pb_gameIcon.Location = new System.Drawing.Point(34, 5);
            this.pb_gameIcon.Name = "pb_gameIcon";
            this.pb_gameIcon.Size = new System.Drawing.Size(84, 90);
            this.pb_gameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_gameIcon.TabIndex = 0;
            this.pb_gameIcon.TabStop = false;
            this.pb_gameIcon.Click += new System.EventHandler(this.pb_gameIcon_Click);
            this.pb_gameIcon.MouseEnter += new System.EventHandler(this.pb_gameIcon_MouseEnter);
            // 
            // gm_name
            // 
            this.gm_name.AutoEllipsis = true;
            this.gm_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gm_name.Location = new System.Drawing.Point(15, 98);
            this.gm_name.MaximumSize = new System.Drawing.Size(120, 20);
            this.gm_name.Name = "gm_name";
            this.gm_name.Size = new System.Drawing.Size(120, 18);
            this.gm_name.TabIndex = 1;
            this.gm_name.Text = "Name\r\n";
            this.gm_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gm_name.Click += new System.EventHandler(this.gm_name_Click);
            this.gm_name.MouseEnter += new System.EventHandler(this.gm_name_MouseEnter);
            // 
            // gm_price
            // 
            this.gm_price.AutoSize = true;
            this.gm_price.Location = new System.Drawing.Point(11, 219);
            this.gm_price.Name = "gm_price";
            this.gm_price.Size = new System.Drawing.Size(31, 13);
            this.gm_price.TabIndex = 2;
            this.gm_price.Text = "Price";
            this.gm_price.Click += new System.EventHandler(this.gm_price_Click);
            this.gm_price.MouseEnter += new System.EventHandler(this.gm_price_MouseEnter);
            // 
            // gm_desctription
            // 
            this.gm_desctription.AutoEllipsis = true;
            this.gm_desctription.AutoSize = true;
            this.gm_desctription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gm_desctription.Location = new System.Drawing.Point(8, 126);
            this.gm_desctription.MaximumSize = new System.Drawing.Size(140, 60);
            this.gm_desctription.Name = "gm_desctription";
            this.gm_desctription.Size = new System.Drawing.Size(48, 15);
            this.gm_desctription.TabIndex = 3;
            this.gm_desctription.Text = "Subtitle\r\n";
            this.gm_desctription.Click += new System.EventHandler(this.gm_desctription_Click);
            this.gm_desctription.MouseEnter += new System.EventHandler(this.gm_desctription_MouseEnter);
            // 
            // gm_date
            // 
            this.gm_date.AutoSize = true;
            this.gm_date.Location = new System.Drawing.Point(74, 219);
            this.gm_date.Name = "gm_date";
            this.gm_date.Size = new System.Drawing.Size(30, 13);
            this.gm_date.TabIndex = 4;
            this.gm_date.Text = "Date";
            this.gm_date.Click += new System.EventHandler(this.gm_date_Click);
            this.gm_date.MouseEnter += new System.EventHandler(this.gm_date_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата выхода";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цена";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(154, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 236);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 2);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 234);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(2, 234);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 2);
            this.panel4.TabIndex = 10;
            // 
            // GameUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gm_date);
            this.Controls.Add(this.gm_desctription);
            this.Controls.Add(this.gm_price);
            this.Controls.Add(this.gm_name);
            this.Controls.Add(this.pb_gameIcon);
            this.Name = "GameUserControl";
            this.Size = new System.Drawing.Size(156, 236);
            this.MouseEnter += new System.EventHandler(this.GameUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.GameUserControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pb_gameIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_gameIcon;
        private System.Windows.Forms.Label gm_name;
        private System.Windows.Forms.Label gm_price;
        private System.Windows.Forms.Label gm_desctription;
        private System.Windows.Forms.Label gm_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
