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
using static WpfApp5.Abstract_Factory.VictorianSofa;

namespace WpfApp5.ViewModels
{
    public class AppViewModel : BaseViewModel
    {
        public int Index { get; set; }
        public ComboBox Affa { get; set; }
        public string ImageChair { get; set; }
        public string ImageTable { get; set; }
        public string ImageSofa { get; set; }
        private IFurnitureFactory furnitureFactory { get; set; }

        public AppViewModel()
        {
            ComboChangeAk();
        }
        public void ComboChangeAk()
        {
            //var item = sender as ComboBox;
            int  s = Index;

            if (s == 0)
            {
                furnitureFactory = new ModernFurnitureFactory();
               // this.DataContext = this;
                ImageChair = furnitureFactory.createChair().getImageChair();
                ImageTable = furnitureFactory.createTable().getImageTable();
                ImageSofa = furnitureFactory.createSofa().GetImageSofa();



            }

            else if (s == 1)
            {
                furnitureFactory = new VictorianFurnitureFactory();
                ImageChair = furnitureFactory.createChair().getImageChair();
                ImageTable = furnitureFactory.createTable().getImageTable();
                ImageSofa = furnitureFactory.createSofa().GetImageSofa();
                // this.DataContext = this;

            }

            else if (s == 2)
            {
                furnitureFactory = new ArtDecoFurnitureFactory();
                ImageChair = furnitureFactory.createChair().getImageChair();
                ImageTable = furnitureFactory.createTable().getImageTable();
                ImageSofa = furnitureFactory.createSofa().GetImageSofa();
                // furnitureFactory.GetImagePath().GetImagePath();
            }


        }
    }

}
