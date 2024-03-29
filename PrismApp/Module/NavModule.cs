﻿using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismApp.Views;

namespace PrismApp.Module
{
    class NavModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("nav_region", typeof(NavView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
