using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Csharp_together_project_2._0v
{
    internal class StartWindow
    {

        string username_input_text;
        string password_input_text;

        string[,] data_databese =
        {
            {"Sebastian Kučera" , "Mmac" },
            { "1234" , "4321" }
        };

        public string UsernameInputText
        {
            get { return username_input_text; }
            set { username_input_text = value; }
        }

        public string PasswordInputText
        {
            get { return password_input_text; } 
            set { password_input_text = value; }
        }

        public StartWindow(string username_input_text , string password_input_text)
        {
            this.username_input_text = username_input_text;
            this.password_input_text = password_input_text;
        }


        public void LogIn()
        {
            if (username_input_text == data_databese[0, 0] && password_input_text == data_databese[1, 0])
                MessageBox.Show("Your Data is Valid", "Login Form App");
            else if (username_input_text == data_databese[0, 1] && password_input_text == data_databese[1, 1])
                MessageBox.Show("Your Data is Valid", "Login Form App");
            else
                MessageBox.Show("Your data is not valid", "Login Form App");
        }

        public void runPage()
        {

        }
    }
}
