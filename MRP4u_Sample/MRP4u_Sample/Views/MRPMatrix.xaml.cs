using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Reporting.WinForms;
using MRP4ME_Sample.Data;
using MRP4ME_Sample.Models;
using MRP4u_Sample.core;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace MRP4ME_Sample.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MRPMatrix : UserControl, IView, ICreateRegionManagerScope
    {
        public MRPMatrix()
        {
            InitializeComponent();
            ViewModelLocationProvider.AutoWireViewModelChanged(this);

            this.rptName.Load += RptName_Load;
        }

        private void RptName_Load(object sender, EventArgs e)
        {
            ReportDataSource rptDataSource = new ReportDataSource();
            DataSet1 datavalue = new DataSet1();
            DataRow dtRow = datavalue.DataTable1.NewRow();
            dtRow["Year"] = 2010;
            dtRow["SalesAcheived"] = 10000;
            dtRow["SalesTarget"] = 8000;
            datavalue.DataTable1.Rows.Add(dtRow);


            rptDataSource.Name = "DataSet1";
            rptDataSource.Value = datavalue.Tables[0].DefaultView;
            this.rptName.LocalReport.DataSources.Add(rptDataSource);
            this.rptName.LocalReport.ReportPath = "RPMatrix.rdlc";
            this.rptName.RefreshReport();
        }

        public bool CreateRegionManagerScope
        {
            get { return true; }
        }
    }
}
