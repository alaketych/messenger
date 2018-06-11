using System;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MESSENGER.View.MainMessenger
{
    public partial class MainWindow : Window
    {
        bool ClosedSideBarWindow = true;
        bool ClosedInfoBarWindow = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SideBarMenu_Click(object sender, RoutedEventArgs e)
        {
            if (ClosedSideBarWindow)
            {
                Storyboard sb1 = this.FindResource("OpenSideBar") as Storyboard;
                sb1.Begin();
            }
            else
            {
                Storyboard sb1 = this.FindResource("CloseSideBar") as Storyboard;
                sb1.Begin();
            }

            ClosedSideBarWindow = !ClosedSideBarWindow;
        }

        private void InfoBarMenu_Click(object sender, RoutedEventArgs e)
        {
            if (ClosedInfoBarWindow)
            {
                Storyboard sb2 = this.FindResource("OpenSideBar") as Storyboard;
                sb2.Begin();
            }
            else
            {
                Storyboard sb2 = this.FindResource("CloseSideBar") as Storyboard;
                sb2.Begin();
            }

            ClosedInfoBarWindow = !ClosedInfoBarWindow;
        }
    }
}