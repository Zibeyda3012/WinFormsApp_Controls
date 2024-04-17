using System.Text.Json;
using WinFormsApp_anketForm.Models;

namespace WinFormsApp_anketForm
{
    //default olaraq user yoxdur
    public partial class Form1 : Form
    {
        User user1 { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.Text = "Questionaire";
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            string filename = textBox1.Text;
            ReadFromFile(filename);

            textBox2.Text = user1.Surname;
            textBox3.Text = user1.Name;
            textBox4.Text = user1.Father;
            textBox5.Text = user1.Country;
            textBox6.Text = user1.City;
            textBox7.Text = user1.PhoneNumber;
            textBox8.Text = user1.Username;
            dateTimePicker1.Value = user1.Birthday;
            if (user1.Gender == "Male")
                radioButton1.Select();
            else
                radioButton2.Select();

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            string gender;
            if (radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
            else
                gender = radioButton2.Text;

            User newUser = new User(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, dateTimePicker1.Value, gender);
            string filename = textBox8.Text;

            string path = "../../../JsonFiles/" + filename + ".json";

            if(File.Exists(path)) 
            {
                string message = "This username is unavailable";
                MessageBox.Show(message);
            }
            else
            {
                WriteToFile(filename, newUser);
            }


            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            radioButton1.Select();
            dateTimePicker1.Value = DateTime.Now;



        }

        public void WriteToFile(string filename, User user)
        {
            JsonSerializerOptions op = new JsonSerializerOptions();
            op.WriteIndented = true;

            var JsonUser = JsonSerializer.Serialize<User>(user, op);
            string path = "../../../JsonFiles/" + filename + ".json";
            File.WriteAllText(path, JsonUser);
        }

        public void ReadFromFile(string filename)
        {
            
            string path = "../../../JsonFiles/" + filename + ".json";
            if(File.Exists(path))
            {
                var UserJsonString = File.ReadAllText(path);
                user1 = JsonSerializer.Deserialize<User>(UserJsonString);
            }
            else
            {
                string message = "This file doesn't exist";
                MessageBox.Show(message);
            }
         
        }
    }
}
