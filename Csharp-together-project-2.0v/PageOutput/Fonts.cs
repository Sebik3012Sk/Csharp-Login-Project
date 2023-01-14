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
    }
}
