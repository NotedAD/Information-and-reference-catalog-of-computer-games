namespace Information_and_reference_catalog_of_computer_games
{
    partial class AddGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGames));
            this.save = new System.Windows.Forms.Button();
            this.txt_subtitle = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upload_img = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ageLimit = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_preorder = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_country = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(77, 411);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(203, 36);
            this.save.TabIndex = 13;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // txt_subtitle
            // 
            this.txt_subtitle.Location = new System.Drawing.Point(15, 282);
            this.txt_subtitle.MaxLength = 500;
            this.txt_subtitle.Multiline = true;
            this.txt_subtitle.Name = "txt_subtitle";
            this.txt_subtitle.Size = new System.Drawing.Size(203, 42);
            this.txt_subtitle.TabIndex = 12;
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_title.Location = new System.Drawing.Point(15, 234);
            this.txt_title.MaxLength = 50;
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(203, 26);
            this.txt_title.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Текст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Заголовок";
            // 
            // upload_img
            // 
            this.upload_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upload_img.Location = new System.Drawing.Point(77, 177);
            this.upload_img.Name = "upload_img";
            this.upload_img.Size = new System.Drawing.Size(203, 36);
            this.upload_img.TabIndex = 8;
            this.upload_img.Text = "Загрузить изображение";
            this.upload_img.UseVisualStyleBackColor = true;
            this.upload_img.Click += new System.EventHandler(this.upload_img_Click);
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(77, 6);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(203, 169);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 7;
            this.pb_image.TabStop = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3.Location = new System.Drawing.Point(11, 327);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(89, 16);
            this.lbl3.TabIndex = 14;
            this.lbl3.Text = "Дата выхода";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl4.Location = new System.Drawing.Point(235, 217);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(40, 16);
            this.lbl4.TabIndex = 16;
            this.lbl4.Text = "Цена";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_price.Location = new System.Drawing.Point(238, 234);
            this.txt_price.MaxLength = 5;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(110, 26);
            this.txt_price.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(235, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Возрастное \r\nограничение\r\n";
            // 
            // txt_ageLimit
            // 
            this.txt_ageLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_ageLimit.Location = new System.Drawing.Point(238, 298);
            this.txt_ageLimit.MaxLength = 2;
            this.txt_ageLimit.Name = "txt_ageLimit";
            this.txt_ageLimit.Size = new System.Drawing.Size(110, 26);
            this.txt_ageLimit.TabIndex = 20;
            // 
            // txt_date
            // 
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_date.Location = new System.Drawing.Point(14, 346);
            this.txt_date.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(97, 20);
            this.txt_date.TabIndex = 21;
            this.txt_date.Value = new System.DateTime(2023, 2, 15, 0, 0, 0, 0);
            this.txt_date.ValueChanged += new System.EventHandler(this.txt_date_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(111, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Предзаказ";
            // 
            // txt_preorder
            // 
            this.txt_preorder.AutoSize = true;
            this.txt_preorder.Location = new System.Drawing.Point(114, 346);
            this.txt_preorder.Name = "txt_preorder";
            this.txt_preorder.Size = new System.Drawing.Size(123, 30);
            this.txt_preorder.TabIndex = 23;
            this.txt_preorder.Text = "Можно ли сделать \r\nпредзаказ";
            this.txt_preorder.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Страна происохждения\r\n";
            // 
            // txt_country
            // 
            this.txt_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_country.Location = new System.Drawing.Point(170, 373);
            this.txt_country.MaxLength = 100;
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(178, 26);
            this.txt_country.TabIndex = 25;
            // 
            // AddGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_preorder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_ageLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.save);
            this.Controls.Add(this.txt_subtitle);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upload_img);
            this.Controls.Add(this.pb_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddGames";
            this.Text = "Добавить/изменить игру";
            this.Load += new System.EventHandler(this.AddGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox txt_subtitle;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button upload_img;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ageLimit;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox txt_preorder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_country;
    }
}