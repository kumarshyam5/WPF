﻿using Microsoft.Practices.Prism.Mvvm;
using MRP4u_Sample.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MRP4u_Sample.Views
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : UserControl, IView, ICreateRegionManagerScope
    {
        public Welcome()
        {
            InitializeComponent();
        }

        public bool CreateRegionManagerScope
        {
            get { return true; }
        }
    }
}
