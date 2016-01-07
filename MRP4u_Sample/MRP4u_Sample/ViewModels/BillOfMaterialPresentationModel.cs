using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;
using MRP4ME_Sample.Models;
using MRP4u_Sample.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MRP4u_Sample.ViewModels
{
    class BillOfMaterialViewModel : ViewModelBase
    {
        public BillOfMaterialViewModel()
        {
            Title = "Bill Of Material";
            this.InitializeData();
        }

        private void InitializeData()
        {
            billOfMaterials = new List<BillOfMaterial>();
            billOfMaterials.Add(new BillOfMaterial() { Id = "PO101", Name = "A", Unit = "Piece", Quantity = 1, Level = 0, Owner = "Jennifer Martin", LeadTime = DateTime.Now });
            billOfMaterials.Add(new BillOfMaterial() { Id = "PO101", Name = "A", Unit = "Piece", Quantity = 1, Level = 0, Owner = "Jennifer Martin", LeadTime = DateTime.Now });
            billOfMaterials.Add(new BillOfMaterial() { Id = "PO101", Name = "A", Unit = "Piece", Quantity = 1, Level = 0, Owner = "Jennifer Martin", LeadTime = DateTime.Now });
            billOfMaterials.Add(new BillOfMaterial() { Id = "PO101", Name = "A", Unit = "Piece", Quantity = 1, Level = 0, Owner = "Jennifer Martin", LeadTime = DateTime.Now });
            billOfMaterials.Add(new BillOfMaterial() { Id = "PO101", Name = "A", Unit = "Piece", Quantity = 1, Level = 0, Owner = "Jennifer Martin", LeadTime = DateTime.Now });
            billOfMaterials.Add(new BillOfMaterial() { Id = "PO101", Name = "A", Unit = "Piece", Quantity = 1, Level = 0, Owner = "Jennifer Martin", LeadTime = DateTime.Now });
            billOfMaterials.Add(new BillOfMaterial() { Id = "PO101", Name = "A", Unit = "Piece", Quantity = 1, Level = 0, Owner = "Jennifer Martin", LeadTime = DateTime.Now });
            billOfMaterials.Add(new BillOfMaterial() { Id = "PO101", Name = "A", Unit = "Piece", Quantity = 1, Level = 0, Owner = "Jennifer Martin", LeadTime = DateTime.Now });
        }

        private List<BillOfMaterial> billOfMaterials;
        public List<BillOfMaterial> BillsOfMaterials
        {
            get
            {
                return billOfMaterials;
            }
        }
    }
}
