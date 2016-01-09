﻿using MRP4ME_Sample.Models;
using MRP4u_Sample.core;
using System.Collections.Generic;

namespace MRP4ME_Sample.ViewModels
{
    class ProductStructureViewModel : ViewModelBase
    {
        public ProductStructureViewModel()
        {
            Title = "Product Structure";
        }

        private static ProductStructureViewModel self;

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


        public static ProductStructureViewModel Instance()
        {
            if (self == null)
                self = new ProductStructureViewModel();
            return self;
        }
    }
}
