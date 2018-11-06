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
        Timer timer = new Timer();

        public Form1()
        {
            
            InitializeComponent();
            this.listaKategorier = new List<string>();
            var url = txbUrl.Text;
            var interval = cbInterval.Text;
            var kategori = cbKategori.Text;
            var kategorierAndra = tbKategorier.Text;


        }
        

       public void lkLank_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dataInput.rssData[lbFeed.SelectedIndex, 2] != null)
                    System.Diagnostics.Process.Start(dataInput.rssData[lbFeed.SelectedIndex, 2]);
            }
            catch (NullReferenceException)
            {
                vali.valideraLink();
            }
        }

       


        
        public void btnSok_Click_1(object sender, EventArgs e)
        {
            
            try
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
            catch (Exception)
            {
                vali.valideraUrl();
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
            if (txbUrl.Text.Equals("")) 
            {
                vali.valideraSparaUtanAttSoka();
                return;
            }
            if (lbFeed.Text.Equals(""))
            {
                
                return;
            }

            if (cbInterval.SelectedItem == null || cbKategori.SelectedItem == null)
            {
                vali.valideraSparaUtanFrekvensEllerKategori();
                return;
            }
            
            



            string url = txbUrl.Text;
            string title = lbFeed.Text;
            string category = cbKategori.Text;
            string interval = cbInterval.Text;
            
            files.feedList.Add(new Podcasts(url, title, category, interval));
            files.SaveFeed();
            update();
            update2();
            
        }

        public void btnKategorierLaggTill_Click(object sender, EventArgs e)
        {
            
            if (listView2.FindItemWithText(tbKategorier.Text) != null)
            {
                vali.valideraLaggTillKategori();
                return;
            }


            
            cbKategori.Items.Clear();
            if (string.IsNullOrEmpty(tbKategorier.Text))
            {
                vali.valideraKategori();
                return;
            }


            string category = tbKategorier.Text;
            string comboBox = listView2.Text;
            files2.kategoriLista.Add(new Podcasts2(category));
            files2.SaveFeed2();
            update2();
            




            tbKategorier.Clear();

            tbKategorier.Focus();
        }



        private async void btnRensa_Click(object sender, EventArgs e)
        {


            await btnRensa_ClickAsync();
            
        }

        public async Task btnRensa_ClickAsync()
        {
            
            await Task.Delay(1000);
            rtInfo.Clear();
            lbAvsnitt.Items.Clear();
            lbFeed.Items.Clear();
            lbBox.Items.Clear();
            labelAvsnitt.ResetText();
            lkLank.ResetText();
            txbUrl.Clear();
            txbUrl.Focus();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            FillInterval();
            files2.GetFeed2();
            files.GetFeed();
            update2();
            update();
            
            
            
            
        }

        public void update()
        {
            listView1.Items.Clear();
            foreach (var item in files.feedList)
            {

                listView1.Items.Add(item.ToListViewItem());


                timer.Interval = (Int32.Parse(item.interval) * 1000);
                timer.Tick += new EventHandler(timer1_Tick);
                timer.Start();
            }
        }
        public void update2()
        {
            cbKategori.Items.Clear();
            listView2.Items.Clear();
            foreach (var item in files2.kategoriLista)
            {

                listView2.Items.Add(item.ToListViewItem2());
                cbKategori.Items.Add(item.category);

            }
            
        }

        public void update3()
        {
            foreach (var item in files2.kategoriLista)
            {

                
                cbKategori.Items.Add(item.category);

            }
        }
        

        

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                Podcasts pod = (Podcasts)listView1.SelectedItems[0].Tag;
                files.feedList.Remove(pod);
                files.SaveFeed();
                update();
                lbFeed.Items.Clear();
                lbAvsnitt.Items.Clear();
                rtInfo.Clear();
            }
            catch (ArgumentOutOfRangeException)
            {
                vali.valideraTaBort();
                return;
            }
        }

        public void btnKategorierTaBort_Click(object sender, EventArgs e)
        {
            try
            {
                cbKategori.Items.Clear();
                Podcasts2 pod2 = (Podcasts2)listView2.SelectedItems[0].Tag;
                files2.kategoriLista.Remove(pod2);
                files2.SaveFeed2();
                update2();
            }
            catch (ArgumentOutOfRangeException)
            {
                vali.valideraTaBortKategori();
                return;
            }
            
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
        
        private void btnAndra_Click(object sender, EventArgs e)
        {
            try
            {
                var text = tbKategorier.Text;
                vali.textFaltTomt(text, "Kategori");
                string pickedCategory = listView2.SelectedItems[0].Text;
                string newCategoryName = tbKategorier.Text;
                foreach (var x in files2.kategoriLista)
                {
                    if (x.category == pickedCategory)
                    {
                        x.category = newCategoryName;
                    }

                }
                update2();
                files2.SaveFeed2();
            }
            catch (ArgumentException fieldTomt)
            {
                MessageBox.Show(fieldTomt.Message);
            }

        }

        

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSorteradePods.Items.Clear();
            if (listView2.SelectedItems.Count == 1)
            {
                string pickedCategory = listView2.SelectedItems[0].Text;
                var podcast = files.feedList.Where(s => s.category == pickedCategory).ToList();
                foreach (var x in podcast)
                {
                    lvSorteradePods.Items.Add(x.ToListViewItem());
                }
            }
        }

        private void FillInterval()
        {
            cbInterval.Items.Add(5);
            cbInterval.Items.Add(10);
            cbInterval.Items.Add(15);
            
        }
        
        public void cbInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataInput.getRssDataFromLocalXML();
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            
        }

        private void btnAndraPod_Click(object sender, EventArgs e)
        {
            try
            {
                var pod = tbAndraPod.Text;

                vali.textFaltTomt(pod, " Podcast");
                string pickedPod = listView1.SelectedItems[0].Text;
                string newPodName = tbAndraPod.Text;
                foreach (var x in files.feedList)
                {
                    if (x.interval == pickedPod)
                    {
                        x.interval = newPodName;
                    }

                }
                update();
                files.SaveFeed();
                tbAndraPod.Clear();
            }
            catch (ArgumentException fieldTomt)
            {
                MessageBox.Show(fieldTomt.Message);
            }
        }
    }



     
}
