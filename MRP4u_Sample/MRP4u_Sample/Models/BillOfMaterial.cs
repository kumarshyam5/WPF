using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP4ME_Sample.Models
{
    public class BillOfMaterial:BaseModel
    {
        private string id;
        public string Id { get { return this.id; } set { SetProperty(ref id, value); } }

        private string name;
        public string Name { get { return this.name; } set { SetProperty(ref name, value); } }

        private string unit;
        public string Unit { get { return this.unit; } set { SetProperty(ref unit, value); } }

        private decimal quantity;
        public decimal Quantity { get { return this.quantity; } set { SetProperty(ref quantity, value); } }

        private int level;
        public int Level { get { return this.level; } set { SetProperty(ref level, value); } }

        private string owner;
        public string Owner { get { return this.owner; } set { SetProperty(ref owner, value); } }

        private DateTime leadtime;
        public DateTime LeadTime { get { return this.leadtime; } set { SetProperty(ref leadtime, value); } }
    }
}
