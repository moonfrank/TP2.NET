<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="bodyContentPlaceHolder">
    <asp:Panel ID="Panel1" runat="server" Height="216px">
        <asp:GridView ID="grdMaterias" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grdMaterias_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" SortExpression="Descripcion" />
                <asp:BoundField DataField="HsSemanales" HeaderText="Horas Semanales" SortExpression="HsSemanales" />
                <asp:BoundField DataField="HsTotales" HeaderText="Horas Totales" SortExpression="HsTotales" />
                <asp:BoundField DataField="IdPlan" HeaderText="ID Plan" SortExpression="IDPlan" />
                <asp:CommandField ButtonType="Button" HeaderText="Seleccionar" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" BorderStyle="None" Font-Bold="True" ForeColor="White" />
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
    <asp:Panel ID="formPanel" runat="server" Height="142px" Visible="False">
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripción"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="La descripción no puede estar vacía" ForeColor="Red" ValidationGroup="grupo">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblHorasSem" runat="server" Text="Horas Semanales"></asp:Label>
        <asp:TextBox ID="txtHorasSem" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validHorasSem" runat="server" ControlToValidate="txtHorasSem" ErrorMessage="Las horas semanales no pueden estar vacías" ForeColor="Red" ValidationGroup="grupo">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblHorasTot" runat="server" Text="Horas Totales"></asp:Label>
        <asp:TextBox ID="txtHorasTot" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validHorasTot" runat="server" ControlToValidate="txtHorasTot" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="grupo">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblIDPlan" runat="server" Text="ID Plan"></asp:Label>
        <asp:DropDownList ID="ddlIDPlan" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="validIDPlan" runat="server" ControlToValidate="ddlIDPlan" ErrorMessage="El ID del Plan no puede estar vacío" ForeColor="Red" ValidationGroup="grupo">*</asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="grupo" />
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
    </asp:Panel>
    <asp:Panel ID="formActionsPanel" runat="server" Visible="false">
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" ValidateRequestMode="Enabled" ValidationGroup="grupo" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
    </asp:Panel>
</asp:Content>


