using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Information_and_reference_catalog_of_computer_games
{
    public partial class AddGames : Form
    {
        #region Form Initialization
        public OpenFileDialog opendlg = new OpenFileDialog();
        public bool isChange;
        public string idName;

        public AddGames()
        {
            InitializeComponent();
        }

        private void AddGames_Load(object sender, EventArgs e)
        {
            if (isChange)
            {
                DB db = new DB();

                string queryInfo = $"SELECT name, description, date_release, price, age_limit, image, preorder, country FROM games WHERE name = '{idName}'";
                MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

                db.openConnection();

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    txt_title.Text = reader[0].ToString();
                    txt_subtitle.Text = reader[1].ToString();
                    txt_date.Text = reader[2].ToString();
                    txt_price.Text = reader[3].ToString();
                    txt_ageLimit.Text = reader[4].ToString();
                    txt_preorder.Checked = (bool)reader[6];
                    txt_country.Text = reader[7].ToString();

                    string ifImage = "";
                    if (ifImage != reader[5].ToString())
                    {
                        System.Drawing.Image imageUser = (Bitmap)((new ImageConverter()).ConvertFrom(reader[5]));
                        pb_image.Image = imageUser;
                        pb_image.Invalidate();
                    }
                }
                reader.Close();

                db.closeConnection();
            }
        }

        private void txt_date_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Parse(txt_date.Text) < DateTime.Now)
                txt_preorder.Enabled = false;
            else
                txt_preorder.Enabled = true;

        }
        #endregion

        #region Button Upload
        private void upload_img_Click(object sender, EventArgs e)
        {
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(opendlg.FileName);
                    pb_image.Image = image;
                }
                catch (Exception)
                {
                    MessageBox.Show("Загружаемая вами иконка слишком большая", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Save & Edit Button
        private void save_Click(object sender, EventArgs e)
        {
            if (isChange)
            {
                try
                {
                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand($"UPDATE games SET name = @name, description = @description, date_release = @date_release, price = @price, age_limit = @ageLimit, image = @image, preorder = @preorder, country = @country WHERE name = '{idName}'", db.getConnection());

                    db.openConnection();
                    command.Parameters.AddWithValue("@name", txt_title.Text);
                    command.Parameters.AddWithValue("@description", txt_subtitle.Text);
                    command.Parameters.AddWithValue("@date_release", txt_date.Text);
                    command.Parameters.AddWithValue("@price", txt_price.Text);
                    command.Parameters.AddWithValue("@ageLimit", txt_ageLimit.Text);
                    command.Parameters.AddWithValue("@preorder", txt_preorder.Checked);
                    command.Parameters.AddWithValue("@country", txt_country.Text);
                    if (opendlg.FileName == "")
                    {
                        opendlg.FileName = @"default-image.png";
                        command.Parameters.AddWithValue("@image", File.ReadAllBytes($"{opendlg.FileName}"));
                    }
                    else
                    { 
                    command.Parameters.AddWithValue("@image", File.ReadAllBytes($"{opendlg.FileName}"));
                    }

                    command.ExecuteNonQuery();
                    MessageBox.Show("Игра успешна изменена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.closeConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show($"Не удалось изменить запись!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                ClassGameBLL objbll = new ClassGameBLL();
                if (pb_image.Image == null || txt_title.Text == null || txt_subtitle.Text == null || txt_price.Text == null || txt_date.Text == null || txt_country.Text == null || txt_ageLimit.Text == "/  /")
                {
                    MessageBox.Show("Вы не добавили(написали неправильно) какой-то из элементов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (objbll.SaveItem(pb_image.Image, txt_title.Text, txt_subtitle.Text, txt_price.Text, txt_date.Text, txt_ageLimit.Text, txt_preorder.Checked, txt_country.Text))
                    {
                        MessageBox.Show("Игра загружена!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось загрузить игру!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion


    }
}
