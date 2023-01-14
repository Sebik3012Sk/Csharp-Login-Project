
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
    /// Interakční logika pro PageOutput.xaml
    /// </summary>
    public partial class PageOutput : Page
    {
        public PageOutput()
        {
            InitializeComponent();
        }

        

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

<<<<<<< HEAD
        private void openFile(object sender , RoutedEventArgs e)
        {
            FileSystem file_system = new FileSystem(text_editor);
            file_system.ShowDialog();
=======
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
>>>>>>> 0346df28351433a639a43079861ac25e77ca5e2f
        }
    }
}
