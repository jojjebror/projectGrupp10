using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{   [Serializable]
    public class Podcasts : ISerializable
    {
        public string interval { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string category { get; set; }
        
        public Podcasts()
        {

        }
        public ListViewItem ToListViewItem()
        {
            ListViewItem ViewItem = new ListViewItem(new[] {title });
            ViewItem.Tag = this;
            return ViewItem;
        }
        

      

        public Podcasts( string url, string title)
        {
            this.interval = interval;
            this.url = url;
            this.category = category;
            this.title = title;
        }
        
        

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("url", url);
            info.AddValue("interval", interval);
            info.AddValue("category", category);
            info.AddValue("title", title);
        }

       

        public Podcasts(SerializationInfo info, StreamingContext context)
        {
            url = (string)info.GetValue("url", typeof(string));
            category = (string)info.GetValue("category", typeof(string));
            interval = (string)info.GetValue("interval", typeof(string));
            title = (string)info.GetValue("title", typeof(string));
        }
    }
}
