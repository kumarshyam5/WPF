using MRP4ME_Sample.Models;
using MRP4u_Sample.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP4ME_Sample.ViewModels
{
    class OrgTreeViewModel : ViewModelBase
    {
        private static OrgTreeViewModel self;

        private List<OrgElementViewModel> root;

        //the root of the visual tree
        public List<OrgElementViewModel> Root
        {
            get
            {
                if (root == null)
                {
                    root = new List<OrgElementViewModel>();
                    OrgElementViewModel vmRoot = new OrgElementViewModel(ProductHierarchy.Instance().GetRoot());
                    vmRoot.IsRoot = true;
                    root.Add(vmRoot);
                }
                return root;
            }
        }

        private OrgTreeViewModel() { }

        public static OrgTreeViewModel Instance()
        {
            if (self == null)
                self = new OrgTreeViewModel();
            return self;
        }

    }
}
