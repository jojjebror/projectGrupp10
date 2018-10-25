using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;


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
        String[,] rssData = null;
        private String[,] getRssData(String channel)
        {
            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(channel);
            System.Net.WebResponse myResponse = myRequest.GetResponse();
            System.IO.Stream rssStream = myResponse.GetResponseStream();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

            rssDoc.Load(rssStream);

            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

            String[,] tempRssData = new string[500, 3];

            for (int i = 0; i < rssItems.Count; i++)
            {
                System.Xml.XmlNode rssNode;

                rssNode = rssItems.Item(i).SelectSingleNode("title");
                if (rssNode != null)
                {
                    tempRssData[i, 0] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 0] = "";
                }
                rssNode = rssItems.Item(i).SelectSingleNode("description");
                if (rssNode != null)
                {
                    tempRssData[i, 1] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 1] = "";
                }
                rssNode = rssItems.Item(i).SelectSingleNode("link");
                if (rssNode != null)
                {
                    tempRssData[i, 2] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 2] = "";
                }
            }
            return tempRssData;
        }

       

        private void lvPodcast_ItemSelectionChanged(object sender, EventArgs e)
        {
            if (rssData[lvPodcast.SelectedItems.Count,1] != null)
                rtInfo.Text = rssData[lvPodcast.SelectedItems.Count, 1];
            if (rssData[lvPodcast.SelectedItems.Count, 2] != null)
                lkLank.Text = "Go to " + rssData[lvPodcast.SelectedItems.Count, 0];
        }

        private void lkLank_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rssData[lvPodcast.SelectedItems.Count, 2] != null)
                System.Diagnostics.Process.Start(rssData[lvPodcast.SelectedItems.Count, 2]);
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

       

        private void btnSok_Click(object sender, EventArgs e)
        {
            lvPodcast.Items.Clear();
            rssData = getRssData(txbUrl.Text);
            for (int i = 0; i < rssData.GetLength(0); i++)
            {
                if (rssData[i, 0] != null)
                {
                    lvPodcast.Items.Add(rssData[i, 0]);
                   
                }
                if(rssData[i, 1] != null)
                {
                    lvPodcast.Items.Add(rssData[i, 1]);
                }
                lvPodcast.SelectedItems = 0; 
            }

        }




    }
        
    


}
