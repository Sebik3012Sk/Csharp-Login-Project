using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Csharp_together_project_2._0v
{
    internal class FontStyle
    {

        TextBox main_text_editor;

        public TextBox MainTextEditor
        {
            get { return main_text_editor; }
            set { main_text_editor = value; }
        }

        public FontStyle(TextBox main_text_editor)
        {
            this.main_text_editor = main_text_editor;
        }

        public void styleItalic()
        {
            main_text_editor.FontStyle = FontStyles.Italic;
        }

        public void styleOblique()
        {
            main_text_editor.FontStyle = FontStyles.Oblique;
        }

        public void styleNormal()
        {
            main_text_editor.FontStyle = FontStyles.Normal;
        }
    }
}
