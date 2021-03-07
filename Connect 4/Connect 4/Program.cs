using System;

namespace Connect_4
{
    class Program
    {
        // computer's board, that computer checks if someone wins
        static string[] BoardColumn1 = { "a", "b", "c", "d", "e", "f" };
        static string[] BoardColumn2 = { "g", "h", "i", "j", "k", "l" };
        static string[] BoardColumn3 = { "m", "n", "p", "p", "q", "r" };
        static string[] BoardColumn4 = { "t", "u", "v", "w", "i", "y" };
        static string[] BoardColumn5 = { "z", "1", "2", "3", "4", "5" };
        static string[] BoardColumn6 = { "6", "7", "8", "9", "0", "(" };
        static string[] BoardColumn7 = { ")", "-", "_ ", "+", "=", "}" };

        // what the user sees
        static string[] UserBoardColumn1 = { " ", " ", " ", " ", " ", " " };
        static string[] UserBoardColumn2 = { " ", " ", " ", " ", " ", " " };
        static string[] UserBoardColumn3 = { " ", " ", " ", " ", " ", " " };
        static string[] UserBoardColumn4 = { " ", " ", " ", " ", " ", " " };
        static string[] UserBoardColumn5 = { " ", " ", " ", " ", " ", " " };
        static string[] UserBoardColumn6 = { " ", " ", " ", " ", " ", " " };
        static string[] UserBoardColumn7 = { " ", " ", " ", " ", " ", " " };

        static int turn = 0;
        static bool playing = true;

        static void Main(string[] args)
        {
            Intro();

            while (playing) //stops the game once someone wins
            {
                Board(); 

                if (turn % 2 == 0) // tells whose turn it is
                {
                    Console.WriteLine("Player 1's turn");
                }
                else 
                {
                    Console.WriteLine("Player 2's turn");
                }

                int UserChoice;
                Console.WriteLine("Type the number you want your token to go in or type restart to restart"); //takes user input
                bool IsChoiceInt = int.TryParse(Console.ReadLine(), out UserChoice);

                if (IsChoiceInt) //checks if is correct input
                {
                    if (UserChoice == 1) // checks if someone wants to put the token in 1 and puts it there
                    {
                        int EmptyLocation = Array.IndexOf(UserBoardColumn1, " ");
                        if (EmptyLocation == -1)
                        {
                            Console.WriteLine("Stop trying to steal other people's places");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else if (turn % 2 == 0)
                        {
                            turn++;
                            BoardColumn1[EmptyLocation] = "o";
                            UserBoardColumn1[EmptyLocation] = "o";
                        }
                        else
                        {
                            turn++;
                            BoardColumn1[EmptyLocation] = "x";
                            UserBoardColumn1[EmptyLocation] = "x";
                        }
                        Board();
                        VerticalWinCondition();
                        HorizontalWinCondition();
                        DiagonalWin();
                        IsTieGame();
                    }
                    else if (UserChoice == 2) // checks if someone wants to put the token in 2 and puts it there
                    {
                        int EmptyLocation = Array.IndexOf(UserBoardColumn2, " ");
                        if (EmptyLocation == -1)
                        {
                            Console.WriteLine("Stop trying to steal other people's places");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else if (turn % 2 == 0)
                        {
                            turn++;
                            BoardColumn2[EmptyLocation] = "o";
                            UserBoardColumn2[EmptyLocation] = "o";
                        }
                        else
                        {
                            turn++;
                            BoardColumn2[EmptyLocation] = "x";
                            UserBoardColumn2[EmptyLocation] = "x";
                        }
                        Board();
                        VerticalWinCondition();
                        HorizontalWinCondition();
                        DiagonalWin();
                        IsTieGame();
                    }
                    else if (UserChoice == 3) // checks if someone wants to put the token in 3 and puts it there
                    {
                        int EmptyLocation = Array.IndexOf(UserBoardColumn3, " ");
                        if (EmptyLocation == -1)
                        {
                            Console.WriteLine("Stop trying to steal other people's places");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else if (turn % 2 == 0)
                        {
                            turn++;
                            BoardColumn3[EmptyLocation] = "o";
                            UserBoardColumn3[EmptyLocation] = "o";
                        }
                        else
                        {
                            turn++;
                            BoardColumn3[EmptyLocation] = "x";
                            UserBoardColumn3[EmptyLocation] = "x";
                        }
                        Board();
                        VerticalWinCondition();
                        HorizontalWinCondition();
                        DiagonalWin();
                        IsTieGame();
                    }
                    else if (UserChoice == 4) // checks if someone wants to put the token in 4 and puts it there
                    {
                        int EmptyLocation = Array.IndexOf(UserBoardColumn4, " ");
                        if (EmptyLocation == -1)
                        {
                            Console.WriteLine("Stop trying to steal other people's places");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else if (turn % 2 == 0)
                        {
                            turn++;
                            BoardColumn4[EmptyLocation] = "o";
                            UserBoardColumn4[EmptyLocation] = "o";
                        }
                        else
                        {
                            turn++;
                            BoardColumn4[EmptyLocation] = "x";
                            UserBoardColumn4[EmptyLocation] = "x";
                        }
                        Board();
                        VerticalWinCondition();
                        HorizontalWinCondition();
                        DiagonalWin();
                        IsTieGame();
                    }
                    else if (UserChoice == 5) // checks if someone wants to put the token in 5 and puts it there
                    {
                        int EmptyLocation = Array.IndexOf(UserBoardColumn5, " ");
                        if (EmptyLocation == -1)
                        {
                            Console.WriteLine("Stop trying to steal other people's places");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else if (turn % 2 == 0)
                        {
                            turn++;
                            BoardColumn5[EmptyLocation] = "o";
                            UserBoardColumn5[EmptyLocation] = "o";
                        }
                        else
                        {
                            turn++;
                            BoardColumn5[EmptyLocation] = "x";
                            UserBoardColumn5[EmptyLocation] = "x";
                        }
                        Board();
                        VerticalWinCondition();
                        HorizontalWinCondition();
                        DiagonalWin();
                        IsTieGame();
                    }
                    else if (UserChoice == 6) // checks if someone wants to put the token in 6 and puts it there
                    {
                        int EmptyLocation = Array.IndexOf(UserBoardColumn6, " ");
                        if (EmptyLocation == -1)
                        {
                            Console.WriteLine("Stop trying to steal other people's places");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else if (turn % 2 == 0)
                        {
                            turn++;
                            BoardColumn6[EmptyLocation] = "o";
                            UserBoardColumn6[EmptyLocation] = "o";
                        }
                        else
                        {
                            turn++;
                            BoardColumn6[EmptyLocation] = "x";
                            UserBoardColumn6[EmptyLocation] = "x";
                        }
                        Board();
                        VerticalWinCondition();
                        HorizontalWinCondition();
                        DiagonalWin();
                        IsTieGame();
                    }
                    else if (UserChoice == 7)// checks if someone wants to put the token in 7 and put it there
                    {
                        int EmptyLocation = Array.IndexOf(UserBoardColumn7, " ");
                        if (EmptyLocation == -1)
                        {
                            Console.WriteLine("Stop trying to steal other people's places");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else if (turn % 2 == 0)
                        {
                            turn++;
                            BoardColumn7[EmptyLocation] = "o";
                            UserBoardColumn7[EmptyLocation] = "o";
                        }
                        else
                        {
                            turn++;
                            BoardColumn7[EmptyLocation] = "x";
                            UserBoardColumn7[EmptyLocation] = "x";
                        }
                        Board();
                        VerticalWinCondition();
                        HorizontalWinCondition();
                        DiagonalWin();
                        IsTieGame();
                    }
                    else if (UserChoice > 7 || UserChoice < 0) //error check
                    {
                        Console.WriteLine("Please input a valid number, the valid numbers are 1, 2, 3, 4, 5, 6, 7");
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                else //error check
                {
                    Console.WriteLine("Please input a valid number, the valid numbers are 1, 2, 3, 4, 5, 6, 7");
                    System.Threading.Thread.Sleep(2000);
                }

            }
        }

        static void Board() //makes the board
        {
            Console.Clear();
            Console.WriteLine("  1   2   3   4   5   6   7");
            Console.WriteLine($"| {UserBoardColumn1[5]} | {UserBoardColumn2[5]} | {UserBoardColumn3[5]} | {UserBoardColumn4[5]} | {UserBoardColumn5[5]} | {UserBoardColumn6[5]} | {UserBoardColumn7[5]} |");
            Console.WriteLine($"| {UserBoardColumn1[4]} | {UserBoardColumn2[4]} | {UserBoardColumn3[4]} | {UserBoardColumn4[4]} | {UserBoardColumn5[4]} | {UserBoardColumn6[4]} | {UserBoardColumn7[4]} |");
            Console.WriteLine($"| {UserBoardColumn1[3]} | {UserBoardColumn2[3]} | {UserBoardColumn3[3]} | {UserBoardColumn4[3]} | {UserBoardColumn5[3]} | {UserBoardColumn6[3]} | {UserBoardColumn7[3]} |");
            Console.WriteLine($"| {UserBoardColumn1[2]} | {UserBoardColumn2[2]} | {UserBoardColumn3[2]} | {UserBoardColumn4[2]} | {UserBoardColumn5[2]} | {UserBoardColumn6[2]} | {UserBoardColumn7[2]} |");
            Console.WriteLine($"| {UserBoardColumn1[1]} | {UserBoardColumn2[1]} | {UserBoardColumn3[1]} | {UserBoardColumn4[1]} | {UserBoardColumn5[1]} | {UserBoardColumn6[1]} | {UserBoardColumn7[1]} |");
            Console.WriteLine($"| {UserBoardColumn1[0]} | {UserBoardColumn2[0]} | {UserBoardColumn3[0]} | {UserBoardColumn4[0]} | {UserBoardColumn5[0]} | {UserBoardColumn6[0]} | {UserBoardColumn7[0]} |");
            Console.WriteLine("-----------------------------");
        }
        static void VerticalWinCondition() //checks if someone won vertially
        {
            if (BoardColumn1[0] == BoardColumn1[1] && BoardColumn1[0] == BoardColumn1[2] && BoardColumn1[0] == BoardColumn1[3] || BoardColumn1[1] == BoardColumn1[2] && BoardColumn1[1] == BoardColumn1[3] && BoardColumn1[1] == BoardColumn1[4] || BoardColumn1[2] == BoardColumn1[3] && BoardColumn1[2] == BoardColumn1[4] && BoardColumn1[2] == BoardColumn1[5])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn2[0] == BoardColumn2[1] && BoardColumn2[0] == BoardColumn2[2] && BoardColumn2[0] == BoardColumn2[3] || BoardColumn2[1] == BoardColumn2[2] && BoardColumn2[1] == BoardColumn2[3] && BoardColumn2[1] == BoardColumn2[4] || BoardColumn2[2] == BoardColumn2[3] && BoardColumn2[2] == BoardColumn2[4] && BoardColumn2[2] == BoardColumn2[5])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn3[0] == BoardColumn3[1] && BoardColumn3[1] == BoardColumn3[2] && BoardColumn3[2] == BoardColumn3[3] || BoardColumn3[1] == BoardColumn3[2] && BoardColumn3[1] == BoardColumn3[3] && BoardColumn3[1] == BoardColumn3[4] || BoardColumn3[2] == BoardColumn3[3] && BoardColumn3[2] == BoardColumn3[4] && BoardColumn3[2] == BoardColumn3[5])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn4[0] == BoardColumn4[1] && BoardColumn4[1] == BoardColumn4[2] && BoardColumn4[0] == BoardColumn4[3] || BoardColumn4[1] == BoardColumn4[2] && BoardColumn4[1] == BoardColumn4[3] && BoardColumn4[1] == BoardColumn4[4] || BoardColumn4[2] == BoardColumn4[3] && BoardColumn4[2] == BoardColumn4[4] && BoardColumn4[2] == BoardColumn4[5])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn5[0] == BoardColumn5[1] && BoardColumn5[1] == BoardColumn5[2] && BoardColumn5[2] == BoardColumn5[3] || BoardColumn5[1] == BoardColumn5[2] && BoardColumn5[1] == BoardColumn5[3] && BoardColumn5[1] == BoardColumn5[4] || BoardColumn5[2] == BoardColumn5[3] && BoardColumn5[2] == BoardColumn5[4] && BoardColumn5[2] == BoardColumn5[5])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn6[0] == BoardColumn6[1] && BoardColumn6[1] == BoardColumn6[2] && BoardColumn6[2] == BoardColumn6[3] || BoardColumn6[1] == BoardColumn6[2] && BoardColumn6[1] == BoardColumn6[3] && BoardColumn6[1] == BoardColumn6[4] || BoardColumn6[2] == BoardColumn6[3] && BoardColumn6[2] == BoardColumn6[4] && BoardColumn6[2] == BoardColumn6[5])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn7[0] == BoardColumn7[1] && BoardColumn7[1] == BoardColumn7[2] && BoardColumn7[2] == BoardColumn7[3] || BoardColumn7[1] == BoardColumn7[2] && BoardColumn7[1] == BoardColumn7[3] && BoardColumn7[1] == BoardColumn7[4] || BoardColumn7[2] == BoardColumn7[3] && BoardColumn7[2] == BoardColumn7[4] && BoardColumn7[2] == BoardColumn7[5])
            {
                playing = false;
                Winner();
            }
        }
        static void HorizontalWinCondition() // checks if soemone won horizontally
        {
            if (BoardColumn1[0] == BoardColumn2[0] && BoardColumn1[0] == BoardColumn3[0] && BoardColumn1[0] == BoardColumn4[0])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn1[1] == BoardColumn2[1] && BoardColumn1[1] == BoardColumn3[1] && BoardColumn1[1] == BoardColumn4[1])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn1[2] == BoardColumn2[2] && BoardColumn1[2] == BoardColumn3[2] && BoardColumn1[2] == BoardColumn4[2])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn1[3] == BoardColumn2[3] && BoardColumn1[3] == BoardColumn3[3] && BoardColumn1[3] == BoardColumn4[3])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn1[4] == BoardColumn2[4] && BoardColumn1[4] == BoardColumn3[4] && BoardColumn1[4] == BoardColumn4[4])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn1[5] == BoardColumn2[5] && BoardColumn1[5] == BoardColumn3[5] && BoardColumn1[5] == BoardColumn4[5])
            {
                playing = false;
                Winner();
            }
        }
        static void DiagonalWin() //checks if a player won diagonally
        {
            if (BoardColumn1[0] == BoardColumn2[1] && BoardColumn1[0] == BoardColumn3[2] && BoardColumn1[0] == BoardColumn4[3] || BoardColumn1[1] == BoardColumn2[2] && BoardColumn1[1] == BoardColumn3[3] && BoardColumn1[1] == BoardColumn4[4] || BoardColumn1[2] == BoardColumn2[3] && BoardColumn1[2] == BoardColumn3[4] && BoardColumn1[2] == BoardColumn4[5])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn1[5] == BoardColumn2[4] && BoardColumn1[5] == BoardColumn3[3] && BoardColumn1[5] == BoardColumn4[2] || BoardColumn1[4] == BoardColumn2[3] && BoardColumn1[4] == BoardColumn3[2] && BoardColumn1[4] == BoardColumn4[1] || BoardColumn1[3] == BoardColumn2[2] && BoardColumn1[3] == BoardColumn3[1] && BoardColumn1[3] == BoardColumn4[0])
            {
                playing = false;
                Winner();
            }

            else if (BoardColumn2[0] == BoardColumn3[1] && BoardColumn2[0] == BoardColumn4[2] && BoardColumn2[0] == BoardColumn5[3] || BoardColumn2[1] == BoardColumn3[2] && BoardColumn2[1] == BoardColumn4[3] && BoardColumn2[1] == BoardColumn5[4] || BoardColumn2[2] == BoardColumn3[3] && BoardColumn4[2] == BoardColumn2[4] && BoardColumn2[2] == BoardColumn5[5])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn2[5] == BoardColumn3[4] && BoardColumn2[5] == BoardColumn4[3] && BoardColumn2[5] == BoardColumn5[2] || BoardColumn2[4] == BoardColumn3[3] && BoardColumn2[4] == BoardColumn4[2] && BoardColumn2[4] == BoardColumn5[1] || BoardColumn2[3] == BoardColumn3[2] && BoardColumn4[3] == BoardColumn2[1] && BoardColumn2[3] == BoardColumn5[0])
            {
                playing = false;
                Winner();
            }

            else if (BoardColumn3[0] == BoardColumn4[1] && BoardColumn3[0] == BoardColumn5[2] && BoardColumn3[0] == BoardColumn6[3] || BoardColumn3[1] == BoardColumn4[2] && BoardColumn3[1] == BoardColumn5[3] && BoardColumn3[1] == BoardColumn6[4] || BoardColumn3[2] == BoardColumn4[3] && BoardColumn3[2] == BoardColumn5[4] && BoardColumn3[2] == BoardColumn6[5])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn3[5] == BoardColumn4[4] && BoardColumn3[5] == BoardColumn5[3] && BoardColumn3[5] == BoardColumn6[2] || BoardColumn3[4] == BoardColumn4[3] && BoardColumn3[4] == BoardColumn5[2] && BoardColumn3[4] == BoardColumn6[1] || BoardColumn3[3] == BoardColumn4[2] && BoardColumn3[3] == BoardColumn5[1] && BoardColumn3[3] == BoardColumn6[0])
            {
                playing = false;
                Winner();
            }

            else if (BoardColumn4[0] == BoardColumn5[1] && BoardColumn4[0] == BoardColumn6[2] && BoardColumn4[0] == BoardColumn7[3] || BoardColumn4[1] == BoardColumn5[2] && BoardColumn4[1] == BoardColumn6[3] && BoardColumn4[1] == BoardColumn7[4] || BoardColumn4[2] == BoardColumn5[3] && BoardColumn4[2] == BoardColumn6[4] && BoardColumn4[2] == BoardColumn7[5])
            {
                playing = false;
                Winner();
            }
            else if (BoardColumn4[5] == BoardColumn5[4] && BoardColumn4[5] == BoardColumn6[3] && BoardColumn4[5] == BoardColumn7[2] || BoardColumn4[4] == BoardColumn5[3] && BoardColumn4[4] == BoardColumn6[2] && BoardColumn4[4] == BoardColumn7[1] || BoardColumn4[3] == BoardColumn5[2] && BoardColumn4[3] == BoardColumn6[1] && BoardColumn4[3] == BoardColumn7[0])
            {
                playing = false;
                Winner();
            }
        }

        static void IsTieGame() //checks if game is tie
        {
            int TieCheker1 = Array.IndexOf(UserBoardColumn1, " ");
            int TieCheker2 = Array.IndexOf(UserBoardColumn2, " ");
            int TieCheker3 = Array.IndexOf(UserBoardColumn3, " ");
            int TieCheker4 = Array.IndexOf(UserBoardColumn4, " ");
            int TieCheker5 = Array.IndexOf(UserBoardColumn5, " ");
            int TieCheker6 = Array.IndexOf(UserBoardColumn6, " ");
            int TieCheker7 = Array.IndexOf(UserBoardColumn7, " ");

            if (TieCheker1 == -1 && TieCheker2 == -1 && TieCheker3 == -1 && TieCheker4 == -1 && TieCheker5 == -1 && TieCheker6 == -1 && TieCheker7 == -1)
            {
                playing = false;
                Tie();
            }
        }

        static void Intro() //Intro
        {
            Console.WriteLine("Welcome to");
            Console.WriteLine(@"  ______   ______   .__   __. .__   __.  _______   ______ .___________.    _  _    ");
            Console.WriteLine(@" /      | /  __  \  |  \ |  | |  \ |  | |   ____| /      ||           |   | || |   ");
            Console.WriteLine(@"|  ,----'|  |  |  | |   \|  | |   \|  | |  |__   |  ,----'`---|  |----`   | || |_  ");
            Console.WriteLine(@"|  |     |  |  |  | |  . `  | |  . `  | |   __|  |  |         |  |        |__   _| ");
            Console.WriteLine(@"|  `----.|  `--'  | |  |\   | |  |\   | |  |____ |  `----.    |  |           | |   ");
            Console.WriteLine(@" \______| \______/  |__| \__| |__| \__| |_______| \______|    |__|           |_|   ");
            Console.WriteLine("\nPress a Key to begin");
            Console.ReadKey();
            Console.Clear();
            Rules();
        }
        static void Rules() //Rules
        {
            Console.WriteLine("How to Play:");
            Console.WriteLine("1. Choose who plays first. Player 1 will be 'o' and Player 2 will be 'x'");
            Console.WriteLine("2. Player's will alternate taking turns on putting their token in the board. You will put your token in the board by typing in the number at the top of the column you wish to put it in.  ");
            Console.WriteLine("3. The first player to get 4 tokens in a row wins. The four in a row can be horizontal, vertical or diagonal");
            Console.WriteLine("\nPress a Key to begin");
            Console.ReadKey();
        }
        static void Winner() //message when player wins game
        {
            if (turn % 2 == 0)
            {
                Console.WriteLine("Congrats on winning player 2");
            }
            else
            {
                Console.WriteLine("Congrats on winning player 1");
            }
        }
        static void Tie() //message when tie game
        {
            Console.WriteLine("The game is a tie");
        }
    }
}
