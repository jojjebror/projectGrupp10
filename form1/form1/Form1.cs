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

        String[,] rssData = null;
        private String[,] getRssData(String channel)
        {
            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(channel);
            System.Net.WebResponse myResponse = myRequest.GetResponse();
            System.IO.Stream rssStream = myResponse.GetResponseStream();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();
            rssDoc.Load(rssStream);
            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");
            String[,] tempRssData = new string[500, 4];
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
                rssNode = rssItems.Item(i).SelectSingleNode("pubDate");
                if (rssNode != null)
                {
                    tempRssData[i, 3] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 3] = "";
                }
            }
            return tempRssData;
        }


        private void lkLank_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rssData[listBox1.SelectedIndex, 2] != null)
                System.Diagnostics.Process.Start(rssData[listBox1.SelectedIndex, 2]);
        }



        

        private void btnSok_Click_1(object sender, EventArgs e)
        {
            {
                listBox1.Items.Clear();
                rssData = getRssData(txbUrl.Text);
                for (int i = 0; i < rssData.GetLength(0); i++)
                {
                    if (rssData[i, 0] != null)
                    {
                        listBox1.Items.Add(rssData[i, 0]);
                        listView2.Items.Add(rssData[i, 3]);

                    }
                    listBox1.SelectedIndex = 0;
                    
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
            if (lbKategorier.Items.Count > 0)
            {
                lbKategorier.Items.RemoveAt(0);
                listaKategorier.RemoveAt(0);
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rssData[listBox1.SelectedIndex, 1] != null)
                rtInfo.Text = rssData[listBox1.SelectedIndex, 1];
            if (rssData[listBox1.SelectedIndex, 2] != null)
                lkLank.Text = "Go to " + rssData[listBox1.SelectedIndex, 0];
        }
    }


     
}
