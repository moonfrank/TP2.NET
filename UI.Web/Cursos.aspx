<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridViewCurso" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gridView_SelectedIndexChanged" DataKeyNames="ID">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField AccessibleHeaderText="ID" DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="IDMateria" HeaderText="ID Materia" SortExpression="IDMateria" />
                <asp:BoundField DataField="IDComision" HeaderText="ID Comision" SortExpression="IDComision" />
                <asp:BoundField DataField="AnioCalendario" HeaderText="Año" SortExpression="Año" />
                <asp:BoundField DataField="Cupo" HeaderText="Cupo" SortExpression="Cupo" />
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
    </asp:Panel>
    <asp:Panel ID="formPanel" runat="server" Visible="False">
        <asp:Label ID="lblMateria" runat="server" Text="ID Materia"></asp:Label>
        <asp:DropDownList ID="ddlMateria" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblComision" runat="server" Text="ID Comision"></asp:Label>
        <asp:DropDownList ID="ddlComision" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblAño" runat="server" Text="Año"></asp:Label>
        <asp:TextBox ID="txtAño" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCupo" runat="server" Text="Cupo"></asp:Label>
        <asp:TextBox ID="txtCupo" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />
    </asp:Panel>
    <asp:Panel ID="panelActions" runat="server">
        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        <asp:Button ID="btnNuevo" runat="server" OnClick="btnNuevo_Click" Text="Nuevo" />
    </asp:Panel>
</asp:Content>
