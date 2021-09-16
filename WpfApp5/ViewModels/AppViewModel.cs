using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp5.Abstract_Factory;
using WpfApp5.Commands;

namespace WpfApp5.ViewModels
{
    public class AppViewModel : BaseViewModel
    {
        public int Index { get; set; } 

        public string img { get; set; }
        private IFurnitureFactory furnitureFactory { get; set; }

        public AppViewModel()
        {
            for (int i = 0; i < Index + 1; i++)
            {
            ComboChangeAk();

            }
        }

        public void ComboChangeAk()
        {
          
            int  s = Index;
            if (s == 0)
            {
                furnitureFactory = new ModernFurnitureFactory();
                // this.DataContext = this;
                img = furnitureFactory.GetImagePath().GetImagePath();
                furnitureFactory.show();


            }

            else if (s == 1)
            {
                furnitureFactory = new VictorianFurnitureFactory();
                img = furnitureFactory.GetImagePath().GetImagePath();
                furnitureFactory.show();
               // this.DataContext = this;

            }

            else if (s == 2)
            {
                furnitureFactory = new ArtDecoFurnitureFactory();
                img = furnitureFactory.GetImagePath().GetImagePath();
                MessageBox.Show(img);
                furnitureFactory.show();
                // furnitureFactory.GetImagePath().GetImagePath();
            }

        }
    }

}
