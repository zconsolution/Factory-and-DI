using Factory_DI;
using Factory_DI.Factory;

namespace ConsoleApp1
{
    public class PersonController
    {
        public Person GetPerson(string key, string id)
        {
            Person person = null;
            IIntegrationFactory factory = new IntegrationFactory();
            var service = factory.GetService(key);
            if (service != null)
            {
                person = service.GetPerson("GUID");
            }
            return person;
        }
       
    }
}
