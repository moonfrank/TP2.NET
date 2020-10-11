<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server"> 
            <div align="center">
                <asp:Label ID="Academia" runat="server" Text="Academia"></asp:Label>
            </div>
            <div>
                <div align="center">
                    <asp:Label ID="lblBienvenido" runat="server" Text="¡Bienvenido al Sistema!"></asp:Label>
                    <br />
                    <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtClave" TextMode="Password" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" />
                </div>
            </div>
            <div align="center">
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Usuario y/o contraseña incorrectos." ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </div>
    </form> 
</body>
</html>
