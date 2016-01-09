using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Regions;
using MRP4u_Sample.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP4u_Sample.ViewModels
{
    public class WelcomeViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;
        public DelegateCommand<string> NavigateCommand { get; set; }

        public WelcomeViewModel(IRegionManager regionManager)
        {
            Title = "Home";
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        void Navigate(string navigationPath)
        {
            if (!string.IsNullOrEmpty(navigationPath))
            {
                _regionManager.RequestNavigate("TabRegion", navigationPath);
            }
        }
    }
}
