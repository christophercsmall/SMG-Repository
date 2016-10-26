using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneSystemInventoryManager
{
    public partial class CreateForm : Form
    {
        private MainForm mf;

        public CreateForm(MainForm mainform)
        {
            InitializeComponent();
            mf = mainform;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox5, "Extenion already assigned.");
        }
    }
}
