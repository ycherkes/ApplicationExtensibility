namespace ApplicationExtensibility.Plugin.Models
{
    public interface IPlugin<in TIn, out TOut>
    {
        PluginType PluginType { get;}
        IMenuInfo MenuInfo { get; }
        TOut GetData(TIn param);
    }
}
