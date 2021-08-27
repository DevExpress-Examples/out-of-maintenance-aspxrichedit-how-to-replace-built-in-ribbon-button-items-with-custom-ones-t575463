<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128545490/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T575463)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))**
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# ASPxRichEdit - How to replace built-in ribbon button items with custom ones


<p>Starting with version 16.1, a client-side API was introduced for ASPxRichEdit (see <a href="https://www.devexpress.com/Subscriptions/New-2016-1.xml#aspnet">What's New in 16.1</a>). It became possible to perform actions by executing client-side commands.<br><br>This example demonstrates how to replace built-in ribbon button items with custom ones to modify their standard commands. To define what custom button was clicked use the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.Scripts.ASPxClientRichEdit.CustomCommandExecuted.event">ASPxClientRichEdit.CustomCommandExecuted</a> event. Then use the appropriate client-side command to imitate the default ribbon button behavior. You can see the list of available client-side ASPxRichEdit commands in the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.Scripts.RichEditCommands.members">ASPxClientRichEdit.commands</a> topic. This example uses the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.Scripts.RichEditCommands.fileNew.property">fileNew</a>, <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.Scripts.RichEditCommands.fileOpenDialog.property">fileOpenDialog</a>, <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.Scripts.RichEditCommands.fileSave.property">fileSave</a> and <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.Scripts.RichEditCommands.fileSaveAsDialog.property">fileSaveAsDialog</a> commands.</p>

<br/>


