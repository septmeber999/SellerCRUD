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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        IspanEntities ISpan = new IspanEntities();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Seller") 
            {
                if(txbSelect.Text != string.Empty)
                {
                    var seller = from s in ISpan.Sellers
                                 where s.Account.Contains(txbSelect.Text)
                                 select s;

                    dataGridView1.DataSource = seller.ToList();
                }
                else
                {
                    var seller = from s in ISpan.Sellers
                             select s;

                    dataGridView1.DataSource = seller.ToList();
                }
            }
            else if (comboBox1.Text == "Member") 
            {
                if(txbSelect.Text != string.Empty)
                {
                    var member = from m in ISpan.Members
                                 where m.Account.Contains(txbSelect.Text)
                                 select m;

                    dataGridView1.DataSource = member.ToList();
                }
                else
                {
                    var member = from m in ISpan.Members
                                 select m;

                    dataGridView1.DataSource = member.ToList();
                }               
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(comboBox1.Text == "Seller")
            {
                var seller = from s in ISpan.Sellers
                             where s.Account.Contains(txbSelect.Text)
                             select s;

                int sid = seller.ToList()[e.RowIndex].ID;

                FormSellerDeleteUpdate frm = new FormSellerDeleteUpdate(sid);
                frm.ShowDialog();
            }
            else if (comboBox1.Text == "Member")
            {
                var member = from m in ISpan.Members
                             where m.Account.Contains(txbSelect.Text)
                             select m;

                int mid = member.ToList()[e.RowIndex].ID;

                FormMemberDeleteUpdate frm = new FormMemberDeleteUpdate(mid);
                frm.ShowDialog();
            }
        }
    }
}
