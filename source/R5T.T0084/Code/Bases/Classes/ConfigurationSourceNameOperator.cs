using System;


namespace R5T.T0084
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ConfigurationSourceNameOperator : IConfigurationSourceNameOperator
    {
        #region Static
        
        public static ConfigurationSourceNameOperator Instance { get; } = new();

        #endregion
    }
}