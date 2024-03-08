using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using PrismApp.Module;
using PrismApp.Views;
using System.Windows;

namespace PrismApp
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavView>();
            containerRegistry.RegisterForNavigation<BodyLeftView>();
            containerRegistry.RegisterForNavigation<BodyRightView>();
            containerRegistry.RegisterForNavigation<FooterView>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            moduleCatalog.AddModule(typeof(NavModule));
            moduleCatalog.AddModule(typeof(BodyLeftModule));
            moduleCatalog.AddModule(typeof(BodyRightModule));
            moduleCatalog.AddModule(typeof(FooterModule));
        }
    }

}
