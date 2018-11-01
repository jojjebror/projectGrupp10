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
        

        public static bool TryParseFeed(string url)
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
            catch (Exception)
            {
                MessageBox.Show("Ogiltig rssfeed");
                return false;
            }
        }




        public override void valideraKategori()
        {
            MessageBox.Show("Skriv in en kategori");
            
        }

        public void valideraSpara()
        {
            MessageBox.Show("Skriv in en kategori!");
        }

        





    }
}
