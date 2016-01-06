using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MRP4u_Sample.core;

namespace MRP4u_Sample
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(AppModule));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            ViewModelLocationProvider.SetDefaultViewModelFactory((type) => Container.Resolve(type));

            Container.RegisterType<IRegionNavigationContentLoader, ScopedRegionNavigationContentLoader>(new ContainerControlledLifetimeManager());
        }

        protected override IRegionBehaviorFactory ConfigureDefaultRegionBehaviors()
        {
            IRegionBehaviorFactory behaviors = base.ConfigureDefaultRegionBehaviors();
            behaviors.AddIfMissing(RegionManagerAwareBehavior.BehaviorKey, typeof(RegionManagerAwareBehavior));
            return behaviors;
        }
    }
}
