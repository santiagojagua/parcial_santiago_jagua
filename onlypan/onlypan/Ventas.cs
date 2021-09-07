using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlypan
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pa = textBox1.Text;
            int pA = Int32.Parse(pa);
            string pna = textBox2.Text;
            int pnA = Int32.Parse(pna);
            string pe = textBox3.Text;
            int pE = Int32.Parse(pe);

            int PrecioPa = 1000;
            int PrecioPna = 500;
            int PrecioPe = 2000;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = textBox4.Text;
            fila.Cells[1].Value = textBox5.Text;
            fila.Cells[2].Value = textBox1.Text;
            fila.Cells[3].Value = textBox2.Text;
            fila.Cells[4].Value = textBox3.Text;
            fila.Cells[5].Value = ((pA*PrecioPa) + (pnA*PrecioPna) + (pE * PrecioPe));
            fila.Cells[6].Value = textBox6.Text;


            dataGridView1.Rows.Add(fila);
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
        }
    }
}
