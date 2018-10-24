using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        List<string> listaKategorier;
        string selectedItemText;
        int selectedIndex;

        public Form1()
        {
            InitializeComponent();
            this.listaKategorier = new List<string>();
        }

        private void LaggTillKategorier()
        {
            lbKategorier.Items.Clear();
            

            foreach(var item in listaKategorier)
            {
                lbKategorier.Items.Add(item);
            }
            
        }

        



        private void btnKategorierLaggTill_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(tbKategorier.Text)) 
            {
                MessageBox.Show("Skriv in en kategori");

            }
            else
            {
                comboBox2.Items.Add(tbKategorier.Text);
                listaKategorier.Add(tbKategorier.Text);

                tbKategorier.Clear();
                LaggTillKategorier();

            }
            
        }

        private void btnKategorierTaBort_Click(object sender, EventArgs e)
        {
            if (lbKategorier.Items.Count>0)
            {
                lbKategorier.Items.RemoveAt(0);
                listaKategorier.RemoveAt(0);
            }
         }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
        
    


}
