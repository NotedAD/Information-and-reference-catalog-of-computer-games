namespace Information_and_reference_catalog_of_computer_games
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.news = new System.Windows.Forms.TabPage();
            this.refresh_news = new System.Windows.Forms.Button();
            this.profile_news = new System.Windows.Forms.Panel();
            this.pb_profile = new System.Windows.Forms.PictureBox();
            this.balanceInNews = new System.Windows.Forms.Label();
            this.nameProfile = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_subtitle = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.shop = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_filtr = new System.Windows.Forms.Button();
            this.filt_date = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.profile_games = new System.Windows.Forms.Panel();
            this.balance_in_shop = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name_in_shop = new System.Windows.Forms.Label();
            this.userImage_shop = new System.Windows.Forms.PictureBox();
            this.refresh_games = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_leave_account = new System.Windows.Forms.TabPage();
            this.btnLeaveAcc = new System.Windows.Forms.Button();
            this.refresh_game_in_profile = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.freeBalance = new System.Windows.Forms.Button();
            this.loadImage = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.adminPanel = new System.Windows.Forms.TabPage();
            this.edit_games = new System.Windows.Forms.Button();
            this.delete_games = new System.Windows.Forms.Button();
            this.add_games = new System.Windows.Forms.Button();
            this.edit_news = new System.Windows.Forms.Button();
            this.delete_news = new System.Windows.Forms.Button();
            this.add_news = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.news.SuspendLayout();
            this.profile_news.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.shop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.profile_games.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage_shop)).BeginInit();
            this.btn_leave_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.news);
            this.tabControl1.Controls.Add(this.shop);
            this.tabControl1.Controls.Add(this.btn_leave_account);
            this.tabControl1.Controls.Add(this.adminPanel);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1226, 586);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // news
            // 
            this.news.Controls.Add(this.refresh_news);
            this.news.Controls.Add(this.profile_news);
            this.news.Controls.Add(this.panel1);
            this.news.Controls.Add(this.flowLayoutPanel1);
            this.news.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.news.Location = new System.Drawing.Point(4, 24);
            this.news.Name = "news";
            this.news.Padding = new System.Windows.Forms.Padding(3);
            this.news.Size = new System.Drawing.Size(1218, 558);
            this.news.TabIndex = 0;
            this.news.Text = "Новости";
            this.news.UseVisualStyleBackColor = true;
            // 
            // refresh_news
            // 
            this.refresh_news.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh_news.Location = new System.Drawing.Point(800, 3);
            this.refresh_news.Name = "refresh_news";
            this.refresh_news.Size = new System.Drawing.Size(156, 39);
            this.refresh_news.TabIndex = 5;
            this.refresh_news.Text = "Обновить новости";
            this.refresh_news.UseVisualStyleBackColor = true;
            this.refresh_news.Click += new System.EventHandler(this.refresh_news_Click);
            // 
            // profile_news
            // 
            this.profile_news.BackColor = System.Drawing.Color.Gray;
            this.profile_news.Controls.Add(this.pb_profile);
            this.profile_news.Controls.Add(this.balanceInNews);
            this.profile_news.Controls.Add(this.nameProfile);
            this.profile_news.Controls.Add(this.label7);
            this.profile_news.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_news.Location = new System.Drawing.Point(957, 3);
            this.profile_news.Name = "profile_news";
            this.profile_news.Size = new System.Drawing.Size(258, 40);
            this.profile_news.TabIndex = 6;
            this.profile_news.Click += new System.EventHandler(this.profile_news_Click);
            // 
            // pb_profile
            // 
            this.pb_profile.Image = global::Information_and_reference_catalog_of_computer_games.Properties.Resources.user;
            this.pb_profile.Location = new System.Drawing.Point(5, 3);
            this.pb_profile.Name = "pb_profile";
            this.pb_profile.Size = new System.Drawing.Size(35, 31);
            this.pb_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_profile.TabIndex = 8;
            this.pb_profile.TabStop = false;
            this.pb_profile.Click += new System.EventHandler(this.pb_profile_Click);
            // 
            // balanceInNews
            // 
            this.balanceInNews.AutoSize = true;
            this.balanceInNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceInNews.Location = new System.Drawing.Point(181, 11);
            this.balanceInNews.Name = "balanceInNews";
            this.balanceInNews.Size = new System.Drawing.Size(14, 15);
            this.balanceInNews.TabIndex = 7;
            this.balanceInNews.Text = "1";
            this.balanceInNews.Click += new System.EventHandler(this.balancInNews_Click);
            // 
            // nameProfile
            // 
            this.nameProfile.AutoSize = true;
            this.nameProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProfile.Location = new System.Drawing.Point(45, 11);
            this.nameProfile.Name = "nameProfile";
            this.nameProfile.Size = new System.Drawing.Size(14, 15);
            this.nameProfile.TabIndex = 6;
            this.nameProfile.Text = "1";
            this.nameProfile.Click += new System.EventHandler(this.nameProfile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(109, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ваш баланс:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbl_subtitle);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.pb_icon);
            this.panel1.Location = new System.Drawing.Point(800, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 514);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(148, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Закрыть новость";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_subtitle
            // 
            this.lbl_subtitle.AutoSize = true;
            this.lbl_subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_subtitle.Location = new System.Drawing.Point(7, 209);
            this.lbl_subtitle.MaximumSize = new System.Drawing.Size(410, 200);
            this.lbl_subtitle.Name = "lbl_subtitle";
            this.lbl_subtitle.Size = new System.Drawing.Size(0, 20);
            this.lbl_subtitle.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(19, 161);
            this.lbl_title.MaximumSize = new System.Drawing.Size(400, 50);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 24);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_icon
            // 
            this.pb_icon.Location = new System.Drawing.Point(44, 5);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(330, 153);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon.TabIndex = 0;
            this.pb_icon.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(796, 552);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // shop
            // 
            this.shop.Controls.Add(this.panel2);
            this.shop.Controls.Add(this.profile_games);
            this.shop.Controls.Add(this.refresh_games);
            this.shop.Controls.Add(this.flowLayoutPanel2);
            this.shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shop.Location = new System.Drawing.Point(4, 24);
            this.shop.Name = "shop";
            this.shop.Padding = new System.Windows.Forms.Padding(3);
            this.shop.Size = new System.Drawing.Size(1218, 558);
            this.shop.TabIndex = 1;
            this.shop.Text = "Магазин";
            this.shop.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btn_filtr);
            this.panel2.Controls.Add(this.filt_date);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(957, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 512);
            this.panel2.TabIndex = 10;
            // 
            // btn_filtr
            // 
            this.btn_filtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_filtr.Location = new System.Drawing.Point(55, 452);
            this.btn_filtr.Name = "btn_filtr";
            this.btn_filtr.Size = new System.Drawing.Size(170, 43);
            this.btn_filtr.TabIndex = 2;
            this.btn_filtr.Text = "Применить";
            this.btn_filtr.UseVisualStyleBackColor = false;
            this.btn_filtr.Click += new System.EventHandler(this.btn_filtr_Click);
            // 
            // filt_date
            // 
            this.filt_date.AutoSize = true;
            this.filt_date.Location = new System.Drawing.Point(24, 53);
            this.filt_date.Name = "filt_date";
            this.filt_date.Size = new System.Drawing.Size(142, 52);
            this.filt_date.TabIndex = 1;
            this.filt_date.Text = "Сортировка \r\nпо дате";
            this.filt_date.UseVisualStyleBackColor = true;
            this.filt_date.CheckedChanged += new System.EventHandler(this.filt_date_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Фильтрация";
            // 
            // profile_games
            // 
            this.profile_games.BackColor = System.Drawing.Color.Gray;
            this.profile_games.Controls.Add(this.balance_in_shop);
            this.profile_games.Controls.Add(this.label8);
            this.profile_games.Controls.Add(this.name_in_shop);
            this.profile_games.Controls.Add(this.userImage_shop);
            this.profile_games.Location = new System.Drawing.Point(957, 0);
            this.profile_games.Name = "profile_games";
            this.profile_games.Size = new System.Drawing.Size(258, 44);
            this.profile_games.TabIndex = 9;
            // 
            // balance_in_shop
            // 
            this.balance_in_shop.AutoSize = true;
            this.balance_in_shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balance_in_shop.Location = new System.Drawing.Point(172, 12);
            this.balance_in_shop.Name = "balance_in_shop";
            this.balance_in_shop.Size = new System.Drawing.Size(14, 15);
            this.balance_in_shop.TabIndex = 3;
            this.balance_in_shop.Text = "1";
            this.balance_in_shop.Click += new System.EventHandler(this.balance_in_shop_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(98, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ваш баланс:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // name_in_shop
            // 
            this.name_in_shop.AutoSize = true;
            this.name_in_shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_in_shop.Location = new System.Drawing.Point(40, 11);
            this.name_in_shop.Name = "name_in_shop";
            this.name_in_shop.Size = new System.Drawing.Size(14, 15);
            this.name_in_shop.TabIndex = 1;
            this.name_in_shop.Text = "1";
            this.name_in_shop.Click += new System.EventHandler(this.name_in_shop_Click);
            // 
            // userImage_shop
            // 
            this.userImage_shop.Image = global::Information_and_reference_catalog_of_computer_games.Properties.Resources.user;
            this.userImage_shop.Location = new System.Drawing.Point(3, 4);
            this.userImage_shop.Name = "userImage_shop";
            this.userImage_shop.Size = new System.Drawing.Size(36, 33);
            this.userImage_shop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage_shop.TabIndex = 0;
            this.userImage_shop.TabStop = false;
            this.userImage_shop.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // refresh_games
            // 
            this.refresh_games.BackColor = System.Drawing.Color.Transparent;
            this.refresh_games.Image = global::Information_and_reference_catalog_of_computer_games.Properties.Resources.refresh;
            this.refresh_games.Location = new System.Drawing.Point(917, 1);
            this.refresh_games.Name = "refresh_games";
            this.refresh_games.Size = new System.Drawing.Size(39, 41);
            this.refresh_games.TabIndex = 8;
            this.refresh_games.UseVisualStyleBackColor = false;
            this.refresh_games.Click += new System.EventHandler(this.refresh_games_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(955, 512);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btn_leave_account
            // 
            this.btn_leave_account.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_leave_account.Controls.Add(this.btnLeaveAcc);
            this.btn_leave_account.Controls.Add(this.refresh_game_in_profile);
            this.btn_leave_account.Controls.Add(this.flowLayoutPanel3);
            this.btn_leave_account.Controls.Add(this.label5);
            this.btn_leave_account.Controls.Add(this.freeBalance);
            this.btn_leave_account.Controls.Add(this.loadImage);
            this.btn_leave_account.Controls.Add(this.id);
            this.btn_leave_account.Controls.Add(this.label4);
            this.btn_leave_account.Controls.Add(this.age);
            this.btn_leave_account.Controls.Add(this.balance);
            this.btn_leave_account.Controls.Add(this.login);
            this.btn_leave_account.Controls.Add(this.label3);
            this.btn_leave_account.Controls.Add(this.label2);
            this.btn_leave_account.Controls.Add(this.label1);
            this.btn_leave_account.Controls.Add(this.userImage);
            this.btn_leave_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_leave_account.Location = new System.Drawing.Point(4, 24);
            this.btn_leave_account.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btn_leave_account.Name = "btn_leave_account";
            this.btn_leave_account.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_leave_account.Size = new System.Drawing.Size(1218, 558);
            this.btn_leave_account.TabIndex = 2;
            this.btn_leave_account.Text = "Профиль";
            this.btn_leave_account.Enter += new System.EventHandler(this.profile_Enter);
            this.btn_leave_account.Leave += new System.EventHandler(this.profile_Leave);
            // 
            // btnLeaveAcc
            // 
            this.btnLeaveAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeaveAcc.Location = new System.Drawing.Point(650, 0);
            this.btnLeaveAcc.Name = "btnLeaveAcc";
            this.btnLeaveAcc.Size = new System.Drawing.Size(150, 36);
            this.btnLeaveAcc.TabIndex = 14;
            this.btnLeaveAcc.Text = "Выйти с аккаунта\r\n";
            this.btnLeaveAcc.UseVisualStyleBackColor = true;
            this.btnLeaveAcc.Click += new System.EventHandler(this.btnLeaveAcc_Click);
            // 
            // refresh_game_in_profile
            // 
            this.refresh_game_in_profile.Image = global::Information_and_reference_catalog_of_computer_games.Properties.Resources.refresh;
            this.refresh_game_in_profile.Location = new System.Drawing.Point(260, 11);
            this.refresh_game_in_profile.Name = "refresh_game_in_profile";
            this.refresh_game_in_profile.Size = new System.Drawing.Size(38, 46);
            this.refresh_game_in_profile.TabIndex = 13;
            this.refresh_game_in_profile.UseVisualStyleBackColor = true;
            this.refresh_game_in_profile.Click += new System.EventHandler(this.refresh_game_in_profile_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(304, 37);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(496, 192);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(300, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ваши игры:";
            // 
            // freeBalance
            // 
            this.freeBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeBalance.Location = new System.Drawing.Point(9, 193);
            this.freeBalance.Name = "freeBalance";
            this.freeBalance.Size = new System.Drawing.Size(150, 36);
            this.freeBalance.TabIndex = 10;
            this.freeBalance.Text = "Пополнить баланс\r\nПока без платежной системы\r\n";
            this.freeBalance.UseVisualStyleBackColor = true;
            this.freeBalance.Click += new System.EventHandler(this.freeBalance_Click);
            // 
            // loadImage
            // 
            this.loadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadImage.Location = new System.Drawing.Point(9, 154);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(150, 37);
            this.loadImage.TabIndex = 9;
            this.loadImage.Text = "Загрузить изображение";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.Location = new System.Drawing.Point(165, 200);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 20);
            this.id.TabIndex = 7;
            this.id.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(165, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ваш id:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.Location = new System.Drawing.Point(165, 141);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(18, 20);
            this.age.TabIndex = 5;
            this.age.Text = "1";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balance.Location = new System.Drawing.Point(165, 89);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(18, 20);
            this.balance.TabIndex = 4;
            this.balance.Text = "1";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(165, 37);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(18, 20);
            this.login.TabIndex = 3;
            this.login.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(165, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ваш возраст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(165, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ваш баланс:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(165, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // userImage
            // 
            this.userImage.Image = global::Information_and_reference_catalog_of_computer_games.Properties.Resources.user;
            this.userImage.Location = new System.Drawing.Point(9, 11);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(150, 140);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage.TabIndex = 8;
            this.userImage.TabStop = false;
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.edit_games);
            this.adminPanel.Controls.Add(this.delete_games);
            this.adminPanel.Controls.Add(this.add_games);
            this.adminPanel.Controls.Add(this.edit_news);
            this.adminPanel.Controls.Add(this.delete_news);
            this.adminPanel.Controls.Add(this.add_news);
            this.adminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminPanel.Location = new System.Drawing.Point(4, 24);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(1218, 558);
            this.adminPanel.TabIndex = 3;
            this.adminPanel.Text = "Панель админа";
            this.adminPanel.UseVisualStyleBackColor = true;
            this.adminPanel.Enter += new System.EventHandler(this.adminPanel_Enter);
            this.adminPanel.Leave += new System.EventHandler(this.adminPanel_Leave);
            // 
            // edit_games
            // 
            this.edit_games.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_games.Location = new System.Drawing.Point(328, 158);
            this.edit_games.Name = "edit_games";
            this.edit_games.Size = new System.Drawing.Size(273, 46);
            this.edit_games.TabIndex = 5;
            this.edit_games.Text = "Редактировать блок игры";
            this.edit_games.UseVisualStyleBackColor = true;
            this.edit_games.Click += new System.EventHandler(this.edit_games_Click);
            // 
            // delete_games
            // 
            this.delete_games.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_games.Location = new System.Drawing.Point(328, 81);
            this.delete_games.Name = "delete_games";
            this.delete_games.Size = new System.Drawing.Size(273, 46);
            this.delete_games.TabIndex = 4;
            this.delete_games.Text = "Удалить блок";
            this.delete_games.UseVisualStyleBackColor = true;
            this.delete_games.Click += new System.EventHandler(this.delete_games_Click);
            // 
            // add_games
            // 
            this.add_games.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_games.Location = new System.Drawing.Point(328, 13);
            this.add_games.Name = "add_games";
            this.add_games.Size = new System.Drawing.Size(273, 46);
            this.add_games.TabIndex = 3;
            this.add_games.Text = "Создать блок игры для магазина";
            this.add_games.UseVisualStyleBackColor = true;
            this.add_games.Click += new System.EventHandler(this.add_games_Click);
            // 
            // edit_news
            // 
            this.edit_news.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_news.Location = new System.Drawing.Point(9, 158);
            this.edit_news.Name = "edit_news";
            this.edit_news.Size = new System.Drawing.Size(300, 46);
            this.edit_news.TabIndex = 2;
            this.edit_news.Text = "Редактирование новостей";
            this.edit_news.UseVisualStyleBackColor = true;
            this.edit_news.Click += new System.EventHandler(this.edit_news_Click);
            // 
            // delete_news
            // 
            this.delete_news.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_news.Location = new System.Drawing.Point(9, 81);
            this.delete_news.Name = "delete_news";
            this.delete_news.Size = new System.Drawing.Size(300, 46);
            this.delete_news.TabIndex = 1;
            this.delete_news.Text = "Удалить новость";
            this.delete_news.UseVisualStyleBackColor = true;
            this.delete_news.Click += new System.EventHandler(this.delete_news_Click);
            // 
            // add_news
            // 
            this.add_news.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_news.Location = new System.Drawing.Point(9, 13);
            this.add_news.Name = "add_news";
            this.add_news.Size = new System.Drawing.Size(300, 46);
            this.add_news.TabIndex = 0;
            this.add_news.Text = "Создать новость";
            this.add_news.UseVisualStyleBackColor = true;
            this.add_news.Click += new System.EventHandler(this.add_news_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 586);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.news.ResumeLayout(false);
            this.profile_news.ResumeLayout(false);
            this.profile_news.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.shop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.profile_games.ResumeLayout(false);
            this.profile_games.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage_shop)).EndInit();
            this.btn_leave_account.ResumeLayout(false);
            this.btn_leave_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.adminPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage news;
        private System.Windows.Forms.TabPage shop;
        private System.Windows.Forms.TabPage btn_leave_account;
        private System.Windows.Forms.TabPage adminPanel;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Button freeBalance;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refresh_news;
        private System.Windows.Forms.Button add_news;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_subtitle;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Panel profile_news;
        private System.Windows.Forms.Label balanceInNews;
        private System.Windows.Forms.Label nameProfile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pb_profile;
        private System.Windows.Forms.Button delete_news;
        private System.Windows.Forms.Button edit_news;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button add_games;
        private System.Windows.Forms.Button refresh_games;
        private System.Windows.Forms.Button delete_games;
        private System.Windows.Forms.Button edit_games;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button refresh_game_in_profile;
        private System.Windows.Forms.Panel profile_games;
        private System.Windows.Forms.Label balance_in_shop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label name_in_shop;
        private System.Windows.Forms.PictureBox userImage_shop;
        private System.Windows.Forms.Button btnLeaveAcc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox filt_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_filtr;
    }
}