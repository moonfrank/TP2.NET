<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlumnosInscripciones.aspx.cs" Inherits="UI.Web.AlumnosInscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
            <asp:BoundField DataField="IDAlumno" HeaderText="ID Alumno" SortExpression="IDAlumno" />
            <asp:BoundField DataField="IDCurso" HeaderText="ID Curso" SortExpression="IDCurso" />
            <asp:BoundField DataField="Condicion" HeaderText="Condicion" SortExpression="Condicion" />
            <asp:BoundField DataField="Nota" HeaderText="Nota" SortExpression="Nota" />
            <asp:CommandField ButtonType="Button" HeaderText="Seleccionar" ShowHeader="True" ShowSelectButton="True" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:Panel ID="formPanel" runat="server" Visible="False" Height="232px">
        <asp:Label ID="lblIDAlumno0" runat="server" Text="ID Alumno"></asp:Label>
        <asp:DropDownList ID="ddlIDAlumno" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlIDAlumno_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblIDCurso" runat="server" Text="ID Curso"></asp:Label>
        <asp:DropDownList ID="ddlIDCurso" runat="server" AutoPostBack="true">
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblCondicion" runat="server" Text="Condicion"></asp:Label>
        <asp:DropDownList ID="ddlCondicion" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nota"></asp:Label>
        <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNota" ErrorMessage="Campo no puede estar vacio" ForeColor="Red" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtNota" ErrorMessage="Nota no valida" ForeColor="Red" ValidationExpression="^[0-9]+$" ValidationGroup="vg">*</asp:RegularExpressionValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="vg" />
        <br />
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" ValidationGroup="vg" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
    </asp:Panel>
    <asp:Panel ID="panelActions" runat="server">
        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
    </asp:Panel>
</asp:Content>
