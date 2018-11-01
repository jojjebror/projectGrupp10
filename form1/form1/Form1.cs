using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace form1
{
    public partial class Form1 : Form
    {
        List<string> listaKategorier;
        Class1 dataInput = new Class1();
        Validering vali = new Validering();
        FileManager files = new FileManager();
        Podcasts newPod = new Podcasts();
        Podcasts2 newPod2 = new Podcasts2();
        FileManager2 files2 = new FileManager2();

        public Form1()
        {
            
            InitializeComponent();
            this.listaKategorier = new List<string>();
        }
        

       public void lkLank_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataInput.rssData[lbFeed.SelectedIndex, 2] != null)
                System.Diagnostics.Process.Start(dataInput.rssData[lbFeed.SelectedIndex, 2]);
            
        }

        


        
        public void btnSok_Click_1(object sender, EventArgs e)
        {
            
            {
                lbFeed.Items.Clear();
                dataInput.rssData = dataInput.getRssData(txbUrl.Text);
                for (int i = 0; i < dataInput.rssData.GetLength(0); i++)
                {
                    if (dataInput.rssData[i, 0] != null)
                    {
                        
                        lbFeed.Items.Add(dataInput.rssData[i, 0]);
                        
                        
                    }
                    lbFeed.SelectedIndex = 0;
                    
                    
                }
                lbAvsnitt.Items.Clear();

                for (int i = 0; i < dataInput.rssData.GetLength(0); i++)
                {
                   
                     
                    if (dataInput.rssData[i, 4] != null)
                    {
                        lbAvsnitt.Items.Add(dataInput.rssData[i, 4]);
                        labelAvsnitt.Text = "Antal Avsnitt: "+lbAvsnitt.Items.Count.ToString();


                    }
                    lbAvsnitt.SelectedIndex = 0;
                   

                }
                lbBox.Items.Clear();

                for (int i = 0; i < dataInput.rssData.GetLength(0); i++)
                {


                    if (dataInput.rssData[i, 5] != null)
                    {
                        lbBox.Items.Add(dataInput.rssData[i, 5]);

                    }
                    lbBox.SelectedIndex = 0;


                }

            }
        }
        public void LaggTillKategorier()
        {
            lbKategorier.Items.Clear();


            foreach (var item in listaKategorier)
            {
                lbKategorier.Items.Add(item);
            }
            

        }

        public void TaBortKategori()
        {
            if (lbKategorier.SelectedItems.Count != 0)
            {
                while (lbKategorier.SelectedIndex != -1)
                {
                    cbKategori.Items.Remove(lbKategorier.SelectedItem);
                    lbKategorier.Items.RemoveAt(lbKategorier.SelectedIndex);
                }
            }
            
            
            
        }


        public void btnKategorierLaggTill_Click(object sender, EventArgs e)
        {
            cbKategori.Items.Clear();
            if (string.IsNullOrWhiteSpace(tbKategorier.Text))
            {
                vali.valideraSpara();
                return;
            }


            string category = tbKategorier.Text;
            string comboBox = lbKategorier.Text;
            files2.kategoriLista.Add(new Podcasts2(category));
            files2.SaveFeed2();
            update2();
            
            
            
            tbKategorier.Clear();
            
            tbKategorier.Focus();
        }

        

        public void btnKategorierTaBort_Click(object sender, EventArgs e)
        {
            /*if (lbKategorier.Items.Count > 0)
            {
                listaKategorier.RemoveAt(lbKategorier.SelectedIndex);
                TaBortKategori();
                
            }*/


        }

        public void lbFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (dataInput.rssData[lbFeed.SelectedIndex, 2] != null)
                lkLank.Text = "Gå till: " + dataInput.rssData[lbFeed.SelectedIndex, 0];
            if (dataInput.rssData[lbFeed.SelectedIndex, 1] != null)
                lbAvsnitt.Text = dataInput.rssData[lbFeed.SelectedIndex, 3];
            labelAvsnitt.Text = "Antal Avsnitt: "+lbAvsnitt.Items.Count.ToString();
            
        }



        public void lbAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataInput.rssData[lbAvsnitt.SelectedIndex, 4] != null)
                rtInfo.Text = dataInput.rssData[lbAvsnitt.SelectedIndex, 1];
                
        }

        public void btnSpara_Click(object sender, EventArgs e)
        {
            
            

            
            string url = txbUrl.Text;
            string title = lbFeed.Text;
            
            files.feedList.Add(new Podcasts(url, title));
            files.SaveFeed();
            update();
            
        }

        

        private void btnRensa_Click(object sender, EventArgs e)
        {
            
            
            txbUrl.Clear();
            txbUrl.Focus();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            files2.GetFeed2();
            files.GetFeed();
            update();
            update2();
            
        }

        public void update2()
        {
            lbKategorier.Items.Clear();
            foreach (var item in files2.kategoriLista)
            {
                lbKategorier.Items.Add(item.category);
                cbKategori.Items.Add(item.category);
            }
            



        }

        public void update()
        {
            listView1.Items.Clear();
            foreach (var item in files.feedList)
            {

                listView1.Items.Add(item.ToListViewItem());

                
            }
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            Podcasts pod = (Podcasts)listView1.SelectedItems[0].Tag;
            files.feedList.Remove(pod);
            files.SaveFeed();
            update();
            lbFeed.Items.Clear();
            lbAvsnitt.Items.Clear();
            rtInfo.Clear();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                {

                    Podcasts pod = (Podcasts)listView1.SelectedItems[0].Tag;
                    lbFeed.Items.Clear();
                    dataInput.rssData = dataInput.getRssData(pod.url);
                    for (int i = 0; i < dataInput.rssData.GetLength(0); i++)
                    {
                        if (dataInput.rssData[i, 0] != null)
                        {

                            lbFeed.Items.Add(dataInput.rssData[i, 0]);


                        }
                        lbFeed.SelectedIndex = 0;


                    }
                    lbAvsnitt.Items.Clear();

                    for (int i = 0; i < dataInput.rssData.GetLength(0); i++)
                    {


                        if (dataInput.rssData[i, 4] != null)
                        {
                            lbAvsnitt.Items.Add(dataInput.rssData[i, 4]);
                            labelAvsnitt.Text = "Antal Avsnitt: " + lbAvsnitt.Items.Count.ToString();


                        }
                        lbAvsnitt.SelectedIndex = 0;


                    }
                    lbBox.Items.Clear();

                    for (int i = 0; i < dataInput.rssData.GetLength(0); i++)
                    {


                        if (dataInput.rssData[i, 5] != null)
                        {
                            lbBox.Items.Add(dataInput.rssData[i, 5]);

                        }
                        lbBox.SelectedIndex = 0;


                    }

                }
            }

            
        }
    }



     //skapa ny lista för kategorier,gör en klass också. Kopiera sen xml skiten från filemanager men byt
     //ut adressen! sen kopplar du knappen lägg till som ett event där du lägger in listan
     //och lägger in items. gör en ny klass med interfacet serialize!
}
