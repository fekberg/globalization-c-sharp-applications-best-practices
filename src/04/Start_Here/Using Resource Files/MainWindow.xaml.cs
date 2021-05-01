using Domain;
using System.Windows;

namespace Using_Resource_Files
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new Product 
            { 
                Name = "Milk",
                Price = 2.99m
            };
        }
    }
}
