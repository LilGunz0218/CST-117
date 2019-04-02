using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOC4
{
    public partial class Form1 : Form
    {
        TicTacToeButton[,] grid = new TicTacToeButton[3, 3];
        bool xTurn = true;

        public Form1()
        {
            InitializeComponent();
            TicTacToeButton t_button = new TicTacToeButton();
           // this.Controls.Add(t_button);
            //t_button.Location = new Point(25, 25);
            //t_button.Location = new Point(25, 25);

            //intialize grid with buttons
            int x = 0, y = 0;
            

            for (int i = 0; i <3; i++)
            {
               
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = new TicTacToeButton();
                    this.Controls.Add(grid[i, j]);
                    grid[i, j].Location = new Point(x, y);
                    //y should change here
                    y += 100;
                    grid[i, j].Click += new EventHandler(button_Click);
                    
                }
                //x should change here
                x += 100;
                y = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool CheckForWin()
        {
            //insert logic that checks for winner

            
            //horizontal win 
            if (grid[0,0].Text != "*" && grid[0, 0].Text == grid[0, 1].Text && grid[0, 1].Text == grid[0, 2].Text)
            {
                
                return true;
            }
            else if (grid[1,0].Text != "*" && grid[1, 0].Text == grid[1, 1].Text && grid[1, 1].Text == grid[1, 2].Text)
            {
                
                return true;
            }
            else if (grid[2,0].Text != "*" && grid[2, 0].Text == grid[2, 1].Text && grid[2, 1].Text == grid[2, 2].Text)
            {
                
                return true;
            }

                //vertical win condition
            else if (grid[0,0].Text != "*" && grid[0, 0].Text == grid[1, 0].Text && grid[1, 0].Text == grid[2, 0].Text)
            {
               
                return true;
            }
            else if (grid[0,1].Text != "*" && grid[0, 1].Text == grid[1, 1].Text && grid[1, 1].Text == grid[2, 1].Text)
            {
                
                return true;
            }
            
        
            else if (grid[0,2].Text != "*" && grid[0, 2].Text == grid[1, 2].Text && grid[1, 2].Text == grid[2, 2].Text)
            {
               
                return true;
            }

            //diagonal win condition
            else if (grid[0,0].Text != "*" && grid[0, 0].Text == grid[1, 1].Text && grid[1, 1].Text == grid[2, 2].Text)
            {
                
                return true;
            }
            else if (grid[0,2].Text != "*" && grid[0, 2].Text == grid[1, 1].Text && grid[1, 1].Text == grid[2, 0].Text)
            {
                
                return true;
            }

            return false;
        }

        private void button_Click(object sender, EventArgs e)
        {

            //capture the sender
            TicTacToeButton t = (TicTacToeButton)sender;
            if ( xTurn )
            {
                t.BackColor = Color.LightGoldenrodYellow;
                t.Text = "X";
            }
            else
            {
                t.BackColor = Color.Goldenrod;
                t.Text = "O";
            }
            xTurn = !xTurn;

            if (CheckForWin())
            {
                MessageBox.Show("Winner!");
            }
        }
    }
}
