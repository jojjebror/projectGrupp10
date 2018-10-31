using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1
{
    class Class1
    {
        System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();
        public String[,] rssData = null;

        public String[,] getRssData(String channel)
        {
            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(channel);
            System.Net.WebResponse myResponse = myRequest.GetResponse();

            System.IO.Stream rssStream = myResponse.GetResponseStream();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

            rssDoc.Load(rssStream);
            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel");
            System.Xml.XmlNodeList rssAvsnitt = rssDoc.SelectNodes("rss/channel/item");
            String[,] tempRssData = new string[500, 10];

            for (int i = 0; i < rssItems.Count; i++)
            {
                string title;

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
                rssNode = rssItems.Item(i).SelectSingleNode("pubDate");
                if (rssNode != null)
                {
                    tempRssData[i, 5] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 5] = "";
                }



            }
            System.Xml.XmlNode rsNode;
            for (int i = 0; i<rssAvsnitt.Count; i++)
            {

                rsNode = rssAvsnitt.Item(i).SelectSingleNode("title");
                if (rsNode != null)
                {
                    tempRssData[i, 4] = rsNode.InnerText;
                }
                else
                {
                    tempRssData[i, 4] = "";
                }
                rsNode = rssAvsnitt.Item(i).SelectSingleNode("description");
                if (rsNode != null)
                {
                    tempRssData[i, 1] = rsNode.InnerText;
                }
                else
                {
                    tempRssData[i, 1] = "";
                }
                rsNode = rssAvsnitt.Item(i).SelectSingleNode("link");
                if (rsNode != null)
                {
                    tempRssData[i, 2] = rsNode.InnerText;
                }
                else
                {
                    tempRssData[i, 2] = "";
                }
                

            }
            return tempRssData;
        }
    }
}
