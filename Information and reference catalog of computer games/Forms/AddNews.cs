using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Information_and_reference_catalog_of_computer_games.Forms
{
    public partial class AddNews : Form
    {
        #region Form Initialization
        public OpenFileDialog opendlg = new OpenFileDialog();
        public bool isChange;
        public string idTitle;
        public AddNews()
        {
            InitializeComponent();
        }

        private void AddNews_Load(object sender, EventArgs e)
        {
            if (isChange)
            {
                DB db = new DB();

                string queryInfo = $"SELECT title, sub_title, image FROM news WHERE title LIKE @myTitle";
                MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

                db.openConnection();
                mySqlCommand.Parameters.AddWithValue("@myTitle", "%" + idTitle + "%");
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    txt_title.Text = reader[0].ToString();
                    txt_subtitle.Text = reader[1].ToString();

                    string ifImage = "";
                    if (ifImage != reader[2].ToString())
                    {
                        System.Drawing.Image imageUser = (Bitmap)((new ImageConverter()).ConvertFrom(reader[2]));
                        pb_image.Image = imageUser;
                        pb_image.Invalidate();
                    }
                }
                reader.Close();

                db.closeConnection();
            }
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
                catch(Exception)
                {
                    MessageBox.Show("Загружаемая вами иконка силшком большая", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }


        #endregion

        #region Save & Edit Button 
        private void save_Click(object sender, EventArgs e)
        {
            if(isChange)
            {
                try
                {
                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand($"UPDATE news SET title = @title, sub_title = @subtitle, image = @image WHERE title LIKE @myTitle", db.getConnection());

                    db.openConnection();
                    command.Parameters.AddWithValue("@myTitle", "%" + idTitle + "%");
                    command.Parameters.AddWithValue("@title", txt_title.Text);
                    command.Parameters.AddWithValue("@subtitle", txt_subtitle.Text);
                    if(opendlg.FileName == "")
                    {
                        opendlg.FileName = $"default-image.png";
                        command.Parameters.AddWithValue("@image", File.ReadAllBytes($"{opendlg.FileName}"));
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@image", File.ReadAllBytes($"{opendlg.FileName}"));
                    }

                    command.ExecuteNonQuery();
                    MessageBox.Show("Новость успешна изменена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.closeConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show($"Не удалось изменить запись!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                ClassBLL objbll = new ClassBLL();
                if (objbll.SaveItem(pb_image.Image, txt_title.Text, txt_subtitle.Text))
                {
                    if (pb_image.Image == null || txt_title.Text == null || txt_subtitle.Text == null)
                    {
                        MessageBox.Show("Вы не добавили какой-то из элементов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Новость загружена!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось загрузить новость!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        #endregion

    }
}
