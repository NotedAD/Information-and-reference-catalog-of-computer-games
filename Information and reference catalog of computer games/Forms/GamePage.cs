using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Information_and_reference_catalog_of_computer_games
{
    public partial class GamePage : Form
    {
        public string nameGame;
        public string idAccount;
        public string idGames;
        private float priceGames;
        private float balanceAccount;
        private bool preorder;
        private DateTime dateCheckOnRelease = DateTime.Now;
        private DateTime dateOnRelease;
        public GamePage()
        {
            InitializeComponent();
        }

        private void GamePage_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            string queryInfo = $"SELECT id_games, name, description, date_release, price, image, preorder FROM games WHERE name = '{nameGame}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                idGames = reader[0].ToString();
                gm_name.Text = reader[1].ToString();
                gm_description.Text = reader[2].ToString();
                gm_date.Text = reader[3].ToString();
                gm_price.Text = reader[4].ToString();
                preorder = (bool)reader[6];
                string ifImage = "";
                if (ifImage != reader[5].ToString())
                {
                    System.Drawing.Image imageUser = (Bitmap)((new ImageConverter()).ConvertFrom(reader[5]));
                    gm_icon.Image = imageUser;
                    gm_icon.Invalidate();
                }
            }
            reader.Close();

            bool resCheck = CheckGamesInAccount();

            if (!resCheck)
            {
                btn_buy.Enabled = false;
                btn_buy.Text = "У вас есть эта игра!";
            }

            db.closeConnection();
            dateOnRelease = DateTime.Parse(gm_date.Text);
            
            if (dateOnRelease >= dateCheckOnRelease)
            {
                if (preorder) 
                {
                    btn_buy.Text = "Предзаказать!";
                }
                else
                {
                    btn_buy.Enabled = false;
                    btn_buy.Text = "Игра не вышла!";
                }
                
            }
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string queryInfo = $"SELECT price FROM games WHERE name = '{nameGame}'";
            MySqlCommand mySqlCommandGames = new MySqlCommand(queryInfo, db.getConnection());

            string queryInfoAccount = $"SELECT balance FROM account WHERE id_account = '{idAccount}'";
            MySqlCommand mySqlCommandAccount = new MySqlCommand(queryInfoAccount, db.getConnection());

            db.openConnection();

            MySqlDataReader readerGames = mySqlCommandGames.ExecuteReader();
            while (readerGames.Read())
            {
                priceGames = float.Parse(readerGames[0].ToString());
            }
            readerGames.Close();


            MySqlDataReader readerAccount = mySqlCommandAccount.ExecuteReader();
            while (readerAccount.Read())
            {
                balanceAccount = float.Parse(readerAccount[0].ToString());
            }
            readerAccount.Close();

            db.closeConnection();

            if (balanceAccount >= priceGames)
            {
                bool resCheck = CheckGamesInAccount();
                if (resCheck)
                {
                    if (MessageBox.Show("Вы действительно хотите купить игру?", "Подтверждение покупки",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        balanceAccount -= priceGames;
                        string queryInfoUpdateMoney = $"UPDATE account SET balance = @balance WHERE id_account = '{idAccount}'";
                        MySqlCommand mySqlCommandAccountUpdate = new MySqlCommand(queryInfoUpdateMoney, db.getConnection());

                        db.openConnection();

                        mySqlCommandAccountUpdate.Parameters.AddWithValue("@balance", balanceAccount);
                        mySqlCommandAccountUpdate.ExecuteNonQuery();

                        db.closeConnection();

                        string queryInfoUpdateAccountGame = $"INSERT buy_games(id_games, id_account) VALUES (@idGames, @idAccount)";
                        MySqlCommand mySqlCommandAccountUpdateGame = new MySqlCommand(queryInfoUpdateAccountGame, db.getConnection());

                        db.openConnection();

                        mySqlCommandAccountUpdateGame.Parameters.AddWithValue("@idGames", $"{idGames}");
                        mySqlCommandAccountUpdateGame.Parameters.AddWithValue("@idAccount", $"{idAccount}");
                        mySqlCommandAccountUpdateGame.ExecuteNonQuery();

                        db.closeConnection();

                        MessageBox.Show($"Поздравялем с покупой игры {nameGame}");
                        btn_buy.Enabled = false;
                        btn_buy.Text = "У вас есть эта игра!";
                    }
                    else
                    {
                        MessageBox.Show($"Вы отменили покупку игры {nameGame}");
                    }
                }
                else
                {
                    MessageBox.Show($"У вас уже есть данная игра", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_buy.Enabled = false;
                    btn_buy.Text = "У вас есть эта игра!";
                }
            }
            else
            {
                MessageBox.Show("Недостаточно средств!");
            }
        }

        private bool CheckGamesInAccount()
        {
            DB db = new DB();
            db.openConnection();
            string com = "select count(*) from buy_games where id_account = @idAccount and id_games=@idGames";
            MySqlCommand mySqlCommandAccountUpdate = new MySqlCommand(com, db.getConnection());
            mySqlCommandAccountUpdate.Parameters.AddWithValue("@idAccount", idAccount);
            mySqlCommandAccountUpdate.Parameters.AddWithValue("@idGames", idGames);
            int count = Convert.ToInt32(mySqlCommandAccountUpdate.ExecuteScalar());
            if (count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
