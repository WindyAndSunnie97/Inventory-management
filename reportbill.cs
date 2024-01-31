using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKho1
{
    public partial class reportbill : Form
    {
        public reportbill()
        {
            InitializeComponent();
        }
        Context db = new Context();
        private void reportbill_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
                {
                    ProcessingMode = ProcessingMode.Local
                };
            reportViewer.LocalReport.DataSources.Add(new
          ReportDataSource("DataSet1", db.DcDetail.Select(p => new
          {
              p.ProductDetailID,
              p.Quantity,
              p.DcDetailID,
              p.Price
              

          }).ToList())) ;
                reportViewer.Dock = DockStyle.Fill;
                reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
               "\\Report.rdlc";
                Controls.Add(reportViewer);
                reportViewer.RefreshReport();
            }
        }
    }

