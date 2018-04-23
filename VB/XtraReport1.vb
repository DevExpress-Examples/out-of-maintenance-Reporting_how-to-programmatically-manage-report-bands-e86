Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...

Namespace ManageReportBands
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub AddMarginBands()

			' Check if the TopMargin band already presents in the report.
			If Bands.GetBandByType(GetType(TopMarginBand)) Is Nothing Then
				' Create a new TopMargin band and add it to the report.
				Dim tmBand As New TopMarginBand()
				Bands.Add(tmBand)

				' Create a label and set its text and width.
				Dim label As New XRLabel()
				label.Text = "TopMargin Band"
				label.Width = 200

				' Add the label to the TopMargin band.
				tmBand.Controls.Add(label)
			End If

			' Check if the BottomMargin band already presents in the report.
			If Bands.GetBandByType(GetType(BottomMarginBand)) Is Nothing Then
				' Create a new BottomMargin band and add it to the report.
				Dim bmBand As New BottomMarginBand()
				Bands.Add(bmBand)

				' Create an XRPageInfo object and set its width and PageInfo option.
				Dim datePageInfo As New XRPageInfo()
				datePageInfo.Width = 200
				datePageInfo.PageInfo = PageInfo.DateTime

				' Add the page information control to the BottomMargin band.
				bmBand.Controls.Add(datePageInfo)
			End If
		End Sub


		Public Sub RemoveMarginBands()
			' Obtain the TopMargin band and remove it from the report.
			Dim band As Band = Bands.GetBandByType(GetType(TopMarginBand))
			If band IsNot Nothing Then
				Bands.Remove(band)
			End If

			' Obtain the BottomMargin band and remove it from the report.
			band = Bands.GetBandByType(GetType(BottomMarginBand))
			If band IsNot Nothing Then
				Bands.Remove(band)
			End If
		End Sub

	End Class
End Namespace
