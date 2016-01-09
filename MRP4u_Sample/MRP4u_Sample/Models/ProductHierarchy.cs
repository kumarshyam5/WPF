using MRP4ME_Sample.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP4ME_Sample.Models
{
    class ProductHierarchy
    {
        private static ProductHierarchy self;

        //orgchart stored in dictionary
        private Dictionary<int, Node> list = new Dictionary<int, Node>();

        private ProductHierarchy()
        {
            //populate data
            list.Add(1, new Node { Id = 1, FirstName = "Item A - ", LastName = "(1)", ParentId = 1 });
            list.Add(2, new Node { Id = 2, FirstName = "Item B - ", LastName = "(2)", ParentId = 1 });
            list.Add(3, new Node { Id = 3, FirstName = "Item C - ", LastName = "(3)", ParentId = 1 });
            list.Add(4, new Node { Id = 4, FirstName = "Item D - ", LastName = "(2)", ParentId = 2 });
            list.Add(5, new Node { Id = 5, FirstName = "Item B - ", LastName = "(2)", ParentId = 2 });
            list.Add(6, new Node { Id = 6, FirstName = "Item E - ", LastName = "(2)", ParentId = 3 });
            list.Add(7, new Node { Id = 7, FirstName = "Item F - ", LastName = "(2)", ParentId = 3 });
            list.Add(8, new Node { Id = 8, FirstName = "Item G - ", LastName = "(1)", ParentId = 7 });
            list.Add(9, new Node { Id = 9, FirstName = "Item D - ", LastName = "(2)", ParentId = 7 });
        }

        internal static ProductHierarchy Instance()
        {
            if (self == null)
                self = new ProductHierarchy();
            return self;
        }

        //get the root
        internal Node GetRoot()
        {
            return list[1];  //return the top root node
        }

        //get the children of a node
        internal IEnumerable<Node> GetChildren(int parentId)
        {
            return from a in list
                   where a.Value.ParentId == parentId
                        && a.Value.Id != parentId   //don't include the root, which has the same Id and ParentId
                   select a.Value;
        }


    }
}
