using System;
using Rogue.HeartTracker.Infrastructure;
using StructureMap;

namespace Rogue.HeartTracker.UI
{
    public class Bootstrapper
    {
        private IContainer _container;

        public IShellView Bootstrap()
        {
            _container = new Container(c =>
                {
                    c.AddRegistry<InfrastructureRegistry>();
                    c.AddRegistry<UIRegistry>();
                });


            return _container.GetInstance<IShellView>();
        }
    }
}