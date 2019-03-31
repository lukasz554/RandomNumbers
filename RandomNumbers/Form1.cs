using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace RandomNumbers


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           }

       
        string number;

        List<Button> buttons = new List<Button>();




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void bgenerate_Click_1(object sender, EventArgs e)
        {
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);


            int number4 = 0;
            Int32.TryParse(textBox2.Text, out number4);
            ButtonsVisibility(number4);

            List<int> randomNumbers = new List<int>();

            Random random = new Random();
            int number3 = 0;
            Int32.TryParse(textBox1.Text, out number3);


            do
            {
                int rand = number3 + random.Next(9);
                randomNumbers.Add(rand);                buttons[randomNumbers.Count - 1].Text = rand.ToString();
            }
            while ((randomNumbers.Count - 1) < number4);

            ButtonsColor();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            number = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ButtonsVisibility(int val)
        {
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            foreach (Button but in buttons)
            {
                if ((buttons.IndexOf(but) +1) > val)
                    but.Visible = false;
                else
                    but.Visible = true;
            }

        }
        
        
        private void ButtonsColor()
        {
            int num5 = 0;
            int mod3 = 0;
            foreach (Button but in buttons)
            {
                Int32.TryParse(but.Text, out num5);
                mod3 = num5 % 3;
                if (mod3 == 0)
                {
                    but.BackColor = Color.Green;
                }
                else
                {
                    but.BackColor = SystemColors.Control;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            char c = Convert.ToChar(e.KeyCode);
            
            if (!(Char.IsDigit(c) || c == Convert.ToChar(Keys.Space) || c == Convert.ToChar(Keys.Back)))
            {
               
            }
            


        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
} 


