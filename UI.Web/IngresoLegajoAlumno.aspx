<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresoLegajoAlumno.aspx.cs" Inherits="UI.Web.IngresoLegajoAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLegajo" runat="server" Text="Legajo"></asp:Label>
            <asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" Text="OK" />
        </div>
    </form>
</body>
</html>
