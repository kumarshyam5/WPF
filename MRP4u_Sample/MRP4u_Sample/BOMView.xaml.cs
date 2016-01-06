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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace MRP4ME_Sample
{
    /// <summary>
    /// Interaction logic for BOMView.xaml
    /// </summary>
    public partial class BOMView : MetroWindow
    {
        public BOMView()
        {
            InitializeComponent();

            FillBom();
        }


        void FillBom()
        {
           
            XElement bomList = XElement.Load("BomDetails.xml");
            BomDataGrid.DataContext = bomList;
        }
    }
}
