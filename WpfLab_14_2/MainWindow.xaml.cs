using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfLab_14_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "Хлеб",
                Price = 43.4,
                ImageSource = "Data/hleb.jpg",
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                Name = "Мясо",
                Price = 43.50,
                ImageSource = "Data/myaso.jpg",
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                Name = "Чайник",
                Price = 1450.00,
                ImageSource = "Data/chaynik.jpg",
                Category = Categories.DomesticAppliances
            });
            products.Add(new Product()
            {
                Name = "Блендер",
                Price = 4140.50,
                ImageSource = "Data/blender.jpg",
                Category = Categories.DomesticAppliances
            });
            lstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                Name = "Яблоки",
                Price = 104.50,
                ImageSource = "Data/yabloki.jpg",
                Category = Categories.Food
            });
        }
    }
}
