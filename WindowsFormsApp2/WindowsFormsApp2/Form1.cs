using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void reset_buttons()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;
            cross_zero = "X";
            game_over = false;
        }

        private void block_buttons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        
        private void check_win()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Enabled == false && button2.Enabled == false && button3.Enabled == false)
            {
                block_buttons();
                    button1.BackColor = Color.Gold;
                button2.BackColor = Color.Gold;
                button3.BackColor = Color.Gold;
                game_over = true;
            }else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false)
            {
                block_buttons();
                button4.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button6.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                block_buttons();
                button7.BackColor = Color.Gold;
                button8.BackColor = Color.Gold;
                button9.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Enabled == false && button4.Enabled == false && button7.Enabled == false)
            {
                block_buttons();
                button1.BackColor = Color.Gold;
                button4.BackColor = Color.Gold;
                button7.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Enabled == false && button5.Enabled == false && button8.Enabled == false)
            {
                block_buttons();
                button2.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button8.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Enabled == false && button6.Enabled == false && button9.Enabled == false)
            {
                block_buttons();
                button3.BackColor = Color.Gold;
                button6.BackColor = Color.Gold;
                button9.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Enabled == false && button5.Enabled == false && button9.Enabled == false)
            {
                block_buttons();
                button1.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button9.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Enabled == false && button5.Enabled == false && button7.Enabled == false)
            {
                block_buttons();
                button3.BackColor = Color.Gold;
                button5.BackColor = Color.Gold;
                button7.BackColor = Color.Gold;
                game_over = true;
            }
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                label1.Text = "ничья";
            }
            if ( game_over==true && label1.Text == string.Empty)
            {
                if (cross_zero == "X")
                {
                    label1.Text = "Победил игрок X";
                }else { label1.Text = "Победил игрок O"; }
            }
        }

        string cross_zero = "X";
        bool game_over = false;

        private void button1_Click(object sender, EventArgs e)//1 1
        {
            if (cross_zero == "X")
            {
                cross_zero = "O";
            }else if (cross_zero == "O")
            {
                cross_zero = "X";
            }
            button1.Text = cross_zero;
            button1.Enabled = false;
            check_win();
        }

        private void button2_Click(object sender, EventArgs e)//1 2
        {
            if (cross_zero == "X")
            {
                cross_zero = "O";
            }
            else if (cross_zero == "O")
            {
                cross_zero = "X";
            }
            button2.Text = cross_zero;
            button2.Enabled = false;
            check_win();
        }

        private void button3_Click(object sender, EventArgs e)//1 3
        {
            if (cross_zero == "X")
            {
                cross_zero = "O";
            }
            else if (cross_zero == "O")
            {
                cross_zero = "X";
            }
            button3.Text = cross_zero;
            button3.Enabled = false;
            check_win();
        }

        private void button4_Click(object sender, EventArgs e)//2 1 
        {
            if (cross_zero == "X")
            {
                cross_zero = "O";
            }
            else if (cross_zero == "O")
            {
                cross_zero = "X";
            }
            button4.Text = cross_zero;
            button4.Enabled = false;
            check_win();
        }

        private void button5_Click(object sender, EventArgs e)//2 2
        {
            if (cross_zero == "X")
            {
                cross_zero = "O";
            }
            else if (cross_zero == "O")
            {
                cross_zero = "X";
            }
            button5.Text = cross_zero;
            button5.Enabled = false;
            check_win();
        }

        private void button6_Click(object sender, EventArgs e)//2 3 
        {
            if (cross_zero == "X")
            {
                cross_zero = "O";
            }
            else if (cross_zero == "O")
            {
                cross_zero = "X";
            }
            button6.Text = cross_zero;
            button6.Enabled = false;
            check_win();
        }

        private void button7_Click(object sender, EventArgs e)//3 1
        {
            if (cross_zero == "X")
            {
                cross_zero = "O";
            }
            else if (cross_zero == "O")
            {
                cross_zero = "X";
            }
            button7.Text = cross_zero;
            button7.Enabled = false;
            check_win();
        }

        private void button8_Click(object sender, EventArgs e)//3 2
        {
            if (cross_zero == "X")
            {
                cross_zero = "O";
            }
            else if (cross_zero == "O")
            {
                cross_zero = "X";
            }
            button8.Text = cross_zero;
            button8.Enabled = false;
            check_win();
        }

        private void button9_Click(object sender, EventArgs e)//3 3
        {
            if (cross_zero == "X")
            {
                cross_zero = "O";
            }
            else if (cross_zero == "O")
            {
                cross_zero = "X";
            }
            button9.Text = cross_zero;
            button9.Enabled = false;
            check_win();
        }

        private void button10_Click(object sender, EventArgs e)//reset
        {
            reset_buttons();
            label1.Text = string.Empty;
        }
    }
}
