using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1
{
    class Class1
    {
        public String[,] rssData = null;

        public String[,] getRssData(String channel)
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
    }
}
