using Haley.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.VisualStyles;
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

        FileSystem file_system;

<<<<<<< HEAD
        string text = "error";
=======
        // file menu - menuitem - properties 
        public string save { get; set; } = "save";
        public string open { get; set; } = "open";
        public string save_as { get; set; } = "save as";
        public string new_file { get; set; } = "New File";
>>>>>>> b0e176e790539799e65fe42d917b4d6aced3e5b3

        public PageOutput()
        {
            InitializeComponent();
            Init();
            DataContext = this;
        }

        public void Init()
        {
            file_system = new FileSystem(text_editor);
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

        private void setterArabicTransparent(object sender, RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.setArabicTransparent();
        }

        private void setterGeorgia(object sender , RoutedEventArgs e)
        {
            Fonts fonts = new Fonts(text_editor);
            fonts.setGeorgia();
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

        //File system

        private void SaveFile(object sender, RoutedEventArgs e)
        {
            file_system.Save();
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            file_system.ShowDialog();
        }

        private void SaveAsFile(object sender, RoutedEventArgs e)
        {
            file_system.SaveAs();
        }

        private void newFile(object sender , RoutedEventArgs e)
        {
            FileSystem file_system = new FileSystem(text_editor);
            file_system.newFile();
        }


        // set font styles

        private void setStyleItalic(object sender , RoutedEventArgs e)
        {
            FontStyle font_style = new FontStyle(text_editor);
            font_style.styleItalic();
        }

        public void setStyleOblique(object sender , RoutedEventArgs e)
        {
            FontStyle font_style = new FontStyle(text_editor);
            font_style.styleOblique();
        }

        public void setStyleNormal(object sender , RoutedEventArgs e)
        {
            FontStyle font_style = new FontStyle(text_editor);
            font_style.styleNormal();
        }

        // set font weight

        private void setBold(object sender , RoutedEventArgs e)
        {
            BoldText bold_text = new BoldText(text_editor);
            bold_text.setBold();
        }

        private void setMedium(object sender , RoutedEventArgs e)
        {
            BoldText bold_text = new BoldText(text_editor);
            bold_text.setMedium();
        }

        private void setExtraBold(object sender , RoutedEventArgs e)
        {
            BoldText bold_text = new BoldText(text_editor);
            bold_text.setExtraBold();
        }

        private void setUltraBold(object sender, RoutedEventArgs e)
        {
            BoldText bold_text = new BoldText(text_editor);
            bold_text.setUltraBold();
        }

<<<<<<< HEAD
=======

        //Color choosing

>>>>>>> b0e176e790539799e65fe42d917b4d6aced3e5b3
        private void ChooseColorBg(object sender, RoutedEventArgs e)
        {
            Colors colors = new Colors(text_editor);
            colors.setBackground();
        }

        private void ChooseColorFg(object sender, RoutedEventArgs e)
        {
            Colors colors = new Colors(text_editor);
            colors.setForeground();
        }
<<<<<<< HEAD
=======

>>>>>>> b0e176e790539799e65fe42d917b4d6aced3e5b3
    }
}
