using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
public class Solution
{
    public static readonly List<string> LetterCards = new List<string>() { "J", "Q", "K", "A" };
    public static int RoundCounter = 0;

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine() ?? string.Empty); // the number of cards for player 1
        var p1ListOfCards = new List<string>(n);
        for (int i = 0; i < n; i++)
        {
            string cardp1 = Console.ReadLine() ?? string.Empty; // the n cards of player 1
            p1ListOfCards.Add(cardp1);
        }

        int m = int.Parse(Console.ReadLine() ?? string.Empty); // the number of cards for player 2
        var p2ListOfCards = new List<string>(m);
        for (int i = 0; i < m; i++)
        {
            string cardp2 = Console.ReadLine() ?? string.Empty; // the m cards of player 2
            p2ListOfCards.Add(cardp2);
        }

        var player = MakeTheGame(p1ListOfCards, p2ListOfCards);

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        if (player == "PAT")
        {
            Console.WriteLine($"{player}");
        }
        else
        {
            Console.WriteLine($"{player} {RoundCounter}");
        }
    }

    public static string MakeTheGame(List<string> p1ListOfCards, List<string> p2ListOfCards)
    {
        Queue<string> p1DeckOfCards, p2DeckOfCards;

        NormalizeCards(p1ListOfCards, p2ListOfCards, out p1DeckOfCards, out p2DeckOfCards);

        var p1WarPool = new Queue<string>();
        var p2WarPool = new Queue<string>();

        while (true)
        {

            if (p1DeckOfCards.Count == 0)
            {
                return "2";
            }

            if (p2DeckOfCards.Count == 0)
            {
                return "1";
            }

            var p1Card = p1DeckOfCards.Dequeue();
            var p2Card = p2DeckOfCards.Dequeue();

            var pWinner = Battle(p1Card, p2Card);
            RoundCounter++;

            if (pWinner == 1)
            {
                p1DeckOfCards.Enqueue(p1Card);
                p1DeckOfCards.Enqueue(p2Card);
            }

            if (pWinner == 2)
            {
                p2DeckOfCards.Enqueue(p1Card);
                p2DeckOfCards.Enqueue(p2Card);
            }

            if (pWinner == 0)
            {
                do
                {
                    if (p1DeckOfCards.Count < 3 || p2DeckOfCards.Count < 3)
                    {
                        return ("PAT");
                    }

                    p1WarPool.Enqueue(p1Card);
                    p1WarPool.Enqueue(p1DeckOfCards.Dequeue());
                    p1WarPool.Enqueue(p1DeckOfCards.Dequeue());
                    p1WarPool.Enqueue(p1DeckOfCards.Dequeue());

                    p2WarPool.Enqueue(p2Card);
                    p2WarPool.Enqueue(p2DeckOfCards.Dequeue());
                    p2WarPool.Enqueue(p2DeckOfCards.Dequeue());
                    p2WarPool.Enqueue(p2DeckOfCards.Dequeue());

                    p1Card = p1DeckOfCards.Dequeue();
                    p2Card = p2DeckOfCards.Dequeue();

                    pWinner = Battle(p1Card, p2Card);

                    if (pWinner == 1)
                    {
                        while (p1WarPool.Count > 0)
                        {
                            p1DeckOfCards.Enqueue(p1WarPool.Dequeue());
                        }

                        p1DeckOfCards.Enqueue(p1Card);

                        while (p2WarPool.Count > 0)
                        {
                            p1DeckOfCards.Enqueue(p2WarPool.Dequeue());
                        }

                        p1DeckOfCards.Enqueue(p2Card);

                    }

                    if (pWinner == 2)
                    {
                        while (p1WarPool.Count > 0)
                        {
                            p2DeckOfCards.Enqueue(p1WarPool.Dequeue());
                        }

                        p2DeckOfCards.Enqueue(p1Card);

                        while (p2WarPool.Count > 0)
                        {
                            p2DeckOfCards.Enqueue(p2WarPool.Dequeue());
                        }

                        p2DeckOfCards.Enqueue(p2Card);
                    }


                } while (pWinner == 0);

            }
        }
    }

    private static void NormalizeCards(List<string> p1ListOfCards, List<string> p2ListOfCards, out Queue<string> p1DeckOfCards, out Queue<string> p2DeckOfCards)
    {
        p1DeckOfCards = new Queue<string>(p1ListOfCards.Count);
        p2DeckOfCards = new Queue<string>(p1ListOfCards.Count);

        foreach (var card in p1ListOfCards)
        {
            var cardValue = ExtractValue(card);
            p1DeckOfCards.Enqueue(cardValue);
        }

        foreach (var card in p2ListOfCards)
        {
            var cardValue = ExtractValue(card);
            p2DeckOfCards.Enqueue(cardValue);
        }
    }

    private static int Battle(string p1Card, string p2Card)
    {
        int p1Value;
        if (char.IsLetter(p1Card[0]))
        {
            p1Value = LetterCards.IndexOf(p1Card) + 11;
        }
        else
        {
            p1Value = Convert.ToInt32(p1Card);
        }

        int p2Value;
        if (char.IsLetter(p2Card[0]))
        {
            p2Value = LetterCards.IndexOf(p2Card) + 11;
        }
        else
        {
            p2Value = Convert.ToInt32(p2Card);
        }

        if (p1Value > p2Value)
        {
            return 1;
        }

        if (p1Value < p2Value)
        {
            return 2;
        }

        return 0;
    }

    public static string ExtractValue(string input)
    {
        if (input.Length >= 3)
        {
            return input[..2];
        }

        return input[0].ToString();
    }
}