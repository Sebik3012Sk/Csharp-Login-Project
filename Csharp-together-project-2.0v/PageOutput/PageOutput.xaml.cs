﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
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
        public PageOutput()
        {
            InitializeComponent();
        }

        

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
    }
}
