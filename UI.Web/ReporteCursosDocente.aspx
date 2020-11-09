<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReporteCursosDocente.aspx.cs" Inherits="UI.Web.ReporteCursosDocente" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <rsweb:ReportViewer ID="reportCursoDocente" runat="server" OnLoad="reportCursosDocente_Load">
            </rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>
