using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using MRP4ME_Sample.Views;
using MRP4u_Sample.Views;

namespace MRP4u_Sample
{
    public class AppModule : IModule
    {
        private readonly IUnityContainer _container;

        public AppModule(IUnityContainer container)
        {
            _container = container;
        }

        public void Initialize()
        {
            _container.RegisterType<object, Welcome>("Welcome");
            _container.RegisterType<object, BillOfMaterial>("BillOfMaterial");
            _container.RegisterType<object, ProductStructure>("ProdStructure");
        }
    }
}
