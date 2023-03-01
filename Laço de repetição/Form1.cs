using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laço_de_repetição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Items.Add(1);
            list.Items.Add(2);
            list.Items.Add(3);
            list.Items.Add(4);
            list.Items.Add(5);
            list.Items.Add(6);
            list.Items.Add(7);
            list.Items.Add(8);
            list.Items.Add(9);
            list.Items.Add(10);
        }
    }
}
