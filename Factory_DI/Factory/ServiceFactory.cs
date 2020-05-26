namespace Factory_DI.Factory
{
    /// <summary>
    /// Factory for response services
    /// </summary>
    public class ServiceFactory<T> : IServiceFactory<T>
    {
        #region Variable
        Autofac.Features.Indexed.IIndex<string, T> _services;
        #endregion

        #region Method
        /// <summary>
        /// Public Constructor with dependency injection for platform base bot service
        /// </summary>
        /// <param name="services"></param>
        public ServiceFactory(Autofac.Features.Indexed.IIndex<string, T> services)
        {
            _services = services;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get instance of bot service for specified platform
        /// </summary>
        /// <param name="platform"></param>
        /// <returns></returns>
        public T GetService(string key)
        {
            T service = default(T);
                        
            if (!_services.TryGetValue(key, out service))
            {
                service = default(T);
            }
            return service;
        }
        #endregion  
    }
}
