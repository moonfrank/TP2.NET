<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="UI.Web.Planes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="IDEspecialidad" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="IDEspecialidad" HeaderText="ID Especialidad" SortExpression="IDEspecialidad" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripción" SortExpression="Descripcion" />
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
        <asp:Label ID="lblIDEspecialidad" runat="server" Text="ID Especialidad"></asp:Label>
        <asp:ListBox ID="listIDEspecialidad" runat="server"></asp:ListBox>
        <asp:RequiredFieldValidator ID="validIDEspecialidad" runat="server" ControlToValidate="listIDEspecialidad" ErrorMessage="El ID de Especialidad no puede estar vacío" ForeColor="Red" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripción"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="La descripción no puede estar vacía" ForeColor="Red" ValidationGroup="vg">*</asp:RequiredFieldValidator>
        <br />
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
    </asp:Panel>
    <asp:Panel ID="formActionsPanel" runat="server">
        <asp:LinkButton ID="linkAceptar" runat="server" Text="Aceptar"/>
        <asp:LinkButton ID="linkCancelar" runat="server" Text="Cancelar"/>
    </asp:Panel>
</asp:Content>
