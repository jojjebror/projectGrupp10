using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace form1
{
    public class FileManager2
    {
        
        public List<Podcasts2> kategoriLista = new List<Podcasts2>();

        public FileManager2()
        {

        }
        public void SaveFeed2()
        {
            using (FileStream fs = new FileStream("ss.xml",
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Podcasts2>));
                serializer.Serialize(fs, kategoriLista);
            }
        }

        public void GetFeed2()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Podcasts2>));

            using (FileStream fs = File.OpenRead("ss.xml"))
            {
                kategoriLista = (List<Podcasts2>)serializer.Deserialize(fs);
            }
        }
    }
}

