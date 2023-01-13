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




    }
}
