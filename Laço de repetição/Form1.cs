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
            //list.Items.Add(1);
            //list.Items.Add(2);
            //list.Items.Add(3);
            //list.Items.Add(4);
            //list.Items.Add(5);
            //list.Items.Add(6);
            //list.Items.Add(7);
            //list.Items.Add(8);
            //list.Items.Add(9);
            //list.Items.Add(10);

            //Laços de repetição para preencher os valores

            //for (int valor = 0; valor <= 10; valor++)
            //{
            //    list.Items.Add(valor);
            //}

            ////for (int valor = 0; valor <= 10; valor += 2) 
            //{ list.Items.Add(valor); }

            //+= 2 quer dizer q vai acrescentando de 2 em 2 comentário :)


            int vezes = 0;
            do
            {
                list.Items.Add(vezes);
                vezes++;

            }
            while (vezes <= 10);
        }
    }
}
