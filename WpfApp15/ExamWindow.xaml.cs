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
using System.Windows.Shapes;

namespace WpfApp15
{
    /// <summary>
    /// Interaction logic for ExamWindow.xaml
    /// </summary>
    public partial class ExamWindow : Window
    {
        public ExamWindow()
        {
            InitializeComponent();
        }

        private void CancelBtn_click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();

        }

        private void OkBtn_click(object sender, RoutedEventArgs e)
        {
            DialogResult= true;
            Close();
        }
    }
}
