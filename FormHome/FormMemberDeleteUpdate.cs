using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace FormHome
{

    public partial class FormMemberDeleteUpdate : Form
    {
        private readonly int mid;
        public FormMemberDeleteUpdate(int mid)
        {
            InitializeComponent();
            this.mid = mid;
            this.Load += FormMemberDeleteUpdate_Load;
        }

        IspanEntities ISpan = new IspanEntities();
        private void FormMemberDeleteUpdate_Load(object sender, EventArgs e)
        {
            var member = from m in ISpan.Members
                         where m.ID== mid
                         select m;

            dataGridView1.DataSource = member.ToList();
        }
    }
}
