using System;


namespace R5T.T0084
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ConfigurationSourceName : IConfigurationSourceName
    {
        #region Static
        
        public static ConfigurationSourceName Instance { get; } = new();

        #endregion
    }
}