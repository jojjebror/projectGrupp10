using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace form1
{
    public class FileManager
    {
        public List<Podcasts> feedList = new List<Podcasts>();
        
        public FileManager()
        {

        }
        public void SaveFeed()
        {
            using (FileStream fs = new FileStream("RssFeed.xml",
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Podcasts>));
                serializer.Serialize(fs, feedList);
            }
        }
        
        public void GetFeed()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Podcasts>));

            using (FileStream fs = File.OpenRead("RssFeed.xml"))
            {
                feedList = (List<Podcasts>)serializer.Deserialize(fs);
            }
        }
    }
}
