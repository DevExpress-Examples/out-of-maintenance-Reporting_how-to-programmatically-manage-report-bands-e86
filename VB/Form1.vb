Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace ManageReportBands
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private report As New XtraReport1()

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			report.CreateDocument()
			report.ShowPreview()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			report.AddMarginBands()
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
			report.RemoveMarginBands()
		End Sub
	End Class
End Namespace