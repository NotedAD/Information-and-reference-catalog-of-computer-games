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
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        #region Getter & Setter For Labels & Picture Box
        private Image _icon;
        private string _title;
        private string _subtitle;
        private string _date;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set
            { _icon = value; pb_icon.Image = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set
            { _title = value; lbl_title.Text = value; }
        }

        [Category("Custom Props")]
        public string SubTitle
        {
            get { return _subtitle; }
            set
            { _subtitle = value; lbl_subtitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Date
        {
            get { return _date; }
            set
            { _date = value; lbl_date.Text = value; }
        }
        #endregion

        #region Hover Effect
        private void MyUserControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void MyUserControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lbl_subtitle_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lbl_date_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void pb_icon_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lbl_title_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void lbl_subtitle_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void lbl_date_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }
        #endregion


    }
}
