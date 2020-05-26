using Factory_DI;
using Factory_DI.Factory;

namespace ConsoleApp1
{
    public class PersonControllerWithouFactory
    {
        public Person GetPerson(string key, string id)
        {
            Person person = null;
            switch (key)
            {
                case "Google":
                    person = new Person() { FirstName = "Google User", Gender = "Male", LastName = "l1" };
                    break;
                case "Facebook":
                    person = new Person() { FirstName = "Facebook User", Gender = "Male", LastName = "l1" };                    
                    break;
                default:
                    break;
            }
            return person;
        }
        public Person Insert(string key, Person person)
        {            
            switch (key)
            {
                case "Google":
                    
                    break;
                case "Facebook":
                    
                    break;
                default:
                    break;
            }
            return person;
        }
    }
}
