using Microsoft.Practices.Prism.Mvvm;
using MRP4u_Sample.core;
using System.Windows.Controls;


namespace MRP4u_Sample.Views
{
    /// <summary>
    /// Interaction logic for BillOfMaterial.xaml
    /// </summary>
    public partial class BillOfMaterial :UserControl, IView, ICreateRegionManagerScope
    {
        public BillOfMaterial()
        {
            InitializeComponent();
            ViewModelLocationProvider.AutoWireViewModelChanged(this);
        }

        public bool CreateRegionManagerScope
        {
            get { return true; }
        }
    }
}
