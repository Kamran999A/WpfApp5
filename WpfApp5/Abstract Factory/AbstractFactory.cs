using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp5.Abstract_Factory
{
    public interface IChair
    {
        bool sitOn();
        bool hasLegs();

        string GetImagePath();

    }

    public class ArtDecoChair : IChair
    {
        public string GetImagePath()
        {
            return "/Images/ArtDecoChair.jpg";
        }

        public bool hasLegs()
        {
            return false;
        }

        public bool sitOn()
        {
            return true;
        }

    }

    public class ModernChair : IChair
    {
        public string GetImagePath()
        {
            return "/Images/ModernChair.jpg";
        }

        public bool hasLegs()
        {
            return true;
        }

        public bool sitOn()
        {
            return true;
        }
    }

    public class VictorianChair : IChair
    {
        public string GetImagePath()
        {
            throw new NotImplementedException();
        }

        public bool hasLegs()
        {
            return true;
        }

        public bool sitOn()
        {
            return true;
        }
    }

    public interface ITable
    {
        bool sitOn();
        bool hasLegs();


    }

    public class ArtDecoTable : ITable
    {
        public bool hasLegs()
        {
            return true;
        }

        public bool sitOn()
        {
            return true;
        }
    }

    public class ModernTable : ITable
    {
        public bool hasLegs()
        {
            return true;
        }

        public bool sitOn()
        {
            return true;
        }
    }

    public class VictorianTable : ITable
    {
        public bool hasLegs()
        {
            return true;
        }

        public bool sitOn()
        {
            return true;
        }


    }

    public interface ISofa
    {
        bool CanEnlarge();

    }

    public class ArtDecoSofa : ISofa
    {
        public bool CanEnlarge()
        {
            return true;
        }

    }

    public class ModernSofa : ISofa
    {
        public bool CanEnlarge()
        {
            return true;
        }


    }

    public class VictorianSofa : ISofa
    {
        public bool CanEnlarge()
        {
            return true;
        }


    }

    public interface IFurnitureFactory
    {

        IChair GetImagePath();
        IChair createChair();
        ITable createTable();
        ISofa createSofa();
        void show();

    }

    public class ModernFurnitureFactory : IFurnitureFactory
    {


        public IChair createChair()
        {
            return new ModernChair();
        }

        public ISofa createSofa()
        {
            return new ModernSofa();

        }

        public ITable createTable()
        {
            return new ModernTable();


        }

        public IChair GetImagePath()
        {
            return new ModernChair();
        }

        public void show()
        {
            MessageBox.Show("Ok");
            var chair = createChair();
            var table = createTable();
            var sofa = createSofa();

        }
    }

    public class VictorianFurnitureFactory : IFurnitureFactory
    {


        public IChair createChair()
        {
            return new VictorianChair();
        }

        public ISofa createSofa()
        {
            return new VictorianSofa();

        }

        public ITable createTable()
        {
            return new VictorianTable();


        }

        public IChair GetImagePath()
        {
            throw new NotImplementedException();
        }

        public void show()
        {
            MessageBox.Show("Ok");
            var chair = createChair();
            var table = createTable();
            var sofa = createSofa();

        }
    }

    public class ArtDecoFurnitureFactory : IFurnitureFactory
    {

        public string ImagP { get; set; } = "/Images/ArtDecoChair.jpg";


        public IChair createChair()
        {
            return new ArtDecoChair();
        }

        public ISofa createSofa()
        {
            return new ArtDecoSofa();

        }

        public ITable createTable()
        {
            return new ArtDecoTable();


        }

        public IChair GetImagePath()
        {
            return new ArtDecoChair();
        }

        public void show()
        {

            var chair = createChair();
            var table = createTable();
            var sofa = createSofa();

        }

        public ArtDecoFurnitureFactory()
        {
            var ImagePathChair = GetImagePath();
            ImagP = ImagePathChair.GetImagePath();
            //MessageBox.Show(ImagePathChair.GetImagePath());


        }
    }

    class AbstractFactory
    {
        public void Main()
        {

            //ArtDecoFurnitureFactory furniturefactory = new ArtDecoFurnitureFactory();
            //furniturefactory.show();
        }
    }
}
