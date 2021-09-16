using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Abstract_Factory
{
    interface IChair
    {
        bool sitOn();
        bool hasLegs();


    }

    public class ArtDecoChair : IChair
    {
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
        public bool hasLegs()
        {
            return true;
        }

        public bool sitOn()
        {
            return true;
        }
    }

    interface ITable
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

    interface ISofa
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

    interface IFurnitureFactory
    {
        IChair createChair();
        ITable createTable();
        ISofa createSofa();
        void show();

    }

     class ModernFurnitureFactory : IFurnitureFactory
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

        public void show()
        {
            Console.WriteLine("Modern Style ");
            var chair = createChair();
            var table = createTable();
            var sofa = createSofa();

        }
    }



     class VictorianFurnitureFactory : IFurnitureFactory
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

        public void show()
        {
            Console.WriteLine("Victorian Style ");
            var chair = createChair();
            var table = createTable();
            var sofa = createSofa();

        }
    }



    class ArtDecoFurnitureFactory : IFurnitureFactory
    {
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

        public void show()
        {
            Console.WriteLine("ArtDeco Style ");
            var chair = createChair();
            var table = createTable();
            var sofa = createSofa();

        }
    }

    class AbstractFactory
    {
        public void Main()
        {
            ArtDecoFurnitureFactory furniturefactory = new ArtDecoFurnitureFactory();
            furniturefactory.show();
        }
    }
}
