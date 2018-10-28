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
        Class1 dataInput = new Class1();
        Validering vali = new Validering();

        public Form1()
        {
            InitializeComponent();
            this.listaKategorier = new List<string>();
        }

        
        


       private void lkLank_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataInput.rssData[lbFeed.SelectedIndex, 2] != null)
                System.Diagnostics.Process.Start(dataInput.rssData[lbFeed.SelectedIndex, 2]);
        }



        

        private void btnSok_Click_1(object sender, EventArgs e)
        {
            
            {
                lbFeed.Items.Clear();
                dataInput.rssData = dataInput.getRssData(txbUrl.Text);
                for (int i = 0; i < dataInput.rssData.GetLength(0); i++)
                {
                    if (dataInput.rssData[i, 0] != null)
                    {
                        
                        lbFeed.Items.Add(dataInput.rssData[i, 0] +    " avsnitt");
                        
                        
                        

                        
                    }
                    lbFeed.SelectedIndex = 0;
                    
                    
                }
                for (int i = 0; i < dataInput.rssData.GetLength(0); i++)
                {
                   
                     
                    if (dataInput.rssData[i, 4] != null)
                    {
                        lbDatum.Items.Add(dataInput.rssData[i, 4]);
                     
                    }
                    lbDatum.SelectedIndex = 0;
                   

                }
                
            }
        }
        private void LaggTillKategorier()
        {
            lbKategorier.Items.Clear();


            foreach (var item in listaKategorier)
            {
                lbKategorier.Items.Add(item);
            }

        }

        
        private void btnKategorierLaggTill_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbKategorier.Text))
            {
                vali.valideraKategori();

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
            if (lbKategorier.Items.Count > 0)
            {
                lbKategorier.Items.RemoveAt(0);
                listaKategorier.RemoveAt(0);
                
            }
        }

        private void lbFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (dataInput.rssData[lbFeed.SelectedIndex, 2] != null)
                lkLank.Text = "Go to " + dataInput.rssData[lbFeed.SelectedIndex, 0];
            if (dataInput.rssData[lbFeed.SelectedIndex, 1] != null)
                lbDatum.Text = dataInput.rssData[lbFeed.SelectedIndex, 3];
        
        }

        private void lbDatum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataInput.rssData[lbDatum.SelectedIndex, 4] != null)
                rtInfo.Text = dataInput.rssData[lbDatum.SelectedIndex, 1];
        }
    }



     
}
