#pragma checksum "..\..\..\NewFolder1\LoginUser.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B3EF3E3722A0004FB901D0C22B29895518C0E26A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using VIEWnewHumberger;


namespace VIEWnewHumberger
{


    /// <summary>
    /// LoginUser
    /// </summary>
    public partial class LoginUser : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 87 "..\..\..\NewFolder1\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UserName;

#line default
#line hidden


#line 89 "..\..\..\NewFolder1\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserName;

#line default
#line hidden


#line 91 "..\..\..\NewFolder1\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Password;

#line default
#line hidden


#line 93 "..\..\..\NewFolder1\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPassword;

#line default
#line hidden


#line 100 "..\..\..\NewFolder1\LoginUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignInButton;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VIEWnewHumberger;component/newfolder1/loginuser.xaml", System.UriKind.Relative);

#line 1 "..\..\..\NewFolder1\LoginUser.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.UserName = ((System.Windows.Controls.Grid)(target));
                    return;
                case 2:
                    this.txtUserName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.Password = ((System.Windows.Controls.Grid)(target));
                    return;
                case 4:
                    this.txtPassword = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.SignInButton = ((System.Windows.Controls.Button)(target));

#line 101 "..\..\..\NewFolder1\LoginUser.xaml"
                    this.SignInButton.Click += new System.Windows.RoutedEventHandler(this.SignInButton_Click);

#line default
#line hidden
                    return;
                case 6:

#line 108 "..\..\..\NewFolder1\LoginUser.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

