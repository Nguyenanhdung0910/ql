using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai17
{
    public partial class Form2 : Form
    {
        QLDEntities db = new QLDEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadcb();

        }
        private void loadcb()
        {
            comboBox1.DataSource = db.Lops.ToList();
            comboBox1.DisplayMember = "lopID";
            comboBox1.ValueMember = "lopID";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport1 rp = new CrystalReport1();
            rp.SetParameterValue("ma", comboBox1.Text);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
