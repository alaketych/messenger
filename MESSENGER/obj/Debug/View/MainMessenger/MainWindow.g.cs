﻿#pragma checksum "..\..\..\..\View\MainMessenger\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2B2918540D4AB9A89296E5C9D7E17D05B10F67C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MESSENGER.View.MainMessenger;
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


namespace MESSENGER.View.MainMessenger {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 170 "..\..\..\..\View\MainMessenger\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SideBar;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\..\View\MainMessenger\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SideBarMenu;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\..\View\MainMessenger\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle RectangleFirst;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\..\View\MainMessenger\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle RectangleSecond;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\..\View\MainMessenger\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle RectangleThird;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\..\View\MainMessenger\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem Messages;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\..\View\MainMessenger\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem Groups;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\..\View\MainMessenger\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem Calls;
        
        #line default
        #line hidden
        
        
        #line 218 "..\..\..\..\View\MainMessenger\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem Settings;
        
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
            System.Uri resourceLocater = new System.Uri("/MESSENGER;component/view/mainmessenger/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\MainMessenger\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.SideBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.SideBarMenu = ((System.Windows.Controls.Button)(target));
            
            #line 172 "..\..\..\..\View\MainMessenger\MainWindow.xaml"
            this.SideBarMenu.Click += new System.Windows.RoutedEventHandler(this.SideBarMenu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RectangleFirst = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.RectangleSecond = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.RectangleThird = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 6:
            this.Messages = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 7:
            this.Groups = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 8:
            this.Calls = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 9:
            this.Settings = ((System.Windows.Controls.ListViewItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

