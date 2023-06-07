using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_1_B
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.Makanan' table. You can move, or remove it, as needed.
            this.makananTableAdapter.Fill(this.restaurantDataSet.Makanan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
