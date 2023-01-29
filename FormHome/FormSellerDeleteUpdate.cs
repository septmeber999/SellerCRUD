using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHome
{
    public partial class FormSellerDeleteUpdate : Form
    {
        private readonly int sid;
        public FormSellerDeleteUpdate(int sid)
        {
            InitializeComponent();
            this.sid = sid;
            this.Load += FormSellerDeleteUpdate_Load;
        }
        IspanEntities ISpan = new IspanEntities();
        private void FormSellerDeleteUpdate_Load(object sender, EventArgs e)
        {
            var seller = from s in ISpan.Sellers
                         where s.ID == sid
                         select s;

            foreach(var s in seller) 
            {
                txbFirstname.Text = s.FirstName;
                txbLastname.Text = s.LastName;
                txbTelephone.Text = s.ContactNumber;
                txbAddress.Text = s.Address;
                txbStorename.Text = s.StoreName;
                txbBirthdate.Text = s.BirthDate.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
