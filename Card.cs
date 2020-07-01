using System;
using System.Drawing;
using System.Xml.Serialization;
using War.Properties;

namespace War
{
    [XmlRoot("card")]
    public class Card
    {
        [XmlAttribute("suit")]
        public String Suit { get; set; }
        [XmlAttribute("face")]
        public String Face { get; set; }
        [XmlAttribute("rank")]
        public int Rank { get; set; }

        public String Name
        {
            get { return Face + " of " + Suit; }
        }

        public Image Picture
        {
            get { return (Image)Resources.ResourceManager.GetObject(Face + Suit); }
        }

    }
}
