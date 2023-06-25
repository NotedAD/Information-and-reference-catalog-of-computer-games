using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Information_and_reference_catalog_of_computer_games
{
    public partial class GamesInProfile : UserControl
    {
        public GamesInProfile()
        {
            InitializeComponent();
        }

        #region Getter & Setter For Labels & Picture Box
        private Image _icon;
        private string _title;
        private bool preorder;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set
            { _icon = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set
            { _title = value; lbl_title.Text = value; }
        }

        #endregion

        #region Form 
        public void btn_dwnld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это просто кнопка, скачиваться ничего не будет!");
        }

        private void GamesInProfile_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            string queryInfo = $"SELECT preorder FROM games WHERE name = '{Title}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                preorder = (bool)reader[0];
            }
            reader.Close();

            db.closeConnection();
            if (preorder)
            {
                btn_dwnld.Enabled = false;
            }
        }
        #endregion

    }
}
