using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fi_kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Height = 200;
            label3.Width = 200; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(iso_size.Text) && string.IsNullOrEmpty(circuit.Text))
            {
                MessageBox.Show("wpisz Fi i grubość iso!!!");
                return;
            }
            if (string.IsNullOrEmpty(circuit.Text))
            {
                MessageBox.Show("wpisz Fi!!!");
                return;
            }
            if (string.IsNullOrEmpty(iso_size.Text))
            {
                MessageBox.Show("wpisz grubość iso!!!");
                return;
            }
            
            int cir = int.Parse(circuit.Text);            
            int iso = int.Parse(iso_size.Text);
            
            double diam = cir / 3.14;  // fi bez izolacji
            diam = Math.Round(diam, 1);
            double diam_iso = (cir / 3.14) + (iso/10 * 2);  // fi z izolacją
            diam_iso = Math.Round(diam_iso, 1);
            label4.Text = diam.ToString();
            label5.Text = diam_iso.ToString();
            }
        }
    }

