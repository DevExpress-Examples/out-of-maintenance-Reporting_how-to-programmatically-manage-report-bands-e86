using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
// ...

namespace ManageReportBands {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        public void AddMarginBands() {

            // Check if the TopMargin band already presents in the report.
            if (Bands.GetBandByType(typeof(TopMarginBand)) == null) {
                // Create a new TopMargin band and add it to the report.
                TopMarginBand tmBand = new TopMarginBand();
                Bands.Add(tmBand);

                // Create a label and set its text and width.
                XRLabel label = new XRLabel();
                label.Text = "TopMargin Band";
                label.Width = 200;

                // Add the label to the TopMargin band.
                tmBand.Controls.Add(label);
            }

            // Check if the BottomMargin band already presents in the report.
            if (Bands.GetBandByType(typeof(BottomMarginBand)) == null) {
                // Create a new BottomMargin band and add it to the report.
                BottomMarginBand bmBand = new BottomMarginBand();
                Bands.Add(bmBand);

                // Create an XRPageInfo object and set its width and PageInfo option.
                XRPageInfo datePageInfo = new XRPageInfo();
                datePageInfo.Width = 200;
                datePageInfo.PageInfo = PageInfo.DateTime;

                // Add the page information control to the BottomMargin band.
                bmBand.Controls.Add(datePageInfo);
            }
        }


        public void RemoveMarginBands() {
            // Obtain the TopMargin band and remove it from the report.
            Band band = Bands.GetBandByType(typeof(TopMarginBand));
            if (band != null) Bands.Remove(band);

            // Obtain the BottomMargin band and remove it from the report.
            band = Bands.GetBandByType(typeof(BottomMarginBand));
            if (band != null) Bands.Remove(band);
        }

    }
}
