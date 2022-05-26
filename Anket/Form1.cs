using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            List<User> user = new()
            {
                new User
                {
                    Name = textbx_FName.Text.ToString(),
                    Surname = textbx_surname.Text.ToString(),
                    Patronymic = textbx_Patronymic.Text.ToString(),
                    Country = textbx_Country.Text.ToString(),
                    City = textbx_city.Text.ToString(),
                    PhoneNumber = maskedTextBox1.Text.ToString(),
                    DateOfBirth = dateTimePicker1.Text.ToString(),
                    Male = rbtn_Male.Checked,
                    Female = rbtn_Female.Checked
                }          
            };

            var jsonString = JsonConvert.SerializeObject(user,Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText($"{textbx_FName.Text.ToString()}.json", jsonString);
            MessageBox.Show("File saved");
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //var jsonString = String.Empty;
            //jsonString = File.ReadAllText($"{textbx_NameLoad}.json");
            //User infoUser = JsonConvert.DeserializeObject<User>(jsonString);

            //textbx_FName.Text = infoUser.Name;
            //textbx_surname.Text = infoUser.Surname;
            //textbx_Patronymic.Text = infoUser.Patronymic;
            //textbx_Country.Text = infoUser.Country;
            //textbx_city.Text = infoUser.City;
            //maskedTextBox1.Text = infoUser.PhoneNumber;
            //dateTimePicker1.Text = infoUser.DateOfBirth;
            //rbtn_Male.Checked = infoUser.Male;
            //rbtn_Female.Checked = infoUser.Female;

            User[] users = null;

            var stringData = File.ReadAllText($"{textbx_NameLoad.Text}.json");
            users = JsonConvert.DeserializeObject<User[]>(stringData);

            foreach (var user in users)
            {
                textbx_FName.Text = user.Name;
                textbx_surname.Text = user.Surname;
                textbx_Patronymic.Text = user.Patronymic;
                textbx_Country.Text = user.Country;
                textbx_city.Text = user.City;
                maskedTextBox1.Text = user.PhoneNumber;
                dateTimePicker1.Text = user.DateOfBirth;
                rbtn_Male.Checked = user.Male;
                rbtn_Female.Checked = user.Female;
            }

        }
    }
}
