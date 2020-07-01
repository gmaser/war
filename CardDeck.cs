using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
            return Shuffle(Cards);
        }

        /// <summary>
        /// Shuffles a list of cards into a random order
        /// </summary>
        /// <param name="cards"></param>
        /// <returns>Stack of the cards in a random order</returns>
        public static Stack<Card> Shuffle(IReadOnlyList<Card> cards)
        {
            Random rnd = new Random();
            return new Stack<Card>(cards.OrderBy(x => rnd.Next()));
        }

    }
}
