using DevExpress.Web;
using DevExpress.Web.ASPxThemes;
using DevExpress.XtraRichEdit;
using System;
using System.IO;
using System.Web;
using System.Web.Services;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RichEdit.CreateDefaultRibbonTabs(true);

        for (int i = 1; i < RichEdit.RibbonTabs.Count; i++)
            RichEdit.RibbonTabs[i].Visible = false;

        RichEdit.RibbonTabs[0].Groups[0].Items.RemoveAt(0);
        var newItem = new RibbonButtonItem("New");
        newItem.LargeImage.IconID = IconID.ActionsNew32x32;
        newItem.Size = RibbonItemSize.Large;
        RichEdit.RibbonTabs[0].Groups[0].Items.Add(newItem);

        RichEdit.RibbonTabs[0].Groups[0].Items.RemoveAt(0);
        var openItem = new RibbonButtonItem("Open");
        openItem.LargeImage.IconID = IconID.ActionsOpen32x32;
        openItem.Size = RibbonItemSize.Large;
        RichEdit.RibbonTabs[0].Groups[0].Items.Add(openItem);

        RichEdit.RibbonTabs[0].Groups[0].Items.RemoveAt(0);
        var saveItem = new RibbonButtonItem("Save");
        saveItem.LargeImage.IconID = IconID.SaveSave32x32;
        saveItem.Size = RibbonItemSize.Large;
        RichEdit.RibbonTabs[0].Groups[0].Items.Add(saveItem);

        RichEdit.RibbonTabs[0].Groups[0].Items.RemoveAt(0);
        var saveAsItem = new RibbonButtonItem("SaveAs");
        saveAsItem.LargeImage.IconID = IconID.SaveSaveas32x32;
        saveAsItem.Size = RibbonItemSize.Large;
        RichEdit.RibbonTabs[0].Groups[0].Items.Add(saveAsItem);
    }
}