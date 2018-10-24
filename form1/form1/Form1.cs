using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        List<string> listaKategorier;
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
            listaKategorier.Add(tbKategorier.Text);
            tbKategorier.Clear();
            LaggTillKategorier();
            
        }

        private void btnKategorierTaBort_Click(object sender, EventArgs e)
        {
            
            if (lbKategorier.Items.Count>0)
            {
                
                lbKategorier.Items.Remove(lbKategorier.SelectedItems[0]);
                
            }
        }
        
    }


}
