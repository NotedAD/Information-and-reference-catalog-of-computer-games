using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_and_reference_catalog_of_computer_games
{
    public partial class GameUserControl : UserControl
    {
        public GameUserControl()
        {
            InitializeComponent();
        }

        #region Getter & Setter For Labels & Picture Box
        private Image _icon;
        private string _title;
        private string _subtitle;
        private string _price;
        private string _date;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set
            { _icon = value; pb_gameIcon.Image = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set
            { _title = value; gm_name.Text = value; }
        }

        [Category("Custom Props")]
        public string SubTitle
        {
            get { return _subtitle; }
            set
            { _subtitle = value; gm_desctription.Text = value; }
        }

        [Category("Custom Props")]
        public string Date
        {
            get { return _date; }
            set
            { _date = value; gm_date.Text = value; }
        }

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set
            { _price = value; gm_price.Text = value; }
        }
        #endregion

        #region Hover Effect
        private void GameUserControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void GameUserControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void gm_name_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void gm_desctription_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void gm_price_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void gm_date_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void pb_gameIcon_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void gm_name_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void gm_desctription_Click(object sender, EventArgs e)
        {
            this.OnClick(e);

        }

        private void gm_date_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void gm_price_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void pb_gameIcon_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        #endregion

    }
}
