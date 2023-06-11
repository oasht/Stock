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

namespace tovars_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            Goods goods = new Goods();

            EditTovar editTovar = new EditTovar(goods);

            if (editTovar.ShowDialog() == true)
                listview.Items.Add(goods);
        }

        private void Button_Click_Change(object sender, RoutedEventArgs e)
        {
            if (listview.SelectedItem is null)
                return;
            Goods original = (Goods)listview.SelectedItem;
            Goods copy = original.Copy();

            EditTovar editTovar = new EditTovar(copy);
            if (editTovar.ShowDialog() == true)
                listview.Items[listview.SelectedIndex] = copy;


        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            if (listview.SelectedItem is null)
                return;
            else
                listview.Items.Remove(listview.SelectedItem);
        }
    }
}
