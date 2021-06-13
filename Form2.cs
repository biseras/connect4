using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekttt
{
    public partial class Form2 : Form
    {
        bool proveri;
        int plusedn;

        void neklikajvekje()
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
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;






        }

        void score()
        {
            if(button1.BackColor==Color.LightGreen && button2.BackColor==Color.LightGreen && button3.BackColor==Color.LightGreen && button4.BackColor==Color.LightGreen)
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
                button3.BackColor = Color.Blue;
                button4.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }

            if (button3.BackColor == Color.LightGreen && button5.BackColor == Color.LightGreen && button9.BackColor == Color.LightGreen && button13.BackColor == Color.LightGreen)
            {
                button3.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button9.BackColor = Color.Blue;
                button13.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button3.BackColor == Color.LightGreen && button6.BackColor == Color.LightGreen && button11.BackColor == Color.LightGreen && button16.BackColor == Color.LightGreen)
            {
                button3.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;
                button11.BackColor = Color.Blue;
                button16.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button4.BackColor == Color.LightGreen && button6.BackColor == Color.LightGreen && button10.BackColor == Color.LightGreen && button14.BackColor == Color.LightGreen)
            {
                button4.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;
                button10.BackColor = Color.Blue;
                button14.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button2.BackColor == Color.LightGreen && button7.BackColor == Color.LightGreen && button11.BackColor == Color.LightGreen && button15.BackColor == Color.LightGreen)
            {
                button2.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
                button11.BackColor = Color.Blue;
                button15.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button1.BackColor == Color.LightGreen && button8.BackColor == Color.LightGreen && button12.BackColor == Color.LightGreen && button16.BackColor == Color.LightGreen)
            {
                button1.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;
                button12.BackColor = Color.Blue;
                button16.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button20.BackColor == Color.LightGreen && button21.BackColor == Color.LightGreen && button22.BackColor == Color.LightGreen && button23.BackColor == Color.LightGreen)
            {
                button20.BackColor = Color.Blue;
                button21.BackColor = Color.Blue;
                button22.BackColor = Color.Blue;
                button23.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button4.BackColor == Color.LightGreen && button2.BackColor == Color.LightGreen && button1.BackColor == Color.LightGreen && button20.BackColor == Color.LightGreen)
            {
                button4.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
                button1.BackColor = Color.Blue;
                button20.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button5.BackColor == Color.LightGreen && button6.BackColor == Color.LightGreen && button7.BackColor == Color.LightGreen && button8.BackColor == Color.LightGreen)
            {
                button5.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button6.BackColor == Color.LightGreen && button7.BackColor == Color.LightGreen && button8.BackColor == Color.LightGreen && button21.BackColor == Color.LightGreen)
            {
                button6.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;
                button21.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button9.BackColor == Color.LightGreen && button10.BackColor == Color.LightGreen && button11.BackColor == Color.LightGreen && button12.BackColor == Color.LightGreen)
            {
                button9.BackColor = Color.Blue;
                button10.BackColor = Color.Blue;
                button11.BackColor = Color.Blue;
                button12.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button10.BackColor == Color.LightGreen && button11.BackColor == Color.LightGreen && button12.BackColor == Color.LightGreen && button22.BackColor == Color.LightGreen)
            {
                button10.BackColor = Color.Blue;
                button11.BackColor = Color.Blue;
                button12.BackColor = Color.Blue;
                button22.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button13.BackColor == Color.LightGreen && button14.BackColor == Color.LightGreen && button15.BackColor == Color.LightGreen && button16.BackColor == Color.LightGreen)
            {
                button13.BackColor = Color.Blue;
                button14.BackColor = Color.Blue;
                button15.BackColor = Color.Blue;
                button16.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button4.BackColor == Color.LightGreen && button7.BackColor == Color.LightGreen && button12.BackColor == Color.LightGreen && button23.BackColor == Color.LightGreen)
            {
                button4.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
                button12.BackColor = Color.Blue;
                button23.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button1.BackColor == Color.LightGreen && button7.BackColor == Color.LightGreen && button10.BackColor == Color.LightGreen && button13.BackColor == Color.LightGreen)
            {
                button1.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
                button10.BackColor = Color.Blue;
                button13.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button20.BackColor == Color.LightGreen && button8.BackColor == Color.LightGreen && button11.BackColor == Color.LightGreen && button14.BackColor == Color.LightGreen)
            {
                button20.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;
                button11.BackColor = Color.Blue;
                button14.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player1", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }





            if (button1.BackColor == Color.Orange && button2.BackColor == Color.Orange && button3.BackColor == Color.Orange && button4.BackColor == Color.Orange)
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
                button3.BackColor = Color.Blue;
                button4.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }

            if (button3.BackColor == Color.Orange && button5.BackColor == Color.Orange && button9.BackColor == Color.Orange && button13.BackColor == Color.Orange)
            {
                button3.BackColor = Color.Blue;
                button5.BackColor = Color.Blue;
                button9.BackColor = Color.Blue;
                button13.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button3.BackColor == Color.Orange && button6.BackColor == Color.Orange && button11.BackColor == Color.Orange && button16.BackColor == Color.Orange)
            {
                button3.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;
                button11.BackColor = Color.Blue;
                button16.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button4.BackColor == Color.Orange && button6.BackColor == Color.Orange && button10.BackColor == Color.Orange && button14.BackColor == Color.Orange)
            {
                button4.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;
                button10.BackColor = Color.Blue;
                button14.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button2.BackColor == Color.Orange && button7.BackColor == Color.Orange && button11.BackColor == Color.Orange && button15.BackColor == Color.Orange)
            {
                button2.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
                button11.BackColor = Color.Blue;
                button15.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button1.BackColor == Color.Orange && button8.BackColor == Color.Orange && button12.BackColor == Color.Orange && button16.BackColor == Color.Orange)
            {
                button1.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;
                button12.BackColor = Color.Blue;
                button16.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button20.BackColor == Color.Orange && button21.BackColor == Color.Orange && button22.BackColor == Color.Orange && button23.BackColor == Color.Orange)
            {
                button20.BackColor = Color.Blue;
                button21.BackColor = Color.Blue;
                button22.BackColor = Color.Blue;
                button23.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button4.BackColor == Color.Orange && button2.BackColor == Color.Orange && button1.BackColor == Color.Orange && button20.BackColor == Color.Orange)
            {
                button4.BackColor = Color.Blue;
                button2.BackColor = Color.Blue;
                button1.BackColor = Color.Blue;
                button20.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button5.BackColor == Color.Orange && button6.BackColor == Color.Orange && button7.BackColor == Color.Orange && button8.BackColor == Color.Orange)
            {
                button5.BackColor = Color.Blue;
                button6.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button6.BackColor == Color.Orange && button7.BackColor == Color.Orange && button8.BackColor == Color.Orange && button21.BackColor == Color.Orange)
            {
                button6.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;
                button21.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button9.BackColor == Color.Orange && button10.BackColor == Color.Orange && button11.BackColor == Color.Orange && button12.BackColor == Color.Orange)
            {
                button9.BackColor = Color.Blue;
                button10.BackColor = Color.Blue;
                button11.BackColor = Color.Blue;
                button12.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button10.BackColor == Color.Orange && button11.BackColor == Color.Orange && button12.BackColor == Color.Orange && button22.BackColor == Color.Orange)
            {
                button10.BackColor = Color.Blue;
                button11.BackColor = Color.Blue;
                button12.BackColor = Color.Blue;
                button22.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button13.BackColor == Color.Orange && button14.BackColor == Color.Orange && button15.BackColor == Color.Orange && button16.BackColor == Color.Orange)
            {
                button13.BackColor = Color.Blue;
                button14.BackColor = Color.Blue;
                button15.BackColor = Color.Blue;
                button16.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button4.BackColor == Color.Orange && button7.BackColor == Color.Orange && button12.BackColor == Color.Orange && button23.BackColor == Color.Orange)
            {
                button4.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
                button12.BackColor = Color.Blue;
                button23.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button1.BackColor == Color.Orange && button7.BackColor == Color.Orange && button10.BackColor == Color.Orange && button13.BackColor == Color.Orange)
            {
                button1.BackColor = Color.Blue;
                button7.BackColor = Color.Blue;
                button10.BackColor = Color.Blue;
                button13.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }
            if (button20.BackColor == Color.Orange && button8.BackColor == Color.Orange && button11.BackColor == Color.Orange && button14.BackColor == Color.Orange)
            {
                button20.BackColor = Color.Blue;
                button8.BackColor = Color.Blue;
                button11.BackColor = Color.Blue;
                button14.BackColor = Color.Blue;

                MessageBox.Show("Pobednik e player2", "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusedn = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusedn+1);
                neklikajvekje();
            }


        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button1.BackColor = Color.LightGreen ;
                proveri = true;
            }
            else
            {
                button1.BackColor=Color.Orange;
                proveri = false;

            }
            score();
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button3.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button3.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button4.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button4.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button2.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button2.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button2.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button20.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button20.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button20.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button5.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button5.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button6.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button6.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button7.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button7.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button8.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button8.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button8.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button21.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button21.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button21.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button9.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button9.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button10.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button10.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button11.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button11.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button11.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button12.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button12.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button12.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button22.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button22.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button22.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button13.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button13.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button13.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button14.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button14.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button15.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button15.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button15.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button16.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button16.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button16.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (proveri == false)
            {
                button23.BackColor = Color.LightGreen;
                proveri = true;
            }
            else
            {
                button23.BackColor = Color.Orange;
                proveri = false;

            }
            score();
            button23.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

              

                label2.Text = "0";
                label4.Text = "0";

                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;
                button10.BackColor = Color.WhiteSmoke;
                button11.BackColor = Color.WhiteSmoke;
                button12.BackColor = Color.WhiteSmoke;
                button13.BackColor = Color.WhiteSmoke;
                button14.BackColor = Color.WhiteSmoke;
                button15.BackColor = Color.WhiteSmoke;
                button16.BackColor = Color.WhiteSmoke;
                button20.BackColor = Color.WhiteSmoke;
                button21.BackColor = Color.WhiteSmoke;
                button22.BackColor = Color.WhiteSmoke;
                button23.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




        }

        private void button19_Click(object sender, EventArgs e)
        {
            
                //{
                    this.Hide();
                    Form1 forma = new Form1();
                    forma.ShowDialog();

             
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;

               

                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;
                button10.BackColor = Color.WhiteSmoke;
                button11.BackColor = Color.WhiteSmoke;
                button12.BackColor = Color.WhiteSmoke;
                button13.BackColor = Color.WhiteSmoke;
                button14.BackColor = Color.WhiteSmoke;
                button15.BackColor = Color.WhiteSmoke;
                button16.BackColor = Color.WhiteSmoke;
                button20.BackColor = Color.WhiteSmoke;
                button21.BackColor = Color.WhiteSmoke;
                button22.BackColor = Color.WhiteSmoke;
                button23.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect4", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            

        }
    }
}
