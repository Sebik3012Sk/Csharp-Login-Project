using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Csharp_together_project_2._0v
{
    internal class Fonts
    {
        TextBox main_text_editor;

        public TextBox MainTextEditor
        {
            get { return main_text_editor; }
            set { main_text_editor = value; }
        }

        public Fonts(TextBox main_text_editor)
        {
            this.main_text_editor = main_text_editor;
        }

        // set font family

        public void setHelvetica()
        {
            main_text_editor.FontFamily = new FontFamily("Helvetica");
        }

        public void setArial()
        {
            main_text_editor.FontFamily = new FontFamily("Arial");
        }
        
        public void setTimesNewRoman()
        {
            main_text_editor.FontFamily = new FontFamily("Times New Roman");
        }

        public void setComicSansMS()
        {
            main_text_editor.FontFamily = new FontFamily("Comic Sans MS");
            main_text_editor.FontWeight = FontWeights.Bold;
        }

        public void setCalibri()
        {
            main_text_editor.FontFamily = new FontFamily("Calibri");
        }

        // set font size

        public void set_eight()
        {
            main_text_editor.FontSize = 8;
        }

        public void set_sixteen()
        {
            main_text_editor.FontSize = 16;
        }

        public void set_twenty_four()
        {
            main_text_editor.FontSize = 24;
        }

        public void set_thirty_two()
        {
            main_text_editor.FontSize = 32;
        }

        public void set_fourty_eight()
        {
            main_text_editor.FontSize = 48;
        }

        public void set_sixty_four()
        {
            main_text_editor.FontSize = 64;
        }
    }
}
