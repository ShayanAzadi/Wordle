using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        int chance = 1;
        string[] ls = File.ReadAllLines("DATA.txt");
        string random;
        main mainWordle = new main();
        
        private void button1_Click(object sender, EventArgs e)
        {
            string word;
            if (chance == 1)
            {
                Random b = new Random();
                int a = b.Next(0, 5757);
                random = ls[a];

                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    word = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text;
                    word = word.ToLower();
                    if (mainWordle.InYesNo(ls, word))
                    {
                        string[] check = mainWordle.Check(word, random);
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                        textBox6.Enabled = true;
                        textBox7.Enabled = true;
                        textBox8.Enabled = true;
                        textBox9.Enabled = true;
                        textBox10.Enabled = true;
                        colors(check, chance);
                        if (!mainWordle.InYesNo(check, "Yellow") && !mainWordle.InYesNo(check, "Black"))
                        {
                            MessageBox.Show("Congratulation! You Won The Game :)", "You Won!");
                            label2.Text = "You Win!" + "\n" + "Congratulation!";
                            chance = 7;
                            textBox6.Enabled = false;
                            textBox7.Enabled = false;
                            textBox8.Enabled = false;
                            textBox9.Enabled = false;
                            textBox10.Enabled = false;

                            textBox11.Enabled = false;
                            textBox12.Enabled = false;
                            textBox13.Enabled = false;
                            textBox14.Enabled = false;
                            textBox15.Enabled = false;

                            textBox16.Enabled = false;
                            textBox17.Enabled = false;
                            textBox18.Enabled = false;
                            textBox19.Enabled = false;
                            textBox20.Enabled = false;

                            textBox21.Enabled = false;
                            textBox22.Enabled = false;
                            textBox23.Enabled = false;
                            textBox24.Enabled = false;
                            textBox25.Enabled = false;

                            textBox26.Enabled = false;
                            textBox27.Enabled = false;
                            textBox28.Enabled = false;
                            textBox29.Enabled = false;
                            textBox30.Enabled = false;
                            button2.Enabled = true;
                            button2.Visible = true;
                            button1.Enabled = false;
                            button1.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Word Not Found! Please Enter Another Word", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chance--;
                    }
                }
                else
                {
                    chance--;
                }
            }

            if (chance == 2)
            {
                if (textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox6.Text != "")
                {
                    word = textBox6.Text + textBox7.Text + textBox8.Text + textBox9.Text + textBox10.Text;
                    word = word.ToLower();
                    if (mainWordle.InYesNo(ls, word))
                    {
                        string[] check = mainWordle.Check(word, random);
                        textBox6.Enabled = false;
                        textBox7.Enabled = false;
                        textBox8.Enabled = false;
                        textBox9.Enabled = false;
                        textBox10.Enabled = false;
                        textBox11.Enabled = true;
                        textBox12.Enabled = true;
                        textBox13.Enabled = true;
                        textBox14.Enabled = true;
                        textBox15.Enabled = true;
                        colors(check, chance);
                        if (!mainWordle.InYesNo(check, "Yellow") && !mainWordle.InYesNo(check, "Black"))
                        {
                            MessageBox.Show("Congratulation! You Won The Game :)", "You Won!");
                            label2.Text = "You Win!" + "\n" + "Congratulation!";
                            chance = 7;
                            textBox11.Enabled = false;
                            textBox12.Enabled = false;
                            textBox13.Enabled = false;
                            textBox14.Enabled = false;
                            textBox15.Enabled = false;

                            textBox16.Enabled = false;
                            textBox17.Enabled = false;
                            textBox18.Enabled = false;
                            textBox19.Enabled = false;
                            textBox20.Enabled = false;

                            textBox21.Enabled = false;
                            textBox22.Enabled = false;
                            textBox23.Enabled = false;
                            textBox24.Enabled = false;
                            textBox25.Enabled = false;

                            textBox26.Enabled = false;
                            textBox27.Enabled = false;
                            textBox28.Enabled = false;
                            textBox29.Enabled = false;
                            textBox30.Enabled = false;
                            button2.Enabled = true;
                            button2.Visible = true;
                            button1.Enabled = false;
                            button1.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Word Not Found! Please Enter Another Word", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chance--;
                    }
                }
                else
                {
                    chance--;
                }
            }
            if (chance == 3)
            {
                if (textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "")
                {
                    word = textBox11.Text + textBox12.Text + textBox13.Text + textBox14.Text + textBox15.Text;
                    word = word.ToLower();
                    if (mainWordle.InYesNo(ls, word))
                    {
                        string[] check = mainWordle.Check(word, random);
                        textBox11.Enabled = false;
                        textBox12.Enabled = false;
                        textBox13.Enabled = false;
                        textBox14.Enabled = false;
                        textBox15.Enabled = false;
                        textBox16.Enabled = true;
                        textBox17.Enabled = true;
                        textBox18.Enabled = true;
                        textBox19.Enabled = true;
                        textBox20.Enabled = true;
                        colors(check, chance);
                        if (!mainWordle.InYesNo(check, "Yellow") && !mainWordle.InYesNo(check, "Black"))
                        {
                            MessageBox.Show("Congratulation! You Won The Game :)", "You Won!");
                            label2.Text = "You Win!" + "\n" + "Congratulation!";
                            chance = 7;
                            textBox16.Enabled = false;
                            textBox17.Enabled = false;
                            textBox18.Enabled = false;
                            textBox19.Enabled = false;
                            textBox20.Enabled = false;

                            textBox21.Enabled = false;
                            textBox22.Enabled = false;
                            textBox23.Enabled = false;
                            textBox24.Enabled = false;
                            textBox25.Enabled = false;

                            textBox26.Enabled = false;
                            textBox27.Enabled = false;
                            textBox28.Enabled = false;
                            textBox29.Enabled = false;
                            textBox30.Enabled = false;
                            button2.Enabled = true;
                            button2.Visible = true;
                            button1.Enabled = false;
                            button1.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Word Not Found! Please Enter Another Word", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chance--;
                    }
                }
                else
                {
                    chance--;
                }
            }
            if (chance == 4)
            {
                if (textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "" && textBox20.Text != "")
                {
                    word = textBox16.Text + textBox17.Text + textBox18.Text + textBox19.Text + textBox20.Text;
                    word = word.ToLower();
                    if (mainWordle.InYesNo(ls, word))
                    {
                        string[] check = mainWordle.Check(word, random);
                        textBox16.Enabled = false;
                        textBox17.Enabled = false;
                        textBox18.Enabled = false;
                        textBox19.Enabled = false;
                        textBox20.Enabled = false;
                        textBox21.Enabled = true;
                        textBox22.Enabled = true;
                        textBox23.Enabled = true;
                        textBox24.Enabled = true;
                        textBox25.Enabled = true;
                        colors(check, chance);
                        if (!mainWordle.InYesNo(check, "Yellow") && !mainWordle.InYesNo(check, "Black"))
                        {
                            MessageBox.Show("Congratulation! You Won The Game :)", "You Won!");
                            label2.Text = "You Win!" + "\n" + "Congratulation!";
                            chance = 7;
                            textBox21.Enabled = false;
                            textBox22.Enabled = false;
                            textBox23.Enabled = false;
                            textBox24.Enabled = false;
                            textBox25.Enabled = false;

                            textBox26.Enabled = false;
                            textBox27.Enabled = false;
                            textBox28.Enabled = false;
                            textBox29.Enabled = false;
                            textBox30.Enabled = false;
                            button2.Enabled = true;
                            button2.Visible = true;
                            button1.Enabled = false;
                            button1.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Word Not Found! Please Enter Another Word", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chance--;
                    }
                }
                else
                {
                    chance--;
                }
            }
            if (chance == 5)
            {
                if (textBox21.Text != "" && textBox22.Text != "" && textBox23.Text != "" && textBox24.Text != "" && textBox25.Text != "")
                {
                    word = textBox21.Text + textBox22.Text + textBox23.Text + textBox24.Text + textBox25.Text;
                    word = word.ToLower();
                    if (mainWordle.InYesNo(ls, word))
                    {
                        string[] check = mainWordle.Check(word, random);
                        textBox21.Enabled = false;
                        textBox22.Enabled = false;
                        textBox23.Enabled = false;
                        textBox24.Enabled = false;
                        textBox25.Enabled = false;
                        textBox26.Enabled = true;
                        textBox27.Enabled = true;
                        textBox28.Enabled = true;
                        textBox29.Enabled = true;
                        textBox30.Enabled = true;
                        colors(check, chance);
                        if (!mainWordle.InYesNo(check, "Yellow") && !mainWordle.InYesNo(check, "Black"))
                        {
                            chance = 7;
                            MessageBox.Show("Congratulation! You Won The Game :)", "You Won!");
                            label2.Text = "You Win!" + "\n" + "Congratulation!";
                            textBox26.Enabled = false;
                            textBox27.Enabled = false;
                            textBox28.Enabled = false;
                            textBox29.Enabled = false;
                            textBox30.Enabled = false;
                            button2.Enabled = true;
                            button2.Visible = true;
                            button1.Enabled = false;
                            button1.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Word Not Found! Please Enter Another Word", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chance--;
                    }
                }
                else
                {
                    chance--;
                }
            }
            if (chance == 6)
            {
                if (textBox26.Text != "" && textBox27.Text != "" && textBox28.Text != "" && textBox29.Text != "" && textBox30.Text != "")
                {
                    word = textBox26.Text + textBox27.Text + textBox28.Text + textBox29.Text + textBox30.Text;
                    word = word.ToLower();
                    if (mainWordle.InYesNo(ls, word))
                    {
                        string[] check = mainWordle.Check(word, random);
                        textBox26.Enabled = false;
                        textBox27.Enabled = false;
                        textBox28.Enabled = false;
                        textBox29.Enabled = false;
                        textBox30.Enabled = false;
                        button2.Enabled = true;
                        button2.Visible = true;
                        button1.Enabled = false;
                        button1.Visible = false;
                        colors(check, chance);

                        if (!mainWordle.InYesNo(check, "Yellow") && !mainWordle.InYesNo(check, "Black"))
                        {
                            MessageBox.Show("Congratulation! You Won The Game :)", "You Won!");
                            label2.Text = "You Win!" + "\n" + "Congratulation!";
                        }
                        else
                        {
                            MessageBox.Show("You Lost :(", "You Lost!");
                            label2.Text = "You Lost :(" + "\n" + "The Word Was: " + random;
                        }

                    }
                    else
                    {
                        MessageBox.Show("The Word Not Found! Please Enter Another Word", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chance--;
                    }
                }
                else
                {
                    chance--;
                }
            }
            chance++;
        }

        private void colors(string[] check, int chance)
        {
            if (chance == 1)
            {
                if (check[0] == "Green")
                {
                    textBox1.BackColor = Color.LightGreen;
                }
                else if (check[0] == "Yellow")
                {
                    textBox1.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox1.BackColor = Color.Black;
                }
                if (check[1] == "Green")
                {
                    textBox2.BackColor = Color.LightGreen;
                }
                else if (check[1] == "Yellow")
                {
                    textBox2.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox2.BackColor = Color.Black;
                }
                if (check[2] == "Green")
                {
                    textBox3.BackColor = Color.LightGreen;
                }
                else if (check[2] == "Yellow")
                {
                    textBox3.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox3.BackColor = Color.Black;
                }
                if (check[3] == "Green")
                {
                    textBox4.BackColor = Color.LightGreen;
                }
                else if (check[3] == "Yellow")
                {
                    textBox4.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox4.BackColor = Color.Black;
                }
                if (check[4] == "Green")
                {
                    textBox5.BackColor = Color.LightGreen;
                }
                else if (check[4] == "Yellow")
                {
                    textBox5.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox5.BackColor = Color.Black;
                }
            }

            if (chance == 2)
            {
                if (check[0] == "Green")
                {
                    textBox6.BackColor = Color.LightGreen;
                }
                else if (check[0] == "Yellow")
                {
                    textBox6.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox6.BackColor = Color.Black;
                }
                if (check[1] == "Green")
                {
                    textBox7.BackColor = Color.LightGreen;
                }
                else if (check[1] == "Yellow")
                {
                    textBox7.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox7.BackColor = Color.Black;
                }
                if (check[2] == "Green")
                {
                    textBox8.BackColor = Color.LightGreen;
                }
                else if (check[2] == "Yellow")
                {
                    textBox8.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox8.BackColor = Color.Black;
                }
                if (check[3] == "Green")
                {
                    textBox9.BackColor = Color.LightGreen;
                }
                else if (check[3] == "Yellow")
                {
                    textBox9.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox9.BackColor = Color.Black;
                }
                if (check[4] == "Green")
                {
                    textBox10.BackColor = Color.LightGreen;
                }
                else if (check[4] == "Yellow")
                {
                    textBox10.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox10.BackColor = Color.Black;
                }
            }

            if (chance == 3)
            {
                if (check[0] == "Green")
                {
                    textBox11.BackColor = Color.LightGreen;
                }
                else if (check[0] == "Yellow")
                {
                    textBox11.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox11.BackColor = Color.Black;
                }
                if (check[1] == "Green")
                {
                    textBox12.BackColor = Color.LightGreen;
                }
                else if (check[1] == "Yellow")
                {
                    textBox12.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox12.BackColor = Color.Black;
                }
                if (check[2] == "Green")
                {
                    textBox13.BackColor = Color.LightGreen;
                }
                else if (check[2] == "Yellow")
                {
                    textBox13.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox13.BackColor = Color.Black;
                }
                if (check[3] == "Green")
                {
                    textBox14.BackColor = Color.LightGreen;
                }
                else if (check[3] == "Yellow")
                {
                    textBox14.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox14.BackColor = Color.Black;
                }
                if (check[4] == "Green")
                {
                    textBox15.BackColor = Color.LightGreen;
                }
                else if (check[4] == "Yellow")
                {
                    textBox15.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox15.BackColor = Color.Black;
                }
            }

            if (chance == 4)
            {
                if (check[0] == "Green")
                {
                    textBox16.BackColor = Color.LightGreen;
                }
                else if (check[0] == "Yellow")
                {
                    textBox16.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox16.BackColor = Color.Black;
                }
                if (check[1] == "Green")
                {
                    textBox17.BackColor = Color.LightGreen;
                }
                else if (check[1] == "Yellow")
                {
                    textBox17.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox17.BackColor = Color.Black;
                }
                if (check[2] == "Green")
                {
                    textBox18.BackColor = Color.LightGreen;
                }
                else if (check[2] == "Yellow")
                {
                    textBox18.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox18.BackColor = Color.Black;
                }
                if (check[3] == "Green")
                {
                    textBox19.BackColor = Color.LightGreen;
                }
                else if (check[3] == "Yellow")
                {
                    textBox19.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox19.BackColor = Color.Black;
                }
                if (check[4] == "Green")
                {
                    textBox20.BackColor = Color.LightGreen;
                }
                else if (check[4] == "Yellow")
                {
                    textBox20.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox20.BackColor = Color.Black;
                }
            }

            if (chance == 5)
            {
                if (check[0] == "Green")
                {
                    textBox21.BackColor = Color.LightGreen;
                }
                else if (check[0] == "Yellow")
                {
                    textBox21.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox21.BackColor = Color.Black;
                }
                if (check[1] == "Green")
                {
                    textBox22.BackColor = Color.LightGreen;
                }
                else if (check[1] == "Yellow")
                {
                    textBox22.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox22.BackColor = Color.Black;
                }
                if (check[2] == "Green")
                {
                    textBox23.BackColor = Color.LightGreen;
                }
                else if (check[2] == "Yellow")
                {
                    textBox23.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox23.BackColor = Color.Black;
                }
                if (check[3] == "Green")
                {
                    textBox24.BackColor = Color.LightGreen;
                }
                else if (check[3] == "Yellow")
                {
                    textBox24.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox24.BackColor = Color.Black;
                }
                if (check[4] == "Green")
                {
                    textBox25.BackColor = Color.LightGreen;
                }
                else if (check[4] == "Yellow")
                {
                    textBox25.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox25.BackColor = Color.Black;
                }
            }

            if (chance == 6)
            {
                if (check[0] == "Green")
                {
                    textBox26.BackColor = Color.LightGreen;
                }
                else if (check[0] == "Yellow")
                {
                    textBox26.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox26.BackColor = Color.Black;
                }
                if (check[1] == "Green")
                {
                    textBox27.BackColor = Color.LightGreen;
                }
                else if (check[1] == "Yellow")
                {
                    textBox27.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox27.BackColor = Color.Black;
                }
                if (check[2] == "Green")
                {
                    textBox28.BackColor = Color.LightGreen;
                }
                else if (check[2] == "Yellow")
                {
                    textBox28.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox28.BackColor = Color.Black;
                }
                if (check[3] == "Green")
                {
                    textBox29.BackColor = Color.LightGreen;
                }
                else if (check[3] == "Yellow")
                {
                    textBox29.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox29.BackColor = Color.Black;
                }
                if (check[4] == "Green")
                {
                    textBox30.BackColor = Color.LightGreen;
                }
                else if (check[4] == "Yellow")
                {
                    textBox30.BackColor = Color.LightYellow;
                }
                else
                {
                    textBox30.BackColor = Color.Black;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox1.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox2.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox3.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox7.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox8.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox6.Focus();
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox9.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox7.Focus();
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox10.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox8.Focus();
            }
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox12.Focus();
            }
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox13.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox11.Focus();
            }
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox14.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox12.Focus();
            }
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox15.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox13.Focus();
            }
        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox17.Focus();
            }
        }

        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox18.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox16.Focus();
            }
        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox19.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox17.Focus();
            }
        }

        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox20.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox18.Focus();
            }
        }

        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox22.Focus();
            }
        }

        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox23.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox21.Focus();
            }
        }

        private void textBox23_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox24.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox22.Focus();
            }
        }

        private void textBox24_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox25.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox23.Focus();
            }
        }

        private void textBox26_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox27.Focus();
            }
        }

        private void textBox27_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox28.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox26.Focus();
            }
        }

        private void textBox28_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox29.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox27.Focus();
            }
        }

        private void textBox29_KeyDown(object sender, KeyEventArgs e)
        {
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Right)
            {
                textBox30.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox28.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBox4.Focus();
            }
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBox9.Focus();
            }
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBox14.Focus();
            }
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBox18.Focus();
            }
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void textBox25_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBox23.Focus();
            }
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void textBox30_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBox29.Focus();
            }
            if ((65 <= e.KeyValue && 90 >= e.KeyValue) || e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chance = 1;
            button1.Enabled = true;
            button1.Visible = true;
            button2.Visible = false;
            button2.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            label2.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox1.BackColor = Color.LightGray;
            textBox2.BackColor = Color.LightGray;
            textBox3.BackColor = Color.LightGray;
            textBox4.BackColor = Color.LightGray;
            textBox5.BackColor = Color.LightGray;
            textBox6.BackColor = Color.LightGray;
            textBox7.BackColor = Color.LightGray;
            textBox8.BackColor = Color.LightGray;
            textBox9.BackColor = Color.LightGray;
            textBox10.BackColor = Color.LightGray;
            textBox11.BackColor = Color.LightGray;
            textBox12.BackColor = Color.LightGray;
            textBox13.BackColor = Color.LightGray;
            textBox14.BackColor = Color.LightGray;
            textBox15.BackColor = Color.LightGray;
            textBox16.BackColor = Color.LightGray;
            textBox17.BackColor = Color.LightGray;
            textBox18.BackColor = Color.LightGray;
            textBox19.BackColor = Color.LightGray;
            textBox20.BackColor = Color.LightGray;
            textBox21.BackColor = Color.LightGray;
            textBox22.BackColor = Color.LightGray;
            textBox23.BackColor = Color.LightGray;
            textBox24.BackColor = Color.LightGray;
            textBox25.BackColor = Color.LightGray;
            textBox26.BackColor = Color.LightGray;
            textBox27.BackColor = Color.LightGray;
            textBox28.BackColor = Color.LightGray;
            textBox29.BackColor = Color.LightGray;
            textBox30.BackColor = Color.LightGray;

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
