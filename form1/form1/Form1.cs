﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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

            if (string.IsNullOrWhiteSpace(tbKategorier.Text))
            {
                vali.valideraKategori();

            }
            else
            {
                cbKategori.Items.Add(tbKategorier.Text);
                listaKategorier.Add(tbKategorier.Text);

                tbKategorier.Clear();
                LaggTillKategorier();
                tbKategorier.Focus();

            }

        }

        public void btnKategorierTaBort_Click(object sender, EventArgs e)
        {
            if (lbKategorier.Items.Count > 0)
            {
                listaKategorier.RemoveAt(lbKategorier.SelectedIndex);
                TaBortKategori();
                
            }
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
            XmlTextWriter xwriter = new XmlTextWriter("savefile.xml", Encoding.Unicode);
            xwriter.WriteStartDocument();
            xwriter.WriteStartElement("Podcast");
            xwriter.WriteStartElement("title");
            xwriter.WriteEndElement();
            foreach (String item in lbFeed.Items)
            {
                xwriter.WriteStartElement("Item");
                xwriter.WriteString(item);
                xwriter.WriteEndElement();
            }
            xwriter.WriteEndElement();
            xwriter.WriteEndDocument();
            xwriter.Close();
        }

        

        private void btnRensa_Click(object sender, EventArgs e)
        {
            txbUrl.Clear();
            txbUrl.Focus();
        }
    }



     
}
