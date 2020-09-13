<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="grdEspecialidades" runat="server" AllowCustomPaging="True" AutoGenerateColumns="False" Height="191px" Width="258px">
            <Columns>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                <asp:CommandField ButtonType="Button" HeaderText="Seleccionar" ShowSelectButton="True" />
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
    <asp:Panel ID="formPanel" runat="server" Height="64px" Visible="False">
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BorderColor="Red" ControlToValidate="txtDescripcion" ErrorMessage="La descripción no puede estar vacía" ForeColor="Red" ValidationGroup="grupo">*</asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="grupo" />
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:Button ID="editarLinkButton" runat="server" Text="Editar" OnClick="editarLinkButton_Click" />
        <asp:Button ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click" Text="Eliminar" />
        <asp:Button ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click" Text="Nuevo" />
    </asp:Panel>
    <asp:Panel ID="formActionsPanel" runat="server">
        <asp:Button ID="aceptarLinkButton" runat="server" Text="Aceptar" OnClick="aceptarLinkButton_Click" />
        <asp:Button ID="cancelarLinkButton" runat="server" Text="Cancelar" />
    </asp:Panel>
</asp:Content>
