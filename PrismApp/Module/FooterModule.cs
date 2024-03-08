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
    class FooterModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("footer_region", typeof(FooterView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
