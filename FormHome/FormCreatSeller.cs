using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlCRUD;

namespace FormHome
{
    public partial class FormCreatSeller : Form
    {
        public FormCreatSeller()
        {
            InitializeComponent();
        }
        IspanEntities ispan = new IspanEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            CRUDtool tool = new CRUDtool();
            if(tool.RegexAccount(txbAccount.Text) == true)
            {
                txbAccount.Clear();
                return;
            }
            if(tool.RegexPassword(txbPassword.Text) == true)
            {
                txbPassword.Clear();
                return;
            }
            Sellers sellers = new Sellers();
            sellers.Account = txbAccount.Text;
            sellers.Password= txbPassword.Text;
            sellers.LastName = txbLastname.Text;
            sellers.FirstName = txbFirstname.Text;
            sellers.IdentityNumber = txbIdnum.Text;
            sellers.ContactNumber = txbTelephone.Text;
            sellers.Address = txbAddress.Text;
            sellers.StoreName = txbStorename.Text;
            sellers.BirthDate = dateTimePicker1.Value;

        }
    }
}
