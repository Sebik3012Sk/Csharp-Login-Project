using Haley.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;

namespace Csharp_together_project_2._0v
{
    internal class Colors
    {

        System.Windows.Controls.TextBox main_text_editor;

        System.Drawing.Color selectedColor;

        public Colors(System.Windows.Controls.TextBox main_text_editor) 
        {
            this.main_text_editor = main_text_editor;
        }

        public void ShowColorDialog(string operation)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.SolidColorOnly = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
            }
            else
            {
                if (operation == "bg")
                {
                    
                    
                }
                else if (operation == "fg")
                {

                }
            }
        }
        public void setBackground()
        {
            this.ShowColorDialog("bg");
            byte r = selectedColor.R;
            byte g = selectedColor.G;
            byte b = selectedColor.B;
            byte a = selectedColor.A;
            main_text_editor.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(a, r, g, b));
        }

        public void setForeground()
        {
            this.ShowColorDialog("fg");
            byte r = selectedColor.R;
            byte g = selectedColor.G;
            byte b = selectedColor.B;
            byte a = selectedColor.A;
            main_text_editor.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(a, r, g, b));
        }
    }
}
