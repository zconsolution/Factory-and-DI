using Autofac;
using Factory_DI.Factory;
using Factory_DI.Integration;
using System;

namespace ConsoleApp1
{
    class Program_Factory
    {
        //static void Main(string[] args)
        //{
        //    string key = null;
        //    do
        //    {
        //        key = Console.ReadLine();
        //        var person = new PersonController().GetPerson(key, "GUID");
        //        Console.WriteLine(person.ToString());

        //    } while (!string.IsNullOrEmpty(key));
        //}



        static void Main(string[] args)
        {
            var container = GetContainer();
            container.Resolve<Application>().Run();
        }

        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>();
            builder.RegisterType<ServiceFactory<IIntegrationGetService>>().As<IServiceFactory<IIntegrationGetService>>();
            builder.RegisterType<GoogleIntegrationService>().Keyed<IIntegrationGetService>("Google");
            builder.RegisterType<FacebookIntegrationService>().Keyed<IIntegrationGetService>("Facebook");

            return builder.Build();
        }
    }
}
