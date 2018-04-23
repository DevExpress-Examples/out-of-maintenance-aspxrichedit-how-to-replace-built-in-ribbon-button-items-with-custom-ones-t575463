Option Infer On

Imports DevExpress.Web
Imports DevExpress.Web.ASPxThemes
Imports DevExpress.XtraRichEdit
Imports System
Imports System.IO
Imports System.Web
Imports System.Web.Services

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		RichEdit.CreateDefaultRibbonTabs(True)

		For i As Integer = 1 To RichEdit.RibbonTabs.Count - 1
			RichEdit.RibbonTabs(i).Visible = False
		Next i

		RichEdit.RibbonTabs(0).Groups(0).Items.RemoveAt(0)
		Dim newItem = New RibbonButtonItem("New")
		newItem.LargeImage.IconID = IconID.ActionsNew32x32
		newItem.Size = RibbonItemSize.Large
		RichEdit.RibbonTabs(0).Groups(0).Items.Add(newItem)

		RichEdit.RibbonTabs(0).Groups(0).Items.RemoveAt(0)
		Dim openItem = New RibbonButtonItem("Open")
		openItem.LargeImage.IconID = IconID.ActionsOpen32x32
		openItem.Size = RibbonItemSize.Large
		RichEdit.RibbonTabs(0).Groups(0).Items.Add(openItem)

		RichEdit.RibbonTabs(0).Groups(0).Items.RemoveAt(0)
		Dim saveItem = New RibbonButtonItem("Save")
		saveItem.LargeImage.IconID = IconID.SaveSave32x32
		saveItem.Size = RibbonItemSize.Large
		RichEdit.RibbonTabs(0).Groups(0).Items.Add(saveItem)

		RichEdit.RibbonTabs(0).Groups(0).Items.RemoveAt(0)
		Dim saveAsItem = New RibbonButtonItem("SaveAs")
		saveAsItem.LargeImage.IconID = IconID.SaveSaveas32x32
		saveAsItem.Size = RibbonItemSize.Large
		RichEdit.RibbonTabs(0).Groups(0).Items.Add(saveAsItem)
	End Sub
End Class