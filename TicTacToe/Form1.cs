using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool playerTurn = true;//true-X, false-O
        bool isX = true;//dali igrac1 e X ili O
        bool isOver = false;//dali e zavrsena igrata
        bool isHuman = true;//dali ke igra protiv covek ili protiv computer
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
            updateTurn();
            menuStrip1.Parent = this;
            //timer1.Start();

            //playAgaistPlayer.PerformClick();
            //playAsX.PerformClick();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "The player who succeeds in placing \nthree of their marks in a horizontal, \nvertical, or diagonal row is the winner.";
            MessageBox.Show(message, "How To Play Tic-Tac-Toe?");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (playerTurn)
            {
                if (isX)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }
            }
            else
            {
                if (!isX)
                {
                    btn.Text = "X";
                }
                else
                {
                    btn.Text = "O";
                }
            }

            btn.Enabled = false;
            turnCount++;
            checkIfFinished();

            playerTurn = !playerTurn;
            if (turnCount < 9 && !isOver)
                updateTurn();

            if (!playerTurn && !isHuman)
                computer_move();
        }

        private void updateTurn()
        {
            if (playerTurn)
            {

                PlayerName.ForeColor = Color.Black;
                OpponentName.ForeColor = Color.Silver;
            }
            else
            {
                PlayerName.ForeColor = Color.Silver;
                OpponentName.ForeColor = Color.Black;
            }
        }

        private void checkIfFinished()
        {
            bool victory = false;
            //horizontal
            if (a1.Text == a2.Text && a2.Text == a3.Text && !a1.Enabled)
                victory = true;
            if (b1.Text == b2.Text && b2.Text == b3.Text && !b1.Enabled)
                victory = true;
            if (c1.Text == c2.Text && c2.Text == c3.Text && !c1.Enabled)
                victory = true;
            //vertical
            if (a1.Text == b1.Text && b1.Text == c1.Text && !a1.Enabled)
                victory = true;
            if (a2.Text == b2.Text && b2.Text == c2.Text && !a2.Enabled)
                victory = true;
            if (a3.Text == b3.Text && b3.Text == c3.Text && !a3.Enabled)
                victory = true;
            //diag
            if (a1.Text == b2.Text && b2.Text == c3.Text && !a1.Enabled)
                victory = true;
            if (c1.Text == b2.Text && b2.Text == a3.Text && !c1.Enabled)
                victory = true;


            if (victory)
            {
                string winner = "";
                if (playerTurn)
                {
                    if (isX)
                    {
                        winner = tbPlayerName.Text;
                    }
                    else
                    {
                        winner = tbPlayerName.Text;
                    }
                }
                else
                {
                    if (!isX)
                    {
                        winner = tbOpponentName.Text;
                    }
                    else
                    {
                        winner = tbOpponentName.Text;
                    }
                }
                MessageBox.Show(winner + " is the winner. Congratulations!!");

                enableAllButtons(false);
                isOver = true;
                PlayerName.ForeColor = Color.Black;
                OpponentName.ForeColor = Color.Black;
                levelUp();
            }
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("It's a draw. Try again!");
                    PlayerName.ForeColor = Color.Black;
                    OpponentName.ForeColor = Color.Black;
                    levelUp();
                }
            }

        }

        private void levelUp()
        {
            if (isOver)
            {
                if (playerTurn)
                {
                    if (isX)
                        ptsPlayer.Text = Convert.ToString(Convert.ToInt32(ptsPlayer.Text) + 1);
                    else
                        ptsPlayer.Text = Convert.ToString(Convert.ToInt32(ptsPlayer.Text) + 1);
                }
                else
                {
                    if (isX)
                        ptsOpponent.Text = Convert.ToString(Convert.ToInt32(ptsOpponent.Text) + 1);
                    else
                        ptsOpponent.Text = Convert.ToString(Convert.ToInt32(ptsOpponent.Text) + 1);
                }
            }
            else
            {
                ptsDraw.Text = Convert.ToString(Convert.ToInt32(ptsDraw.Text) + 1);
            }
        }

        private void enableAllButtons(bool able)
        {
            a1.Enabled = able;
            a2.Enabled = able;
            a3.Enabled = able;
            b1.Enabled = able;
            b2.Enabled = able;
            b3.Enabled = able;
            c1.Enabled = able;
            c2.Enabled = able;
            c3.Enabled = able;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerTurn = isX;
            turnCount = 0;
            isOver = false;
            enableAllButtons(true);
            updateTurn();
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
            if (!isHuman && !isX)
            {
                computer_move();
            }
        }

        private void playAsX_Click(object sender, EventArgs e)
        {
            playAsX.ForeColor = Color.Black;
            playAsO.ForeColor = Color.Silver;
            isX = true;
            playerTurn = true;
        }

        private void playAsO_Click(object sender, EventArgs e)
        {
            playAsX.ForeColor = Color.Silver;
            playAsO.ForeColor = Color.Black;
            isX = false;
            playerTurn = false;
        }

        private void playAgaistPlayer_Click(object sender, EventArgs e)
        {
            playAgainstComputer.ForeColor = Color.Silver;
            playAgaistPlayer.ForeColor = Color.Black;
            isHuman = true;
            lblOpponentName.Visible = true;
            tbOpponentName.Visible = true;
        }

        private void playAgainstComputer_Click(object sender, EventArgs e)
        {
            playAgainstComputer.ForeColor = Color.Black;
            playAgaistPlayer.ForeColor = Color.Silver;
            isHuman = false;
            lblOpponentName.Visible = false;
            tbOpponentName.Visible = false;
        }

        private void gameStart_Click(object sender, EventArgs e)
        {

            if (isHuman)
            {
                PlayerName.Text = tbPlayerName.Text;
                OpponentName.Text = tbOpponentName.Text;
            }
            else
            {
                tbOpponentName.Text = "Computer ";
                PlayerName.Text = (tbPlayerName.Text == "Player 1 ") ? "Player " : (tbPlayerName.Text + " ");
                OpponentName.Text = "Computer ";
            }
            if (isX)
            {
                PlayerName.Text = PlayerName.Text + "(X)";
                OpponentName.Text = OpponentName.Text + "(O)";
            }
            else
            {
                PlayerName.Text = PlayerName.Text + "(O)";
                OpponentName.Text = OpponentName.Text + "(X)";
            }
            updateTurn();
            panel2.Visible = false;
            if(!isX && !isHuman)
                newGameToolStripMenuItem1.PerformClick();

        }



        private void cell_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled)
            {
                if (playerTurn)
                {
                    if (isX)
                    {
                        btn.Text = "X";
                    }
                    else
                    {
                        btn.Text = "O";
                    }
                }
                else
                {
                    if (!isX)
                    {
                        btn.Text = "X";
                    }
                    else
                    {
                        btn.Text = "O";
                    }
                }
            }
        }

        private void cell_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled)
            {
                btn.Text = "";
            }
        }

        private void computer_move()
        {
            Button next = null;
            next = win_or_block(isX ? "O" : "X");

            if (next == null)
            {
                next = win_or_block(isX ? "X" : "O");
                if (next == null)
                {
                    next = corner(isX ? "O" : "X");

                    if (next == null)
                    {
                        next = anything_available();
                    }
                }
            }
            if (next != null)
                next.PerformClick();
        }

        private Button anything_available()
        {
            Console.WriteLine("Looking for open space");
            Button button = null;
            foreach (Control c in Controls)
            {
                button = c as Button;
                if (button != null)
                {
                    if (button.Text == "")
                    {
                        return button;
                    }
                }
            }
            return null;
        }

        private Button corner(string letter)
        {
            Console.WriteLine("Looking for corner");

            if (a1.Text == letter)
            {
                if (a3.Text == "")
                {
                    return a3;
                }
                if (c3.Text == "")
                {
                    return c3;
                }
                if (c1.Text == "")
                {
                    return c1;
                }
            }
            if (a3.Text == letter)
            {
                if (a1.Text == "")
                {
                    return a1;
                }
                if (c3.Text == "")
                {
                    return c3;
                }
                if (c1.Text == "")
                {
                    return c1;
                }
            }
            if (c3.Text == letter)
            {
                if (a1.Text == "")
                {
                    return a1;
                }
                if (a3.Text == "")
                {
                    return a3;
                }
                if (c1.Text == "")
                {
                    return c1;
                }
            }
            if (c1.Text == letter)
            {
                if (a1.Text == "")
                {
                    return a1;
                }
                if (a3.Text == "")
                {
                    return a3;
                }
                if (c3.Text == "")
                {
                    return c3;
                }
            }
            if (b2.Text == "")
            {
                return b2;
            }
            if (a1.Text == "")
            {
                return a1;
            }
            if (a3.Text == "")
            {
                return a3;
            }
            if (c1.Text == "")
            {
                return c1;
            }
            if (c3.Text == "")
            {
                return c3;
            }
            return null;

        }

        private Button win_or_block(string letter)
        {
            Console.WriteLine("Looking for win or block: " + letter);
            // -
            if (a1.Text == letter && a2.Text == letter && a3.Text == "")
            {
                return a3;
            }
            if (a1.Text == letter && a2.Text == "" && a3.Text == letter)
            {
                return a2;
            }
            if (a1.Text == "" && a2.Text == letter && a3.Text == letter)
            {
                return a1;
            }

            if (b1.Text == letter && b2.Text == letter && b3.Text == "")
            {
                return b3;
            }
            if (b1.Text == letter && b2.Text == "" && b3.Text == letter)
            {
                return b2;
            }
            if (b1.Text == "" && b2.Text == letter && b3.Text == letter)
            {
                return b1;
            }

            if (c1.Text == letter && c2.Text == letter && c3.Text == "")
            {
                return c3;
            }
            if (c1.Text == letter && c2.Text == "" && c3.Text == letter)
            {
                return c2;
            }
            if (c1.Text == "" && c2.Text == letter && c3.Text == letter)
            {
                return c1;
            }

            // |

            if (a1.Text == letter && b1.Text == letter && c1.Text == "")
            {
                return c1;
            }
            if (a1.Text == "" && b1.Text == letter && c1.Text == letter)
            {
                return a1;
            }
            if (a1.Text == letter && b1.Text == "" && c1.Text == letter)
            {
                return b1;
            }

            if (a2.Text == letter && b2.Text == letter && c2.Text == "")
            {
                return c2;
            }
            if (a2.Text == "" && b2.Text == letter && c2.Text == letter)
            {
                return a2;
            }
            if (a2.Text == letter && b2.Text == "" && c2.Text == letter)
            {
                return b2;
            }

            if (a3.Text == letter && b3.Text == letter && c3.Text == "")
            {
                return c3;
            }
            if (a3.Text == "" && b3.Text == letter && c3.Text == letter)
            {
                return a3;
            }
            if (a3.Text == letter && b3.Text == "" && c3.Text == letter)
            {
                return b3;
            }

            // \/

            if (a1.Text == letter && b2.Text == letter && c3.Text == "")
            {
                return c3;
            }
            if (a1.Text == "" && b2.Text == letter && c3.Text == letter)
            {
                return a1;
            }
            if (a1.Text == letter && b2.Text == "" && c3.Text == letter)
            {
                return b2;
            }

            if (a3.Text == letter && b2.Text == letter && c1.Text == "")
            {
                return c1;
            }
            if (a3.Text == "" && b2.Text == letter && c1.Text == letter)
            {
                return a3;
            }
            if (a3.Text == letter && b2.Text == "" && c1.Text == letter)
            {
                return b2;
            }

            return null;
        }

      

    }
}
