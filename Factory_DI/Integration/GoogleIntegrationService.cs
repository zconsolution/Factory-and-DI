

namespace Factory_DI.Integration
{
    /// <summary>
    /// Google response service
    /// </summary>
    public class GoogleIntegrationService : IIntegrationGetService
    {
        public Person GetPerson(string id)
        {
            return new Person() { FirstName = "Google User", Gender = "Male", LastName = "l1" };
        }
    }
}
