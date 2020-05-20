using IOC.Interfaces;
using IOC.ManufacturerKeys;
using IOC.Manufacturers;
using System;
using System.Net.Mime;
using Unity;
using Unity.Injection;

namespace IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            #region handmatige injectie van driver-klasse
            //Driver driver = new Driver(new BMW());
            //driver.RunCar();
            #endregion
            #region Unity
            IUnityContainer container = new UnityContainer();
            //-----------------------------1-----------------------------------
            ////type mapping registreren
            //container.RegisterType<ICar, BMW>(); //unity weet hoe een object van ICar aangemaakt moet worden 
            //container.RegisterType<ICar, Audi>();//unity injecteerd laatst geregistreerde type 
            //Driver drv = container.Resolve<Driver>(); // unity maakt object driver met afhankelijkheden
            //drv.RunCar();
            //Driver driver2 = container.Resolve<Driver>();
            //driver2.RunCar();
            //-----------------------------2-----------------------------------
            //container.RegisterType<ICar, BMW>();
            //container.RegisterType<ICar, Audi>("LuxuryCar");

            //ICar bmw = container.Resolve<ICar>();
            //ICar audi = container.Resolve<ICar>("LuxuryCar");
            //Console.WriteLine(bmw);
            //Console.WriteLine(audi);
            //-----------------------------3-----------------------------------
            //container.RegisterType<ICar, BMW>();
            //container.RegisterType<ICar, Audi>("LuxuryCar");

            //container.RegisterType<Driver>("LuxuryCarDriver", new InjectionConstructor(container.Resolve<ICar>("LuxuryCar")));

            //Driver driver = container.Resolve<Driver>(); // Injects BMW
            //driver.RunCar();
            //Driver driver2 = container.Resolve<Driver>("LuxuryCarDriver");//injects Audi
            //driver2.RunCar();
            //-----------------------------4-----------------------------------
            //ICar audi = new Audi();
            //container.RegisterInstance<ICar>(audi);
            //Driver driver1 = container.Resolve<Driver>();
            //driver1.RunCar();
            //driver1.RunCar();

            //Driver driver2 = container.Resolve<Driver>();
            //driver2.RunCar();
            //-----------------------------5-----------------------------------
            //container.RegisterType<ICar, BMW>();
            //var driver = container.Resolve<Driver>();
            //driver.RunCar();
            //-----------------------------6-----------------------------------
            //container.RegisterType<ICar, Audi>();
            //container.RegisterType<ICarKey, AudiKey>();
            //var driver = container.Resolve<Driver>();
            //driver.RunCar();
            //-----------------------------7-----------------------------------
            //container.RegisterType<Driver>(new InjectionConstructor(new Ford()));
            //var driver = container.Resolve<Driver>();
            //driver.RunCar();
            //-----------------------------8-----------------------------------
            container.RegisterType<Driver>(new InjectionConstructor(new object[] { new Audi(), "steve" }));
            var driver = container.Resolve<Driver>(); //injects audi and steve
            driver.RunCar();
            #endregion
        }
    }
}
