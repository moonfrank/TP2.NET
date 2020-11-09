<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresoIDDocente.aspx.cs" Inherits="UI.Web.IngresoIDDocente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 85px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="lblIDDocente" runat="server" Text="ID Docente"></asp:Label>
            <asp:ListBox ID="lbIDDocente" runat="server" Height="21px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnAceptar" runat="server" OnClick="Button1_Click" Text="OK" />
        </div>
    </form>
</body>
</html>
