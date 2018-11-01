using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    [Serializable]
    public class Podcasts2:ISerializable
    {
        
        
        public string category { get; set; }
        
        public Podcasts2()
        {

        }

        

        public Podcasts2(string category)
        {
           
            this.category = category;
            
        }



        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
          
            info.AddValue("category", category);
            

        }



        public Podcasts2(SerializationInfo info, StreamingContext context)
        {
            
            category = (string)info.GetValue("category", typeof(string));
            

        }
    }
}

