using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using War.Properties;

namespace War
{
    public partial class Form1 : Form
    {

        private Player player1;
        private Player player2;
        private Player warWinner;

        private static readonly String player1DisplayName = "Player1";
        private static readonly String player2DisplayName = "Player2";
        private static readonly String fightText = "Fight!";
        private static readonly String playAgainText = "Play Again?";

        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            warWinner = null;
            CardDeck deck = LoadDeck();
            player1Name.Text = player1DisplayName;
            player2Name.Text = player2DisplayName;
            player1 = new Player(player1DisplayName, player1Card, player1DrawPile, player1TotalCards);
            player2 = new Player(player2DisplayName, player2Card, player2DrawPile, player2TotalCards);
            DealCards(player1, player2, deck.Shuffle());
            button1.Text = fightText;
            winner.Text = null;
            player1Card.Image = null;
            player2Card.Image = null;
        }

        private static CardDeck LoadDeck()
        {
            Console.WriteLine("Loading standard deck");
            XmlSerializer serializer = new XmlSerializer(typeof(CardDeck));
            CardDeck loadedDeck = (CardDeck)serializer.Deserialize(new StringReader(Resources.standard_deck));
            return loadedDeck;
        }

        private static void DealCards(Player p1, Player p2, Stack<Card> shuffledDeck)
        {
            while(shuffledDeck.Count != 0)
            {
                if(shuffledDeck.Count % 2 == 0)
                {
                    p1.AddToDrawPile(shuffledDeck.Pop());
                }
                else
                {
                    p2.AddToDrawPile(shuffledDeck.Pop());
                }
            }
        }

        private Player Battle()
        {
            Card player1NextCard = player1.PlayNextCard();
            Card player2NextCard = player2.PlayNextCard();

            if(player1NextCard == null)
            {
                warWinner = player2;
                return player2;
            }

            if(player2NextCard == null)
            {
                warWinner = player1;
                return player1;
            }

            Console.WriteLine(player1.Name + " (" + player1NextCard.Name + ") vs " + player2.Name + " (" + player2NextCard.Name + ")");

            if (player1NextCard.Rank > player2NextCard.Rank)
            {
                player1.WinCards(player2.LoseCards());
                return player1;
            }
            else if (player2NextCard.Rank > player1NextCard.Rank)
            {
                player2.WinCards(player1.LoseCards());
                return player2;
            }
            else
            {
                return Battle();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definitely a better way to do this
            if(button1.Text == playAgainText)
            {
                StartGame();
            }
            else
            {
                Console.WriteLine(player1.Name + " has " + player1.CardCount + " cards");
                Console.WriteLine(player2.Name + " has " + player2.CardCount + " cards");

                Player battleWinner = Battle();

                Console.WriteLine(battleWinner.Name + " wins the battle!");
                winner.Text = battleWinner.Name + " Wins!";
                winner.Visible = true;

                if (player1.CardCount == 0)
                {
                    warWinner = player2;
                }

                if (player2.CardCount == 0)
                {
                    warWinner = player1;
                }

                if (warWinner != null)
                {
                    Console.WriteLine(warWinner.Name + " won the war!");
                    winner.Text = warWinner.Name + " won the war!";
                    button1.Text = playAgainText;

                }
                Console.WriteLine();
            }
            
        }
    }
}
