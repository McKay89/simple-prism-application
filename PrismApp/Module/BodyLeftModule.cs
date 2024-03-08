using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismApp.Views;

namespace PrismApp.Module
{
    class BodyLeftModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("left_side", typeof(BodyLeftView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
