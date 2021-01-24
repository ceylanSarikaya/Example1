using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OgrenciListesi ogrencliler = new OgrenciListesi();
        private void btnListele_Click(object sender, EventArgs e)
        {
          dataGridView1.DataSource = ogrencliler.Listele();
        }

        private void btnOgrenciNoList_Click(object sender, EventArgs e)
        {
            int ogrenciNo = Convert.ToInt32(tctOgrenciNo.Text);
            dataGridView1.DataSource = ogrencliler.OgrenciNoListele(ogrenciNo);
        }
    }
}
