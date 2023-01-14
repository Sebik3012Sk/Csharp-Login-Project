using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Csharp_together_project_2._0v
{
    internal class MoveText
    {

        TextBox main_text_editor;

        public TextBox MainTextEditor
        {
            get { return main_text_editor; }
            set { main_text_editor = value; }
        }

        public MoveText(TextBox main_text_editor)
        {
            this.main_text_editor = main_text_editor;
        }

        public void moveRight()
        {
            main_text_editor.TextAlignment = TextAlignment.Right;
        }

        public void moveLeft()
        {
            main_text_editor.TextAlignment = TextAlignment.Left;
        }

        public void moveCenter()
        {
            main_text_editor.TextAlignment = TextAlignment.Center;
        }
    }
}
