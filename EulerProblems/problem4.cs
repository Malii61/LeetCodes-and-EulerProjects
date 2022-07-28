using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems_
{
    /*The Chase is a game played with two dice and an even number of players.

    The players sit around a table and the game begins with two opposite players having one die each. On each turn, the two players with a die roll it.

    If the player rolls 1, then the die passes to the neighbour on the left.
    If the player rolls 6, then the die passes to the neighbour on the right.
    Otherwise, the player keeps the die for the next turn.

    The game ends when one player has both dice after they have been rolled and passed; that player has then lost.

    In a game with 100 players, what is the expected number of turns the game lasts?

    Give your answer rounded to ten significant digits.*/
    class problem4
    {
        public problem4() {
            List<int> gamers = new List<int>(10) { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            System.Random random = new System.Random();
            int playerA = random.Next(0, 10);
            int playerB = random.Next(0, 10);
            int die1;
            int die2;
            int turn = 0;
            while(playerA == playerB)
            {
                playerB = random.Next(0, 10);
                    
            }
            while (true)
            {
                turn++;
                die1 = random.Next(0, 6);
                die2 = random.Next(0, 6);
                
                if(die1 == 1)
                {
                    if(gamers[playerA] > 0)
                    {
                        gamers[playerA]--;
                    }
                    if(playerA == 0)
                    {
                        playerA = 9;
                        gamers[9] += 1;
                    }
                    else
                    {
                        gamers[playerA - 1] += 1;
                    }
                    playerA--;
                }
                else if(die1 == 6)
                {
                    if (gamers[playerA] > 0)
                    {
                        gamers[playerA]--;
                    }
                    if (playerA == 9)
                    {
                        playerA = 0;
                        gamers[0] += 1;
                    }
                    else
                    {
                        gamers[playerA + 1] += 1;
                    }
                    playerA++;
                }

                if (die2 == 1)
                {
                    if (gamers[playerB] > 0)
                    {
                        gamers[playerB]--;
                    }
                    if (playerB == 0)
                    {
                        playerB = 9;
                        gamers[9] += 1;
                    }
                    else
                    {
                        gamers[playerB - 1] += 1;
                    }
                    playerB--;
                }
                else if (die2 == 6)
                {
                    if (gamers[playerB] > 0)
                    {
                        gamers[playerB]--;
                    }
                    if (playerB == 9)
                    {
                        playerB = 0;
                        gamers[0] += 1;
                    }
                    else
                    {
                        gamers[playerB + 1] += 1;
                    }
                    playerB++;
                }


                if(gamers[playerA] == 2 || gamers[playerB] == 2)
                {
                    Console.WriteLine(turn + " " +  playerA + "  "+playerB +"  " + gamers[playerA] + " " + gamers[playerB]);
                    break;

                }



            }

        
        }
    }
}
