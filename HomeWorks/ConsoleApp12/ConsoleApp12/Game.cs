using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public List<Karta> Cards { get; set; }

        public Game()
        {
            const int cardStart = 6;
            const int cardEnd = 15;
            const int cardTypeStart = 0;
            const int cardTypeEnd = 4;

            Random random = new Random();

            Players = new List<Player>();
            Player player1 = new Player();
            Player player2 = new Player();

            Cards = new List<Karta>();
            List<Karta> list = new List<Karta>();

            for (int i = cardStart; i < cardEnd; i++)
            {
                for (int j = cardTypeStart; j < cardTypeEnd; j++)
                {
                    list.Add(new Karta { CardLevel = i, CardType = j });
                }
            }


            //shuffle
            for (int i = 0; i < 36; i++)
            {
                int randomIndex = random.Next(0, list.Count);
                Karta card = list.ElementAt(randomIndex);
                list.RemoveAt(randomIndex);
                Cards.Add(card);
            }

            //cards for player1
            for (int i = 0; i < 18; i++)
            {
                int randomIndex = random.Next(0, Cards.Count);
                Karta card = Cards.ElementAt(randomIndex);
                Cards.RemoveAt(randomIndex);
                player1.Cards.Add(card);
            }

            //cards for player2
            player2.Cards.InsertRange(0, Cards);

            Players.Add(player1);
            Players.Add(player2);

        }
        public void Play()
        {
            bool isGameOver = false;
            do
            {
                Dictionary<Player, Karta> playerCard = new Dictionary<Player, Karta>();


                foreach (var player in Players)
                {
                    playerCard.Add(player, player.Cards.First());
                    player.Cards.RemoveAt(0);
                }

                int maxCard = playerCard.Max(card => card.Value.CardLevel);

                Player firstWinPlayer = (playerCard.First(card => card.Value.CardLevel == maxCard).Key);

                foreach (var player1 in playerCard)
                {
                    firstWinPlayer.Cards.Add(player1.Value);
                }


                foreach (var player in Players)
                {
                    if (player.Cards.Count == 36)
                    {
                        isGameOver = true;
                        Console.WriteLine(player.Name + " WON!");
                        break;
                    }
                }

            } while (!isGameOver);
        }
    }
}
