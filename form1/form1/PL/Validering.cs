using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.ServiceModel.Syndication;


namespace form1
{

    public class Validering:Virtual
    {
        

        public bool TryParseFeed(string url)
        {
            try
            {
                SyndicationFeed feed = SyndicationFeed.Load(XmlReader.Create(url));
                foreach (SyndicationItem item in feed.Items)
                {
                    Debug.Print(item.Title.Text);
                }
                return true;
            }
            catch (System.UriFormatException)
            {
                MessageBox.Show("Ogiltig rssfeed");
                return false;
            }
        }

        public void valideraUrl()
        {
            MessageBox.Show("Ogiltig rssfeed");
        }




        public override void valideraKategori()
        {

            MessageBox.Show("Skriv in en kategori");
            
        }

        public void valideraSpara()
        {
            MessageBox.Show("Skriv in en kategori!");
        }

        public void valideraTaBort()
        {
            MessageBox.Show("Välj en podcast som ska tas bort!");
        }

        public void valideraTaBortKategori()
        {
            MessageBox.Show("Välj en kategori som ska tas bort!");

        }
        public void valideraAndraKategori()
        {
            MessageBox.Show("Välj en kategori som ska ändras!");

        }
        public void valideraLink()
        {
            MessageBox.Show("Skriv in en URL och tryck sök först!");

        }

        public void valideraLaggTillKategori()
        {
            MessageBox.Show("Kategorin finns redan i listan ovan!");

        }










    }
}
