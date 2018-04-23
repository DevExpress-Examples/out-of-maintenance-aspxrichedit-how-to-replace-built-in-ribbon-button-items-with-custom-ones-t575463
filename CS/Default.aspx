<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.ASPxRichEdit.v17.1, Version=17.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRichEdit" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v17.1, Version=17.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function onCustomCommandExecuted(s, e) {
            switch (e.commandName) {
                case "New":
                    alert("The New command was executed.");
                    richEdit.commands.fileNew.execute();
                    break;
                case "Open":
                    alert("The Open command was executed.");
                    richEdit.commands.fileOpenDialog.execute();
                    break;
                case "Save":
                    alert("The Save command was executed.");
                    richEdit.commands.fileSave.execute();
                    break;
                case "SaveAs":
                    alert("The SaveAs command was executed.");
                    richEdit.commands.fileSaveAsDialog.execute();
                    break;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxRichEdit ID="RichEdit" ClientInstanceName="richEdit" runat="server" WorkDirectory="~\App_Data\WorkDirectory">
            <Settings>
                <Behavior Printing="Hidden" />
            </Settings>
            <ClientSideEvents CustomCommandExecuted="onCustomCommandExecuted" />
        </dx:ASPxRichEdit>
    </div>
    </form>
</body>
</html>
