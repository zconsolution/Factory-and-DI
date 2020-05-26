using Factory_DI;
using Factory_DI.Factory;
using Factory_DI.Integration;

namespace ConsoleApp1
{
    public class PersonDIController
    {
        protected readonly IServiceFactory<IIntegrationGetService> _serviceFactory;

        public PersonDIController(IServiceFactory<IIntegrationGetService> serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }
        public Person GetPerson(string key, string id)
        {
            Person person = null;
            
            var service = _serviceFactory.GetService(key);
            if (service != null)
            {
                person = service.GetPerson("GUID");
            }
            return person;
        }
       
    }
}
