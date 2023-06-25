using Information_and_reference_catalog_of_computer_games.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Information_and_reference_catalog_of_computer_games
{

    public partial class Main : Form
    {
        public string isAdmin;
        public string idInfo;
        public string balanceInfo;
        private int ageUser;
        private int ageLimitGames;
        bool isAscending = false;
        public Main()
        {
            InitializeComponent();
        }

        #region Form Load
        private void Main_Load(object sender, EventArgs e)
        {
            if (isAdmin == "Admin" || isAdmin == "admin")
                adminPanel.Parent = tabControl1;
            else
                adminPanel.Parent = null;
            GenerateDynamicUserControl();
            GenerateDynamicUserControl2();
            GenerateDynamicUserControl3();


            DB db = new DB();

            string queryInfo = $"SELECT login, balance, age, image FROM account WHERE id_account = '{idInfo}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                login.Text = reader[0].ToString();
                balance.Text = reader[1].ToString();
                age.Text = reader[2].ToString();
                ageUser = (int)reader[2];
                balanceInNews.Text = balance.Text;
                balance_in_shop.Text = balance.Text;
                nameProfile.Text = reader[0].ToString();
                name_in_shop.Text = reader[0].ToString();
                string ifImage = "";
                if (ifImage != reader[3].ToString())
                {
                    System.Drawing.Image imageUser = (Bitmap)((new ImageConverter()).ConvertFrom(reader[3]));
                    userImage.Image = imageUser;
                    userImage.Invalidate();
                    pb_profile.Image = imageUser;
                    pb_profile.Invalidate();
                    userImage_shop.Image= imageUser;
                    userImage_shop.Invalidate();
                }
            }
            reader.Close();

            db.closeConnection();
            refresh_games.FlatAppearance.BorderSize = 0;
            refresh_games.FlatStyle = FlatStyle.Flat;
            refresh_game_in_profile.FlatAppearance.BorderSize = 0;
            refresh_game_in_profile.FlatStyle = FlatStyle.Flat;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, userImage.Width - 3, userImage.Height - 3);
            Region rg = new Region(gp);
            userImage.Region = rg;
            id.Text = idInfo;
        }


        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            DB db = new DB();

            string queryInfo = $"SELECT balance FROM account WHERE id_account = '{idInfo}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                balance.Text = reader[0].ToString();
                balanceInNews.Text = balance.Text;
                balance_in_shop.Text = balance.Text;
            }
            reader.Close();

            db.closeConnection();

        }
        
        private void adminPanel_Enter(object sender, EventArgs e)
        {
            this.Width = 700;
            this.Height = 300;
        }

        private void adminPanel_Leave(object sender, EventArgs e)
        {
            this.Width = 1242;
            this.Height = 625;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        #region Form

        private void btnLeaveAcc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти с аккаунта?", "Подтверждение выхода",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Authorization authorization = new Authorization();
                authorization.Show();
                Close();
            }
            else
            {
            }
        }

        #endregion

        #region Profile

        private void GenerateDynamicUserControl3()
        {
            flowLayoutPanel3.Controls.Clear();

            ClassGameInProfileBLL objbll = new ClassGameInProfileBLL(idInfo);

            DataTable dt = objbll.GetItems();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    GamesInProfile[] listItems = new GamesInProfile[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {

                            listItems[i] = new GamesInProfile();
                            MemoryStream ms = new MemoryStream((byte[])row["image"]);
                            listItems[i].Icon = new Bitmap(ms);
                            listItems[i].Title = row["name"].ToString();

                            flowLayoutPanel3.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }

        private void profile_Enter(object sender, EventArgs e)
        {       
            this.Width = 850;
            this.Height = 300;
        }

        private void profile_Leave(object sender, EventArgs e)
        {
            this.Width = 1242;
            this.Height = 625;
        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"UPDATE account SET image = @image WHERE id_account = '{idInfo}'", db.getConnection());

            db.openConnection();

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    command.Parameters.AddWithValue("@image", File.ReadAllBytes($"{open_dialog.FileName}"));
                    command.ExecuteNonQuery();

                    Bitmap image = new Bitmap(open_dialog.FileName);
                    userImage.Image = image;
                    pb_profile.Image = image;
                    userImage_shop.Image = image;
                    userImage.Invalidate();
                }
                catch (Exception)
                {
                    MessageBox.Show("Выбранное вами изображение больше 16 МБ, выберите другое", "Ошибка изображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            db.closeConnection();
        }

        private void freeBalance_Click(object sender, EventArgs e)
        {
            try
            {
                string balanceInfo = Interaction.InputBox("Введите сумму, только в пределах разумного!");
                int resultBalance = int.Parse(balanceInfo);
                if (resultBalance > 100000)
                {
                    MessageBox.Show("Слишком большая сумма", "Нельзя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (resultBalance < 0)
                {
                    MessageBox.Show("Нельзя же вводит отрицательную сумму, как же игры покупать", "Нельзя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand($"UPDATE account SET balance = @balance WHERE id_account = '{idInfo}'", db.getConnection());

                    db.openConnection();

                    command.Parameters.AddWithValue("@balance", resultBalance);
                    balance.Text = balanceInfo;
                    balanceInNews.Text = balanceInfo;
                    balance_in_shop.Text = balanceInfo;
                    command.ExecuteNonQuery();

                    db.closeConnection();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Сумму а не строку", "Нельзя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void refresh_game_in_profile_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl3();
        }
        #endregion

        #region News
        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();
            ClassBLL objbll = new ClassBLL();

            DataTable dt = objbll.GetItems();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    MyUserControl[] listItems = new MyUserControl[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new MyUserControl();
                            MemoryStream ms = new MemoryStream((byte[])row["image"]);
                            listItems[i].Icon = new Bitmap(ms);
                            listItems[i].Title = row["title"].ToString();
                            listItems[i].SubTitle = row["sub_title"].ToString();
                            listItems[i].Date = row["date_news"].ToString();

                            flowLayoutPanel1.Controls.Add(listItems[i]);

                            listItems[i].Click += new System.EventHandler(this.UserControlNews_Click);
                        }
                    }
                }
            }
        }

        void UserControlNews_Click(object sender, EventArgs e) 
        {
            MyUserControl obj = (MyUserControl)sender;

            pb_icon.Image = obj.Icon;
            lbl_title.Text = obj.Title;
            lbl_subtitle.Text = obj.SubTitle;
            showpanel();
        }

        private void showpanel()
        {
            panel1.Visible = true;
        }
        private void hidepanel()
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidepanel();
        }

        private void refresh_news_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }

        private void add_news_Click(object sender, EventArgs e)
        {
            AddNews addNews = new AddNews();
            addNews.isChange = false;
            addNews.Show();
        }

        private void delete_news_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string title = Interaction.InputBox("Введите название записи, которую вы хотите удалить!");

            db.openConnection();

            if (MessageBox.Show("Вы действительно хотите удалить новость?", "Подтверждение удаления",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = $"DELETE FROM news WHERE title = '{title}'";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Новость успешно удалена!", "Success!");
            }
            else
            {
                MessageBox.Show("Не удалось удалить запись!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void edit_news_Click(object sender, EventArgs e)
        {
            string title = Interaction.InputBox("Введите заголовок записи, который вы хотите изменить!");

            AddNews addNews = new AddNews();
            addNews.isChange = true;
            addNews.idTitle = title;
            if(addNews.idTitle.Length == 0)
            {
                MessageBox.Show("Вы не ввели запись", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addNews.Show();
            }
        }

        #endregion

        #region Profile In News
        private void profile_news_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = btn_leave_account;
        }

        private void pb_profile_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = btn_leave_account;
        }

        private void nameProfile_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = btn_leave_account;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = btn_leave_account;
        }

        private void balancInNews_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = btn_leave_account;
        }


        #endregion

        #region Games

        private void GenerateDynamicUserControl2()
        {
            flowLayoutPanel2.Controls.Clear();
            ClassGameBLL objbll = new ClassGameBLL();

            DataTable dt = objbll.GetItems(isAscending);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    GameUserControl[] listItems = new GameUserControl[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new GameUserControl();
                            MemoryStream ms = new MemoryStream((byte[])row["image"]);
                            listItems[i].Icon = new Bitmap(ms);
                            listItems[i].Title = row["name"].ToString();
                            listItems[i].SubTitle = row["description"].ToString();
                            listItems[i].Price = row["price"].ToString();
                            listItems[i].Date = row["date_release"].ToString();

                            flowLayoutPanel2.Controls.Add(listItems[i]);

                            listItems[i].Click += new System.EventHandler(this.UserControlGames_Click);
                        }
                    }
                }
            }
        }
        void UserControlGames_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            GameUserControl obj = (GameUserControl)sender;

            string queryAgeForGame = $"SELECT age_limit FROM games WHERE name = '{obj.Title}'";

            MySqlCommand mySqlCommand = new MySqlCommand(queryAgeForGame, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ageLimitGames = (int)reader[0];
            }
            reader.Close();

            db.closeConnection();

            if(ageLimitGames > ageUser)
            {
                MessageBox.Show("Вы не совершеннолетний для просмотра данной игры!");
            }
            else
            {
                GamePage gamePage = new GamePage();
                gamePage.nameGame = obj.Title;
                gamePage.idAccount = idInfo;
                gamePage.Show();
            }
        }

        private void add_games_Click(object sender, EventArgs e)
        {
            AddGames addGames = new AddGames();
            addGames.isChange = false;
            addGames.Show();
        }

        private void refresh_games_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl2();
        }

        private void delete_games_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string title = Interaction.InputBox("Введите название игры (полностью), которую вы хотите удалить!");

            db.openConnection();

            if (MessageBox.Show("Вы действительно хотите удалить игру?", "Подтверждение удаления",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = $"DELETE FROM games WHERE name = '{title}'";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Игра успешно удалена!", "Success!");
            }
            else
            {
                MessageBox.Show("Не удалось удалить запись!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void edit_games_Click(object sender, EventArgs e)
        {
            string title = Interaction.InputBox("Введите название игры (полностью), который вы хотите изменить!");

            AddGames addGames = new AddGames();
            addGames.isChange = true;
            addGames.idName = title;
            if (addGames.idName.Length == 0)
            {
                MessageBox.Show("Вы не ввели запись", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addGames.Show();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = btn_leave_account;
        }

        private void name_in_shop_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = btn_leave_account;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = btn_leave_account;
        }

        private void balance_in_shop_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = btn_leave_account;
        }

        private void filt_date_CheckedChanged(object sender, EventArgs e)
        {
            isAscending = !isAscending;
        }

        private void btn_filtr_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            GenerateDynamicUserControl2();
        }




        #endregion
    }
}

