using Microsoft.Practices.Prism.Regions;
using MRP4u_Sample.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP4ME_Sample.ViewModels
{
    public class MRPMatrixViewModel : ViewModelBase, INavigationAware
    {

        public MRPMatrixViewModel()
        {
            Title = "MRP Matrix";
        }
    }
}
