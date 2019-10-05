/***************************************************************
* Student: Barbara Sullivan                                    *
* Instructor: Dr. Jerry Mamo                                   *
* Class: CIST 2341 – C# Programming – 60485 – Summer 2019      * 
* Mini-Project - Craps Game                                    *
****************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Random randomNumber = new Random();

        //Enumerators to represent Game Status
        private enum Status  
        {
            CONTINUE,
            WON,
            LOST
        }
        private enum DiceNames
        {
            SNAKE_EYES = 2,
            TREY = 3,
            SEVEN = 7,
            YO_LEVEN = 11,
            BOX_CARS = 12
        }
        // PLAY ONE GAME OF CRAP  
        public void Play()
        {
            Status gameStatus = Status.CONTINUE;
            int myPoint = 0;

            //Show the number of Points on Points Label
            lblPoints.Text = ("Points: " + myPoint.ToString());

            //Roll Dices
            int sumOfDice = RollDice();

            //Determine the results Win/Lose
            switch ((DiceNames)sumOfDice)
            {
                case DiceNames.SEVEN:
                case DiceNames.YO_LEVEN:
                    gameStatus = Status.WON;
                    break;
                case DiceNames.BOX_CARS:
                case DiceNames.SNAKE_EYES:
                case DiceNames.TREY:
                    gameStatus = Status.LOST;
                    break;
                default:
                    gameStatus = Status.CONTINUE;
                    myPoint = sumOfDice;
                    lblPoints.Text = ("Points: " + myPoint.ToString());
                    Console.WriteLine("Point is {0}", myPoint);
                    break;

            }
            while (gameStatus == Status.CONTINUE)
            {
                sumOfDice = RollDice(); // roll dice again  
                if (sumOfDice == myPoint)
                    gameStatus = Status.WON;
                if (sumOfDice == (int)DiceNames.SEVEN)
                    gameStatus = Status.LOST;
            }
            // end of while method  
            // Display won or loss  
            if (gameStatus == Status.WON)
            {
                lblDisplayResult.Text = "You Win";
                Console.WriteLine("You Win");
            }
            else
            {
                lblDisplayResult.Text = "You Lose";
                Console.WriteLine("You Lose");
            }
        }//end of method Play  

        public int RollDice()
        {
            //Assign Random numbers to Dices and Dice images according to numbers
            int die1 = new int();
            die1 = randomNumber.Next(1, 7);

            //Assign Dice 1 Image
            if (die1 == 1)
            {
                picDice1.Image = picDiceNum1.Image;
                picDice1.Visible = true;
            }
            else if (die1 == 2)
            {
                picDice1.Image = picDiceNum2.Image;
                picDice1.Visible = true;
            }
            else if (die1 == 3)
            {
                picDice1.Image = picDiceNum3.Image;
                picDice1.Visible = true;
            }
            else if (die1 == 4)
            {
                picDice1.Image = picDiceNum4.Image;
                picDice1.Visible = true;
            }
            else if (die1 == 5)
            {
                picDice1.Image = picDiceNum5.Image;
                picDice1.Visible = true;
            }
            else if (die1 == 6)
            {
                picDice1.Image = picDiceNum6.Image;
                picDice1.Visible = true;
            }

            int die2 = new int();
            die2 = randomNumber.Next(1, 7);

            //Assign Dice 2 Image
            if (die2 == 1)
                picDice2.Image = picDiceNum1.Image;
            else if (die2 == 2)
                picDice2.Image = picDiceNum2.Image;
            else if (die2 == 3)
                picDice2.Image = picDiceNum3.Image;
            else if (die2 == 4)
                picDice2.Image = picDiceNum4.Image;
            else if (die2 == 5)
                picDice2.Image = picDiceNum5.Image;
            else if (die2 == 6)
                picDice2.Image = picDiceNum6.Image;
            int sum = die1 + die2;
            lblSum.Text = ("Sum: " + sum.ToString());

            //Display result of the rolls
            String printSum = ("Player rolled " + die1.ToString() + " + " + die2.ToString() + " = " + sum.ToString());
            lblDisplayMsg.Text += (printSum + System.Environment.NewLine);
            Console.WriteLine("Player rolled {0} + {1} = {2}", die1, die2, sum);
            return sum;

        }// End method roll dice  

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Play the game when user clicks on Play
            Play();
        }

        private void btnInstr_Click(object sender, EventArgs e)
        {
            //Show instructions on how to play the game
            String title = "Instructions to play Craps";
            String message = Environment.NewLine + "The player rolls 2 dice.  If the dice lands on 7 or 11. The player wins. " + Environment.NewLine + " " + Environment.NewLine + "If the dice land on 2, 3 or 12, the player loses." + Environment.NewLine + " " + Environment.NewLine + "If any other number comes up, like 9, that number becomes the point." + Environment.NewLine + " " + Environment.NewLine + "The player will next roll as many times as necessary to either hit their point, they win, or they hit a 7, they lose." + Environment.NewLine + " " + Environment.NewLine + "If any other number comes up, the player rolls again….until they hit their point or a 7." + Environment.NewLine + " " + Environment.NewLine + "Player will click on 'Play' only once, and the computer will roll the dices automatically as needed";
            DialogResult resultabout = MessageBox.Show(message, title);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //Start a new game
            Application.Restart();
        }
    }
}

