using System.Collections.Generic;
using System.Runtime.Serialization;

namespace _6_7_2_
{
    [DataContract]
    public class Cloth
    {
        public Cloth() { hyperlinkText = "More..."; }
        [DataMember]
        private string name;
        [DataMember]
        private string description;
        [DataMember]
        private string matherial;
        [DataMember]
        private string count;
        [DataMember]
        private string cost;
        [DataMember]
        private string imageAdr;
        [DataMember]
        private string hyperlinkText;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Matherial
        {
            get { return matherial; }
            set { matherial = value; }
        }
        public string Count
        {
            get { return count; }
            set { count = value; }
        }
        public string Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public string ImageAdr
        {
            get { return imageAdr; }
            set { imageAdr = value; }
        }
        public string HyperlinkText
        {
            get { return hyperlinkText; }
            set { hyperlinkText = value; }
        }

       
    }
}
