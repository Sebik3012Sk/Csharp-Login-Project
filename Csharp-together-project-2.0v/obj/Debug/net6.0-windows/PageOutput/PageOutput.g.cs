﻿#pragma checksum "..\..\..\..\PageOutput\PageOutput.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07EA02F4EA62414C2AA68A7DE8EC43F3CF6778CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

using Csharp_together_project_2._0v;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Csharp_together_project_2._0v {
    
    
    /// <summary>
    /// PageOutput
    /// </summary>
    public partial class PageOutput : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 153 "..\..\..\..\PageOutput\PageOutput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text_editor;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\..\PageOutput\PageOutput.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush image_bg;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Csharp-together-project-2.0v;component/pageoutput/pageoutput.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PageOutput\PageOutput.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 21 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveFile);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 27 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenFile);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 33 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveAsFile);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 39 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.newFile);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 51 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.moveLeft);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 55 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.moveRight);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 63 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.moveCenter);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 72 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.loadThisImage);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 81 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.textUnderline);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 87 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.textBaseline);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 88 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.textOverLine);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 96 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setterHelvetica);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 97 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setterArial);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 98 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setterTimesNewRoman);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 99 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setterComicSansMS);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 100 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setterCalibri);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 101 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setterArabicTransparent);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 102 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setterGeorgia);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 106 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.settterSizeEight);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 107 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.settterSizeSixTeen);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 108 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.settterSizeTwentyFour);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 109 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.settterSizeThirtyTwo);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 110 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setterSizeFourtyEight);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 111 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setterSizeSixtyFour);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 115 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setStyleItalic);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 116 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setStyleOblique);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 117 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setStyleNormal);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 121 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setBold);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 122 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setMedium);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 123 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setExtraBold);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 124 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.setUltraBold);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 135 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ChooseColorBg);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 143 "..\..\..\..\PageOutput\PageOutput.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ChooseColorFg);
            
            #line default
            #line hidden
            return;
            case 34:
            this.text_editor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 35:
            this.image_bg = ((System.Windows.Media.ImageBrush)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

