namespace Factory_DI.Factory
{
    /// <summary>
    /// Factory interface for response services
    /// </summary>
    public interface IServiceFactory<T>
    {
        /// <summary>
        /// Get bot service for specified platform
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        T GetService(string key);
    }
}
