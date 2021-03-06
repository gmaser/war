﻿using System;
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
        private static readonly String winBattleSuffix = " Wins!";
        private static readonly String winWarSuffix = " won the war!";
        private static readonly String tie = "Tie!";
        private static readonly String loadingError = "Error loading decK";

        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            player1Name.Text = player1DisplayName;
            player2Name.Text = player2DisplayName;
            button1.Text = fightText;
            winner.Text = null;
            player1Card.Image = null;
            player2Card.Image = null;
            player1TieCards.Text = null;
            player2TieCards.Text = null;

            warWinner = null;

            try
            {
                CardDeck deck = LoadDeck();
                player1 = new Player(player1DisplayName, player1Card, player1DrawPile, player1TotalCards, player1TieCards);
                player2 = new Player(player2DisplayName, player2Card, player2DrawPile, player2TotalCards, player2TieCards);
                DealCards(player1, player2, deck.Shuffle());
            }
            catch (Exception)
            {
                winner.Text = loadingError;
                button1.Enabled = false;
            }
        }

        private static CardDeck LoadDeck()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CardDeck));
            return (CardDeck)serializer.Deserialize(new StringReader(Resources.standard_deck));
        }

        private static void DealCards(Player p1, Player p2, Stack<Card> shuffledDeck)
        {
            while (shuffledDeck.Count != 0)
            {
                if (shuffledDeck.Count % 2 == 0)
                {
                    p1.AddToDrawPile(shuffledDeck.Pop());
                }
                else
                {
                    p2.AddToDrawPile(shuffledDeck.Pop());
                }
            }
        }

        private void Battle()
        {
            Card player1NextCard = player1.PlayNextCard();
            Card player2NextCard = player2.PlayNextCard();

            if (player1NextCard == null)
            {
                warWinner = player2;
                return;
            }

            if (player2NextCard == null)
            {
                warWinner = player1;
                return;
            }

            if (player1NextCard.Rank > player2NextCard.Rank)
            {
                player1.WinCards(player2);
                winner.Text = player1.Name + winBattleSuffix;
            }
            else if (player2NextCard.Rank > player1NextCard.Rank)
            {
                player2.WinCards(player1);
                winner.Text = player2.Name + winBattleSuffix;
            }
            else
            {
                winner.Text = tie;
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
                Battle();

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
                    winner.Text = warWinner.Name + winWarSuffix;
                    button1.Text = playAgainText;
                }
            }
            
        }
    }
}
