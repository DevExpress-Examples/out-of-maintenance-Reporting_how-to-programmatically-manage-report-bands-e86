using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace ManageReportBands {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private XtraReport1 report = new XtraReport1();

        private void button1_Click(object sender, System.EventArgs e) {
            ReportPrintTool printTool = new ReportPrintTool(report);
            ((XtraReport1)printTool.Report).CreateDocument();
            ((XtraReport1)printTool.Report).ShowPreviewDialog();
        }

        private void button2_Click(object sender, System.EventArgs e) {
            report.AddMarginBands();
        }

        private void button3_Click(object sender, System.EventArgs e) {
            report.RemoveMarginBands();
        }
    }
}