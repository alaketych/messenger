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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VIEWnewHumberger {
    /// <summary>
    /// Interaction logic for Dialogs.xaml
    /// </summary>
    public partial class Dialogs : UserControl {
        public Dialogs()
        {
            InitializeComponent();
        }

        public ImageSource UserPhotos {
            get { return UserPhoto.Source; }
            set { value = UserPhoto.Source; }
        }

        public String UserSurname {
            get { return NameSurname.Text; }
            set { value = NameSurname.Text; }
        }

        public String UserDescription {
            get { return Description.Text; }
            set { value = Description.Text; }
        }
    }
}
