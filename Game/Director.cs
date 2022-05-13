using System;
using System.Collections.Generic;

namespace CardNumberGame.Game
{
    public class Director
    {
        List<Card> cards = new List<Card>();
        bool isPlaying = true;
        int score = 0;
        int totalScore = 0;

        public Director()
        {
            for(int i = 0; i < 2; i++)
            {
                Card card = new Card();
                cards.Add(card);
            }
        }
        
        public void StartGame()
        {
            while (isPlaying)
            {
                KeepPlaying();
                GetHiLo();
            }
        }

        public void KeepPlaying()
        {
            Console.Write("Draw card? (y/n) ");
            string drawCard = Console.ReadLine();
            isPlaying = (drawCard == "y");
        }

        public void GetHiLo()
        {
                Console.WriteLine($"The card is {cards[0]}");
                char userGuess;
                Console.Write("High or Low [h/l] ");
                userGuess = Console.ReadKey().KeyChar;
                score = 300;

                if (userGuess == 'h')
                {
                    if (cards[1] > cards[0])
                    {   
                        score += 100;
                        Console.WriteLine($"The next card is {cards[1]}");
                        Console.WriteLine($"Your new score is {score}");
                    }

                    else if (cards[1] < cards[0])
                    {
                        score -= 75;
                        Console.WriteLine($"The next card is {cards[1]}");
                        Console.WriteLine($"Your new score is {score}");
                    }
                }

                else if (userGuess == 'l')
                {
                    if (cards[1] > cards[0])
                    {
                        score -= 75;
                        Console.WriteLine($"The next card is {cards[1]}");
                        Console.WriteLine($"Your new score is {score}");
                    }

                    else if (cards[1] < cards[0])
                    {
                        score += 100;
                        Console.WriteLine($"The next card is {cards[1]}");
                        Console.WriteLine($"Your new score is {score}");
                    }

            }
            
        }


    }   
}