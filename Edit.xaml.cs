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

namespace tovars_wpf
{
    

    public partial class EditTovar : Window
    {
        private Goods goods;
        public EditTovar( Goods goods)
        {
            InitializeComponent();

            measure_cb.ItemsSource = Enum.GetValues(typeof(Measure));
            this.goods = goods;
            this.DataContext = goods;
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
