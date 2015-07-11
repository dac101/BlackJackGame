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

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for CustomDialog.xaml
    /// </summary>
    public partial class CustomDialog : Window
    {
        public int Value { get; set; }
        public CustomDialog()
        {
            InitializeComponent();
  
        }
        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
     
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            Value = 1;
        }

        private void EvenBtn_Click(object sender, RoutedEventArgs e)
        {
            Value = 11;
        }
    }
}
