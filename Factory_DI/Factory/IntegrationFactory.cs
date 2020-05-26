using Factory_DI.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DI.Factory
{
    public interface IIntegrationFactory
    {
        IIntegrationGetService GetService(string key);
    }

   public  class IntegrationFactory : IIntegrationFactory
    {
        public IIntegrationGetService GetService(string key)
        {
            IIntegrationGetService _service = null;
            switch (key)
            {
                case "Google":
                    _service = new GoogleIntegrationService();
                    break;
                case "Facebook":
                    _service = new FacebookIntegrationService();
                    break;
                default:
                    break;
            }
            return _service;
        }
    }
}
