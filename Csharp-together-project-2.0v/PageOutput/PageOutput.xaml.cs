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
using System.Windows.Forms;


namespace Csharp_together_project_2._0v
{
    /// <summary>
    /// Interakční logika pro PageOutput.xaml
    /// </summary>
    public partial class PageOutput : Page
    {
        public PageOutput()
        {
            InitializeComponent();
        }


        // setter font-family

        private void setterHelvetica(object sender , RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.setHelvetica();
        }

        private void setterArial(object sender , RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.setArial();
        }

        private void openFile(object sender, RoutedEventArgs e)
        {
            FileSystem file_system = new FileSystem(text_editor);
            file_system.ShowDialog();
        }

        private void setterTimesNewRoman(object sender , RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.setTimesNewRoman();
        }


        private void setterComicSansMS(object sender , RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.setComicSansMS();
        }

        private void setterCalibri(object sender , RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.setCalibri();
        }

        // setter size

        private void settterSizeEight(object sender,  RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.set_eight();
        }

        private void settterSizeSixTeen(object sender, RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.set_sixteen();
        }

        private void settterSizeTwentyFour(object sender, RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.set_twenty_four();
        }

        private void settterSizeThirtyTwo(object sender, RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.set_thirty_two();
        }

        private void setterSizeFourtyEight(object sender , RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.set_fourty_eight();
        }

        public void setterSizeSixtyFour(object sender , RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.set_sixty_four();
        }

    }
}
