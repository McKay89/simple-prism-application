using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.Module
{
    class BodyRightModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("right_side", typeof(BodyRightView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
