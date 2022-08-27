using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai7
{
    public partial class formdiem : Form
    {
        QLD7Entities db = new QLD7Entities();
        public formdiem()
        {
            InitializeComponent();
        }

        private void formdiem_Load(object sender, EventArgs e)
        {

        }
        public void hienthi()
            {
            listView1.Items.Clear();
            foreach (var d in db.tbDiems.ToList()) 
            {
                ListViewItem item = new ListViewItem(d.MaSv);
                item.SubItems.Add(d.Mamon);
                item.SubItems.Add(d.tbSinhVien.Hoten);
            }
        }
    }
}
