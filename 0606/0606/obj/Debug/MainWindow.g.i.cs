﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F71415620B42F3ABBAF3BCA6C8BFDC1AB1212BA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace _0606 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveasBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Size1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Size2;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Size3;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BlackBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid WhiteBtn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textarea;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/0606;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NewBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\MainWindow.xaml"
            this.NewBtn.Click += new System.Windows.RoutedEventHandler(this.NewBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\MainWindow.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SaveasBtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\MainWindow.xaml"
            this.SaveasBtn.Click += new System.Windows.RoutedEventHandler(this.SaveasBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Size1 = ((System.Windows.Controls.Grid)(target));
            
            #line 20 "..\..\MainWindow.xaml"
            this.Size1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Size1_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Size2 = ((System.Windows.Controls.Grid)(target));
            
            #line 23 "..\..\MainWindow.xaml"
            this.Size2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Size2_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Size3 = ((System.Windows.Controls.Grid)(target));
            
            #line 26 "..\..\MainWindow.xaml"
            this.Size3.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Size3_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BlackBtn = ((System.Windows.Controls.Grid)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.BlackBtn.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BlackBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.WhiteBtn = ((System.Windows.Controls.Grid)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.WhiteBtn.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WhiteBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Textarea = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

