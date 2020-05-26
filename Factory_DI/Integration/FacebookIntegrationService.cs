namespace Factory_DI.Integration
{
    /// <summary>
    /// Facebook response service
    /// </summary>
    public class FacebookIntegrationService : IIntegrationGetService
    {
        public Person GetPerson(string id)
        {
            return new Person() { FirstName = "Facebook User" , Gender="Male" , LastName= "l1"};
        }
    }
}
