using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Csharp_together_project_2._0v
{
    internal class BoldText
    {

        TextBox main_text_editor;

        public TextBox MainTextEditor
        {
            get { return main_text_editor; }
            set { main_text_editor = value; }
        }

        public BoldText(TextBox main_text_editor)
        {
            this.main_text_editor = main_text_editor;
        }

        public void setBold()
        {
            main_text_editor.FontWeight = FontWeights.Bold;
        }

        public void setMedium()
        {
            main_text_editor.FontWeight = FontWeights.Medium;
        }

        public void setExtraBold()
        {
            main_text_editor.FontWeight = FontWeights.ExtraBold;
        }

        public void setUltraBold()
        {
            main_text_editor.FontWeight = FontWeights.UltraBold;
        }


    }
}
