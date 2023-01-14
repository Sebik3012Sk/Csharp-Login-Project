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

        // move text - text positions : right , left , center

        private void moveRight(object sender , RoutedEventArgs e)
        {
            MoveText move_text = new MoveText(text_editor);
            move_text.moveRight();
        }

        private void moveLeft(object sender , RoutedEventArgs e)
        {
            MoveText move_text = new MoveText(text_editor);
            move_text.moveLeft();
        }

        private void moveCenter(object sender , RoutedEventArgs e)
        {
            MoveText move_text = new MoveText(text_editor);
            move_text.moveCenter();
        }

        // text decoration : underline

        private void textUnderline(object sender , RoutedEventArgs e)
        {
            TextDecoration text_decorations = new TextDecoration(text_editor);
            text_decorations.textUnderline();
        }

        private void textBaseline(object sender , RoutedEventArgs e)
        {
            TextDecoration text_decorations = new TextDecoration(text_editor);
            text_decorations.textBaseline();
        }
        
        private void textOverLine(object sender , RoutedEventArgs e)
        {
            TextDecoration text_decorations = new TextDecoration(text_editor);
            text_decorations.textOverLine();
        }
    }
}
