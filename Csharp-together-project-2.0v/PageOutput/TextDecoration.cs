using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Csharp_together_project_2._0v
{
    internal class TextDecoration
    {

        TextBox main_text_editor;

        public TextBox MainTextEditor
        {
            get { return main_text_editor;}
            set { main_text_editor = value;}
        }

        public TextDecoration(TextBox main_text_editor)
        {
            this.main_text_editor = main_text_editor;
        }

        public void textUnderline()
        {
            main_text_editor.TextDecorations = TextDecorations.Underline;
        }

        public void textBaseline()
        {
            main_text_editor.TextDecorations = TextDecorations.Baseline;
        }

        public void textOverLine()
        {
            main_text_editor.TextDecorations = TextDecorations.OverLine;
        }
    }
}
