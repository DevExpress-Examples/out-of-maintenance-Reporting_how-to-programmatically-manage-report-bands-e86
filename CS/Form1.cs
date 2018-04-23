using System;
using System.Windows.Forms;

namespace ManageReportBands {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private XtraReport1 report = new XtraReport1();

        private void button1_Click(object sender, System.EventArgs e) {
            report.CreateDocument();
            report.ShowPreview();
        }

        private void button2_Click(object sender, System.EventArgs e) {
            report.AddMarginBands();
        }

        private void button3_Click(object sender, System.EventArgs e) {
            report.RemoveMarginBands();
        }
    }
}