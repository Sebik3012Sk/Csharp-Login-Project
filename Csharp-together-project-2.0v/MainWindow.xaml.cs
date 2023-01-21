using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Csharp_together_project_2._0v
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        string[,] data_databese =
{
            {"Sebastian Kučera" , "Mmac" },
            { "1234" , "4321" }
        };

        

        private void SubmitData(object sender , RoutedEventArgs e)
        {
            StartWindow window = new StartWindow(input_username.Text, input_password.Password.ToString());
            PageOutput page_out = new PageOutput();

            window.WriteDataToFile();


            string username_input_text = input_username.Text.ToString();
            string password_input_text = input_password.Password.ToString();

            if (username_input_text == data_databese[0, 0] && password_input_text == data_databese[1, 0])
                this.Content = page_out;
            else if (username_input_text == data_databese[0, 1] && password_input_text == data_databese[1, 1])
                this.Content = page_out;
            else
                MessageBox.Show("Your data is not valid", "Login Form App");
        }

        private void pressEnterGoApp(object sender , KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {
                PageOutput page_out = new PageOutput();
                this.Content = page_out;
            }

        
        }


    }
}


