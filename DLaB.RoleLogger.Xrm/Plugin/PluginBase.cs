using System;

namespace DLaB.RoleLogger.Xrm.Plugin
{
    public abstract class PluginBase : GenericPluginBase<ExtendedPluginContext>
    {
        /// <inheritdoc />
        protected PluginBase(string unsecureConfig, string secureConfig) : base(unsecureConfig,secureConfig) { }

        /// <inheritdoc />
        protected override ExtendedPluginContext CreatePluginContext(IServiceProvider serviceProvider)
        {
            return new ExtendedPluginContext(serviceProvider, this);
        }
    }
}
