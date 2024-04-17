using System.DirectoryServices.ActiveDirectory;
using System.Security.Cryptography;

namespace WinFormsApp_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button10.BackgroundImage = Image.FromFile("../../../pictures/delete icon.png");
        }

        private void button19_Click(object sender, EventArgs e) //1
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "1";
        }

        private void button14_Click(object sender, EventArgs e) //2
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "2";
        }

        private void button9_Click(object sender, EventArgs e) //3
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "3";
        }

        private void button18_Click(object sender, EventArgs e) //4
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "4";
        }

        private void button13_Click(object sender, EventArgs e) //5
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "5";
        }

        private void button8_Click(object sender, EventArgs e) //6
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "6";
        }

        private void button17_Click(object sender, EventArgs e) //7
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "7";
        }

        private void button12_Click(object sender, EventArgs e) //8
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "8";
        }

        private void button7_Click(object sender, EventArgs e) //9
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "9";
        }

        private void button20_Click(object sender, EventArgs e) //0
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "0";
        }

        private void button1_Click(object sender, EventArgs e) // division
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "÷";
        }

        private void button2_Click(object sender, EventArgs e) //multiplication
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "×";
        }

        private void button3_Click(object sender, EventArgs e) //sub
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "-";
        }

        private void button4_Click(object sender, EventArgs e) //add
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "+";
        }

        private void button16_Click(object sender, EventArgs e) //c
        {
            richTextBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e) //1/x
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = "1/" + previous_text;
        }

        private void button6_Click(object sender, EventArgs e) //square power
        {
            string previous_text = richTextBox1.Text;
            richTextBox1.Text = previous_text + "^2";
        }

        private void button5_Click(object sender, EventArgs e) //=
        {
            if (richTextBox1.Text.Contains("+"))
            {

                string[] nums = richTextBox1.Text.Split("+");
                double result = 0;
                foreach (var item in nums)
                    result += Convert.ToDouble(item);

                string previous_text = richTextBox1.Text;
                richTextBox1.Text = previous_text + " = " + result.ToString();

            }

            else if (richTextBox1.Text.Contains("-"))
            {
                string[] nums = richTextBox1.Text.Split("-");
                double result = 0;
                foreach (var item in nums)
                    result -= Convert.ToDouble(item);

                string previous_text = richTextBox1.Text;
                richTextBox1.Text = previous_text + " = " + result.ToString();
            }

            else if (richTextBox1.Text.Contains("÷"))
            {

                string[] nums = richTextBox1.Text.Split("÷");
                double result = Convert.ToDouble(nums[0]);

                bool ischeck = false;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (Convert.ToDouble(nums[i]) == 0)
                    {
                        ischeck = true;
                        break;
                    }

                }

                if (!ischeck)
                {
                    for (int i = 1; i < nums.Length; i++)
                        result /= Convert.ToDouble(nums[i]);

                    string previous_text = richTextBox1.Text;
                    richTextBox1.Text = previous_text + " = " + result.ToString();
                }

                else
                    richTextBox1.Text = "there is no division to 0";

            }

            else if (richTextBox1.Text.Contains("×"))
            {
                string[] nums = richTextBox1.Text.Split("×");
                double result = 1;
                foreach (var item in nums)
                    result *= Convert.ToDouble(item);

                string previous_text = richTextBox1.Text;
                richTextBox1.Text = previous_text + " = " + result.ToString();
            }

            else if (richTextBox1.Text.Contains("1/"))
            {
                double num1;
                string[] nums = richTextBox1.Text.Split("/");
                num1 = Convert.ToDouble(nums[1]);
                string previous_text = richTextBox1.Text;
                double result = 1 / num1;
                richTextBox1.Text = previous_text + " = " + result.ToString();
            }

            else if (richTextBox1.Text.Contains("^2"))
            {
                double num1;
                string[] nums = richTextBox1.Text.Split("^");
                num1 = Convert.ToDouble(nums[0]);
                double result = num1 * num1;
                string previous_text = richTextBox1.Text;
                richTextBox1.Text = previous_text + " = " + result.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e) //delete
        {
            if (richTextBox1.Text.Length == 1 || richTextBox1.Text.Length == 0)
                richTextBox1.Text = "";
            else
            {
                string previous_text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                richTextBox1.Text = previous_text;
            }

        }

        private void button15_Click(object sender, EventArgs e) // .
        {
            if (richTextBox1.Text.Contains("+"))
            {
                string[] nums = richTextBox1.Text.Split("+");
                string previous_text = richTextBox1.Text;
                string num1 = nums[1];
                if (num1.Contains(".") == false)
                {
                    previous_text = previous_text.Replace(num1, "");
                    num1 = num1 + ".";
                    richTextBox1.Text = previous_text + num1;
                }

            }

            else if (richTextBox1.Text.Contains("-"))
            {
                string[] nums = richTextBox1.Text.Split("-");
                string previous_text = richTextBox1.Text;
                string num1 = nums[1];
                if (num1.Contains(".") == false)
                {
                    previous_text = previous_text.Replace(num1, "");
                    num1 = num1 + ".";
                    richTextBox1.Text = previous_text + num1;
                }
            }

            else if (richTextBox1.Text.Contains("÷"))
            {
                string[] nums = richTextBox1.Text.Split("÷");
                string previous_text = richTextBox1.Text;
                string num1 = nums[1];
                if (num1.Contains(".") == false)
                {
                    previous_text = previous_text.Replace(num1, "");
                    num1 = num1 + ".";
                    richTextBox1.Text = previous_text + num1;
                }
            }

            else if (richTextBox1.Text.Contains("×"))
            {
                string[] nums = richTextBox1.Text.Split("×");
                string previous_text = richTextBox1.Text;
                string num1 = nums[1];
                if (num1.Contains(".") == false)
                {
                    previous_text = previous_text.Replace(num1, "");
                    num1 = num1 + ".";
                    richTextBox1.Text = previous_text + num1;
                }
            }

            else
            {
                if (richTextBox1.Text.Contains(".") == false)
                {
                    richTextBox1.Text = richTextBox1.Text + ".";
                }
            }
        }
    }
}
