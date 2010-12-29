using StructureMap.Configuration.DSL;

namespace Rogue.HeartTracker.UI
{
    public class UIRegistry : Registry
    {
        public UIRegistry()
        {
            Scan(s =>
                {
                    s.TheCallingAssembly();
                    s.WithDefaultConventions();
                });
        }
    }
}