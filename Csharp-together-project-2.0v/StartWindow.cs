using System;
using System.Collections.Generic;
using System.IO;
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

        const string path = "data_list.txt";

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


        public void WriteDataToFile()
        {

            if (!File.Exists(path))
                File.Create(path);
            else
            {
                StreamWriter writer_file = new StreamWriter(path);

                string data_to_file = $"Username : {username_input_text} \n Password : {password_input_text}";
                writer_file.WriteLine(data_to_file);
                writer_file.Close();
            }


        }

    }
}
