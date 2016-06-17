using PointOfSale.DbConfiguration;
using PointOfSale.Utils.TablesClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace PointOfSale.ListForms
{
    public partial class CrstalReportView : Form
    {
        private String invoiceId;
        HandleInvoice invoice;

        public string InvoiceId
        {
            get
            {
                return invoiceId;
            }

            set
            {
                invoiceId = value;
            }
        }

        public CrstalReportView()
        {
            InitializeComponent();
        }

        
private void CrstalReportView_Load_1(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
           cryRpt.Load("C:\\Users\\mac\\Documents\\Visual Studio 2015\\Projects\\PointOfSale\\PointOfSale\\CrystalReport3.rpt");

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = invoiceId;
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["invoiceId"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crystalReportViewer2.ReportSource = cryRpt;
            crystalReportViewer2.Refresh();

        }
        //{
        //    CrystalReport1 crystalReport = new CrystalReport1();
        //    invoice = new HandleInvoice();
        //    TableInvoice table = new TableInvoice();
        //    table.InvoiceId = Int32.Parse(InvoiceId);
        //    TableInvoice rpt = invoice.filerInvoiceCrystalReport(table);
        //    crystalReport.SetDataSource(new[] { rpt } );
        //    this.crystalReportViewer1.ReportSource = crystalReport;
        //    this.crystalReportViewer1.RefreshReport();




    }
}
