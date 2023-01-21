using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Csharp_together_project_2._0v
{
    internal class LoadImage
    {
        TextBox main_text_editor;

        ImageBrush load_image;

        string selectedFile;

        public LoadImage(TextBox main_text_editor, ImageBrush load_image)
        {
            this.main_text_editor = main_text_editor;
            this.load_image = load_image;
        }

        public void ShowDialog()
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Title = "Select a file";
            FileDialog.InitialDirectory = @"C:\users\%username%\Desktop";
            FileDialog.Filter = "Images (*.png, *.jpg)|*.png; *.jpg";
            FileDialog.FilterIndex = 2;
            FileDialog.RestoreDirectory = true;

            if (FileDialog.ShowDialog() == true)
            {
                selectedFile = FileDialog.FileName;
                load_image.ImageSource = new BitmapImage(new Uri(selectedFile));
            }
        }
    }
}
