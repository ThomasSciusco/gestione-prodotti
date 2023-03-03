using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {  
        public int dim;
        public string [] arr;
        public Form1()
        {
            InitializeComponent();
            arr=new string[100];
            dim = 0;
        }
        private void Form1_Load(object sender, EventArgs e)

        {
            toolTip1.SetToolTip(pulsante, "Aggiunge elemento all'array. ");
        }

        private void button1_Click(object sender, EventArgs e)

        {
            
            aggiunta(arr, ref dim, primo.Text);
            aggiornaVista(dim);
            primo.Text = "";
            primo.Focus();
            MessageBox.Show("Aggiunto. ");

        }
        public void aggiunta(string []arr, ref int dim, string nome)
        {
            arr[dim] = nome;
            dim++;
        }
        public void aggiornaVista(int dim)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView1.Items.Add(arr[i]);    
            }
        }

        private void etichetta_Click(object sender, EventArgs e)
        {

        }
    }
}
