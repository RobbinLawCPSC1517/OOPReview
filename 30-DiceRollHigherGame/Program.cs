using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_DiceRollHigherGame
{
    class Program
    {
        static Player _Player1 = new Player("Jimmy");
        static Player _Player2 = new Player("Harry");

        static void Main(string[] args)
        {
            //generate an instance of List<T> where T represents
            //the datatype of the item I am collecting
            //new causes the contructor of List<T> to executed
            //this instance's variable will be set to a List
            //at this time the List instance is empty
            List<Round> gameRounds = new List<Round>();
            string menuChoice = "";
            do
            {
                Console.WriteLine("Game Menu: \n");
                Console.WriteLine("A) Both Players Play a Round by Rolling their Dice (Two Die)");
                Console.WriteLine("B) Display Results of all Game Rounds");
                Console.WriteLine("X) Exit the Game");
                Console.Write("Enter menu choice: ");
                menuChoice = Console.ReadLine();
                Console.WriteLine("\n");
                switch (menuChoice.ToUpper())
                {
                    case "A":
                        {
                            //to record the round, one needs to generate a
                            //new instance of Round
                            Round round = new Round(_Player1, _Player2);
                            //display the results of the current turn
                            DisplayRoundResults(round);
                            Console.WriteLine("\n");
                            //if you wish an item to be in a collection you must
                            //add that item to the collection
                            gameRounds.Add(round);
                            break;
                        }
                    case "B":
                        {
                            DisplayGameResults(gameRounds);
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank you for playing. Come again.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid menu choice. Try again.");
                            break;
                        }
                }
            } while (menuChoice.ToUpper() != "X");
        }//eom

        public static void DisplayRoundResults(Round round)
        {
            Console.WriteLine(string.Format("Results: {0} rolled {1}, {2} rolled {3}. Winner: {4}",
                _Player1.PlayerName, round.Player1Value, _Player2.PlayerName, round.Player2Value, round.Winner));
        }

        public static void DisplayGameResults(List<Round> gameRounds)
        {
            Console.WriteLine("This is the complete set of Rounds for this game:\n");
            //foreach() will traverse a collection from start to end
            //the loop will automatically move to the next item in the collection
            //the syntax of the loop is (itemdatatype localitemname in collectionname)
            //this loop method is great for any type of collection of unknown length
            //this is a Do While structure
            foreach (Round round in gameRounds)
            {
                DisplayRoundResults(round); 
            }
            Console.WriteLine("\n");
        }//eom
    }//eoc
}//eon
