using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace form1
{   [Serializable]
    public class Podcasts : ISerializable
    {
        public string interval { get; set; }
        public string url { get; set; }
        public string category { get; set; }

        public Podcasts()
        {

        }

        public Podcasts( string url)
        {
            //this.interval = interval;
            this.url = url;
            //this.category = category;
        }
        
        

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("url", url);
            info.AddValue("interval", interval);
            info.AddValue("category", category);
        }

       

        public Podcasts(SerializationInfo info, StreamingContext context)
        {
            url = (string)info.GetValue("url", typeof(string));
            category = (string)info.GetValue("category", typeof(string));
            interval = (string)info.GetValue("interval", typeof(string));
        }
    }
}
