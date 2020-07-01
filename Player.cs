using System;
using System.Collections.Generic;
using System.Windows.Forms;
using War.Properties;

namespace War
{
    class Player
    {
        private readonly List<Card> discardPile;
        private Stack<Card> drawPile;
        private readonly Stack<Card> inPlay;
        private readonly PictureBox cardDisplay;
        private readonly PictureBox drawDisplay;
        private readonly Label totalCards;
        private readonly Label tieDisplay;

        private static readonly String totalCardsPrefix = "Total Cards: ";

        public String Name 
        {
            get;
        }

        /// <summary>
        /// Total cards a player has in their draw and discard pile
        /// </summary>
        public int CardCount
        {
            get { return drawPile.Count + discardPile.Count; }
        }

        public Player(String playerName, PictureBox card, PictureBox draw, Label total, Label tie)
        {
            Name = playerName;
            cardDisplay = card;
            drawDisplay = draw;
            totalCards = total;
            tieDisplay = tie;
            drawPile = new Stack<Card>();
            discardPile = new List<Card>();
            inPlay = new Stack<Card>();
        }

        /// <summary>
        /// Pushes a card onto the player's draw pile.  
        /// Updates total cards and draw pile display
        /// </summary>
        /// <param name="card">Card to push onto the draw pile</param>
        public void AddToDrawPile(Card card)
        {
            drawPile.Push(card);
            UpdateTotal();
            UpdateDrawDisplay();
        }

        /// <summary>
        /// Moves the top card from the players draw pile to the in play pile. 
        /// Displays the card and updates the draw pile display.
        /// </summary>
        /// <returns>The card that was played.  If the player has no cards, returns null</returns>
        public Card PlayNextCard()
        {
            Card next = NextCard();
            UpdateTie();
            inPlay.Push(next);
            UpdateCardDisplay(next);
            UpdateDrawDisplay();
            return next;
        }

        /// <summary>
        /// Adds the cards from this player's and another player's in play pile to this player's discard pile. 
        /// Updates total cards display
        /// </summary>
        /// <param name="cards">Another player's in play pile</param>
        public void WinCards(Player otherPlayer)
        {
            Stack<Card> otherCards = otherPlayer.LoseCards();
            while (otherCards.Count != 0)
            {
                discardPile.Add(otherCards.Pop());
            }
            while (inPlay.Count != 0)
            {
                discardPile.Add(inPlay.Pop());
            }
            UpdateTotal();
        }

        /// <summary>
        /// Returns the cards in play for this player with the intention that another player will empty the stack.   
        /// Updates total cards display 
        /// </summary>
        /// <returns>The the cards in play</returns>
        private Stack<Card> LoseCards()
        {
            UpdateTotal();
            return inPlay;
        }

        /// <summary>
        /// Gets the top card in the player's draw pile.  If the draw pile is empty, the discard pile will be shuffled into the draw pile
        /// </summary>
        /// <returns>Top card in the player's draw pile, null if the player has no more cards</returns>
        private Card NextCard()
        {
            try
            {
                return GetDrawPile().Pop();
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns the player's draw pile.  If the draw pile is empty, shuffle the discard pile into the draw pile
        /// </summary>
        /// <returns></returns>
        private Stack<Card> GetDrawPile()
        {
            if (drawPile.Count == 0)
            {
                if (discardPile.Count != 0)
                {
                    Shuffle();
                }
            }
            return drawPile;
        }

        private void Shuffle()
        {
            drawPile = CardDeck.Shuffle(discardPile);
            discardPile.Clear();
        }

        private void UpdateCardDisplay(Card card)
        {
            if (cardDisplay.Image != null)
            {
                cardDisplay.Image.Dispose();
            }
            cardDisplay.Image = card.Picture;
        }

        private void UpdateDrawDisplay()
        {
            if (drawPile.Count == 0)
            {
                drawDisplay.Image.Dispose();
                drawDisplay.Image = null;
            }
            else
            {
                if (drawDisplay.Image == null)
                {
                    drawDisplay.Image = Resources.red_back;
                }
            }
        }

        private void UpdateTotal()
        {
            totalCards.Text = totalCardsPrefix + CardCount;
        }

        private void UpdateTie()
        {
            if (inPlay.Count == 0)
            {
                tieDisplay.Text = null;
            }
            else if (inPlay.Count == 1)
            {
                tieDisplay.Text = inPlay.Peek().Name;
            }
            else
            {
                tieDisplay.Text += ", " + inPlay.Peek().Name;
            }
        }

    }
}
