using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_and_reference_catalog_of_computer_games
{
    internal class ClassGameInProfileBLL
    {
        public string idAccount;
        public ClassGameInProfileBLL(string idAccount)
        {
            this.idAccount = idAccount;
        }

        #region Get Items

        public DataTable GetItems()
        {
            try
            {
                ClassGameInProfileDB objdal = new ClassGameInProfileDB(idAccount);
                return objdal.ReadItemsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        #endregion
    }
}
