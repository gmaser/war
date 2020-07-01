using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace War
{
    [XmlRoot("deck")]
    public class CardDeck
    {
        [XmlElement("card")]
        public Card[] Cards { get; set; }

        public Stack<Card> Shuffle()
        {
            Random rnd = new Random();
            return new Stack<Card>(Cards.OrderBy(x => rnd.Next()));
        }

    }
}
