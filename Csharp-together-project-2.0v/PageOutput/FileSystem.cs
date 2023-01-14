using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Csharp_together_project_2._0v
{
    internal class FileSystem
    {

        TextBox main_text_editor;

        String selectedFile;

        public FileSystem(TextBox main_text_editor)
        {
            this.main_text_editor = main_text_editor;
        }

        public void ShowDialog()
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Title = "Select a file";
            FileDialog.InitialDirectory = @"C:\users\%username%\Desktop";
            FileDialog.Filter = "Text files (*.txt)|*.txt";
            FileDialog.FilterIndex = 2;
            FileDialog.RestoreDirectory = true;

            if (FileDialog.ShowDialog() == true)
            {
                selectedFile = FileDialog.FileName;
                Read();
            }

        }

        public void Read()
        {
            StreamReader reader = new StreamReader(selectedFile);
            string file_content = reader.ReadToEnd();
            main_text_editor.Text = file_content;
            reader.Close();
        }

        public void Save()
        {
            try
            {
                StreamWriter writer = new StreamWriter(selectedFile);
                writer.Write(main_text_editor.Text);
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Něco se pokazilo :(");
            }
        }

        public void SaveAs()
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Title = "Save as";
            FileDialog.InitialDirectory = @"C:\users\%username%\Desktop";
            FileDialog.Filter = "Text files (*.txt)|*.txt";
            FileDialog.FilterIndex = 2;
            FileDialog.RestoreDirectory = true;
            FileDialog.ValidateNames = false;

            if (FileDialog.ShowDialog() == true)
            {
                selectedFile = FileDialog.FileName;
                Save();
            }
        }
    }
}
