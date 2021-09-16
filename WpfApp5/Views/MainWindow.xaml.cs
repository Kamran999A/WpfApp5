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
using WpfApp5.Abstract_Factory;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IFurnitureFactory furnitureFactory { get; set; }
        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = sender as ComboBox;
            var s = item.SelectedIndex;
            if (s == 0)
            {
                furnitureFactory = new ModernFurnitureFactory();
                furnitureFactory.show();
            }
            
            else if (s == 1)
            {
                furnitureFactory = new VictorianFurnitureFactory();
                furnitureFactory.show();
            }
            
            else if (s == 2)
            {
                furnitureFactory = new ArtDecoFurnitureFactory();
                furnitureFactory.show();
            }
            
        }
    }
}
