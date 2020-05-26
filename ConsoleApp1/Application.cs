
using Factory_DI.Factory;
using Factory_DI.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Application
    {
        
        protected readonly IServiceFactory<IIntegrationGetService> _serviceFactory;

        public Application(IServiceFactory<IIntegrationGetService> serviceFactory)
        {
            _serviceFactory = serviceFactory; //Injected            
        }

        public void Run()
        {
            string key = null;
            do
            {
                key = Console.ReadLine();
                var person = new PersonDIController(_serviceFactory).GetPerson(key, "GUID");                
                if (person!=null)
                 {
                    Console.WriteLine(person.ToString());
                }

            } while (!string.IsNullOrEmpty(key));
        }
    }
}
