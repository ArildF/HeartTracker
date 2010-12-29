using StructureMap.Configuration.DSL;

namespace Rogue.HeartTracker.Infrastructure
{
    public class InfrastructureRegistry : Registry
    {
        public InfrastructureRegistry()
        {
            Scan(s =>
                {
                    s.TheCallingAssembly();
                    s.SingleImplementationsOfInterface();
                });
        }
    }
}
