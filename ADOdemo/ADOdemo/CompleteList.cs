using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOdemo
{
    public partial class CompleteList : Form
    {
        public CompleteList()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CompleteList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classmatesDataSet.CIS2621' table. You can move, or remove it, as needed.
            this.cIS2621TableAdapter.Fill(this.classmatesDataSet.CIS2621);

        }
    }
}
