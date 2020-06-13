using System;

namespace ApplicationExtensibility.Plugin.Models
{
    [Flags]
    public enum PluginType
    {
        ContainerReader = 1,
        MenuItem        = 2
    }
}