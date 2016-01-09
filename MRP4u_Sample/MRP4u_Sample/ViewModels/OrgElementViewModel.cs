using MRP4ME_Sample.core;
using MRP4ME_Sample.Models;
using MRP4u_Sample.core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP4ME_Sample.ViewModels
{
    public class OrgElementViewModel : ViewModelBase
    {
        private int Id;
        private string firstName;
        private string lastName;
        private string imagePath;
        private ObservableCollection<OrgElementViewModel> children;
        private bool isRoot = false;  //if the node is the root

        public bool IsRoot
        {
            get { return isRoot; }
            set { isRoot = value; }
        }

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        public ObservableCollection<OrgElementViewModel> Children
        {
            get
            {
                if (children == null) //not yet initialized
                    return GetChildren();
                return children;
            }
            set
            {
                children = value;
                OnPropertyChanged("Children");
            }
        }

        internal OrgElementViewModel(Node i)
        {
            this.ID = i.Id;
            this.FirstName = i.FirstName;
            this.LastName = i.LastName;
            this.ImagePath = Path.GetFullPath("Images/" + this.ID.ToString() + ".png");
        }

        private ObservableCollection<OrgElementViewModel> GetChildren()
        {
            children = new ObservableCollection<OrgElementViewModel>();
            //get the list of children from Model
            foreach (Node i in ProductHierarchy.Instance().GetChildren(this.ID))
            {
                children.Add(new OrgElementViewModel(i));
            }
            return children;
        }
    }
}
