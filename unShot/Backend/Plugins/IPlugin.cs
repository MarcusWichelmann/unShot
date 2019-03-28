namespace UnShot.Backend.Plugins
{
    public interface IPlugin
    {
        string Name { get; }
        
        string Description { get; }
        
        string Vendor { get; }
    }
}