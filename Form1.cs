using System;
using CardGameLib;

namespace CardGameImpl
{
    public partial class Form1 : Form
    {
        private Card leftCard = new Card();
        private Card rightCard = new Card();
        private CardSuit trump = CardUtils.GetRandomSuit();

        public Form1()
        {
            InitializeComponent();
            comboBoxSuitLeft.DataSource = Enum.GetValues(typeof(CardSuit));
            comboBoxSuitRight.DataSource = Enum.GetValues(typeof(CardSuit));

            comboBoxValueLeft.DataSource = Enum.GetValues(typeof(CardValue));
            comboBoxValueRight.DataSource = Enum.GetValues(typeof(CardValue));
            RefreshImages();
        }

        private void buttonTry_Click(object sender, EventArgs e)
        {
            pictureBoxResult.Image = ImageMapper.MapResult(leftCard.CanBeat(rightCard, trump));
        }

        private void RefreshImages()
        {
            pictureBoxLeftCard.Image = ImageMapper.MapCard(leftCard);
            pictureBoxRightCard.Image = ImageMapper.MapCard(rightCard);
            pictureBoxTrumpSuit.Image = ImageMapper.MapSuit(trump);
        }

        private void comboBoxLeftSuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftCard.Suit = (CardSuit)((ComboBox)sender).SelectedItem;
            RefreshImages();
        }
        private void comboBoxSuitRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            rightCard.Suit = (CardSuit)((ComboBox)sender).SelectedItem;
            RefreshImages();
        }

        private void comboBoxValueLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftCard.Value = (CardValue)((ComboBox)sender).SelectedItem;
            RefreshImages();
        }

        private void comboBoxValueRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            rightCard.Value = (CardValue)((ComboBox)sender).SelectedItem;
            RefreshImages();
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            trump = CardUtils.GetRandomSuit();
            leftCard = Card.GetRandomCard();
            rightCard = Card.GetRandomCard();

            comboBoxSuitLeft.Text = leftCard.Suit.ToString();
            comboBoxSuitRight.Text = rightCard.Suit.ToString();
            comboBoxValueLeft.Text = leftCard.Value.ToString();
            comboBoxValueRight.Text = rightCard.Value.ToString();

            RefreshImages();
        }

    }
    
}