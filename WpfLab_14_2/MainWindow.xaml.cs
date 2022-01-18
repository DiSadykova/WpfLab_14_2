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

namespace WpfLab_14_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Хлеб",
                Price = 43.4,
                ImageSourse = "Data/eda.jpg",
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                Name = "Мясо",
                Price = 43.4,
                ImageSourse = "Data/eda.jpg",
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                Name = "Чайник",
                Price = 43.4,
                ImageSourse = "Data/bitovayatehnika.jpg",
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                Name = "Блендер",
                Price = 43.4,
                ImageSourse = "Data/bitovayatehnika.jpg",
                Category = Categories.Food
            });
            lstBox.ItemsSource = products;
        }
    }
}
