using System;

namespace CardNumberGame.Game
{
    public class Card
    {
        public int value = 0;
        public int score = 0;
    }

    public Card()
    {

    }

    public void Draw()
    {
        Random random = new Random();
        value = random.Next(1, 13);
    }

    
}