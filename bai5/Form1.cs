using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        QLKS1Entities db = new QLKS1Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("bạn cso muốn thoát không","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.Phongs.ToList();
            comboBox1.DisplayMember = "Tinhtrang";
            comboBox1.ValueMember = "Tinhtrang";
            hienthi();
            dataGridView1.Columns[4].Visible = false;
        }
        public void hienthi()
        {
            dataGridView1.DataSource = db.Phongs.ToList();
            dataGridView1.AutoGenerateColumns = false;
        }
        public void hiencb()
        {
            //comboBox1.DataSource = db.Phongs.ToList();
            //comboBox1.DisplayMember = "Tinhtrang";
            //comboBox1.ValueMember = "Tinhtrang";
        }
    }
}
