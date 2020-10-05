<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web.Personas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridViewPersona" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gridView_SelectedIndexChanged" DataKeyNames="ID">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField AccessibleHeaderText="ID" DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" SortExpression="Legajo" />
                <asp:BoundField DataField="IDPlan" HeaderText="ID Plan" SortExpression="IDPlan" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                <asp:BoundField DataField="Direccion" HeaderText="Dirección" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Teléfono" SortExpression="Telefono" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de Nacimiento" SortExpression="FechaNacimiento" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="TipoPersona" HeaderText="Rol" SortExpression="TipoPersona" />
                <asp:CommandField ButtonType="Button" HeaderText="Seleccionar" ShowHeader="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="formPanel" runat="server" Visible="False">
        <asp:Label ID="lblIDPlan" runat="server" Text="ID Plan"/>
        <asp:DropDownList ID="ddlIDPlan" runat="server"/>

        <asp:Label ID="lblTipoPersona" runat="server" Text="Rol"/>
        <asp:DropDownList ID="ddlTipoPersona" runat="server"/>
    <br />
        <asp:Label ID="lblLegajo" runat="server" Text="Legajo"/>
        <asp:TextBox ID="txtLegajo" runat="server"/>
        <asp:RequiredFieldValidator ID="vldLegajo" runat="server" ControlToValidate="txtLegajo" ErrorMessage="El campo Legajo no puede estar vacío" ForeColor="Red"/>
    <br />
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"/>
        <asp:TextBox ID="txtNombre" runat="server"/>
        <asp:RequiredFieldValidator ID="vldNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="El campo Nombre no puede estar vacío" ForeColor="Red"/>
    <br />
        <asp:Label ID="lblApellido" runat="server" Text="Apellido"/>
        <asp:TextBox ID="txtApellido" runat="server"/>
        <asp:RequiredFieldValidator ID="vldApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="El campo Apellido no puede estar vacío" ForeColor="Red"/>
    <br />
        <asp:Label ID="lblDireccion" runat="server" Text="Dirección"/>
        <asp:TextBox ID="txtDireccion" runat="server"/>
        <asp:RequiredFieldValidator ID="vldDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="El campo Dirección no puede estar vacío" ForeColor="Red"/>
    <br />
        <asp:Label ID="lblTelefono" runat="server" Text="Teléfono"/>
        <asp:TextBox ID="txtTelefono" runat="server"/>
        <asp:RequiredFieldValidator ID="vldTelefono" runat="server" ControlToValidate="txtTelefono" ErrorMessage="El campo Teléfono no puede estar vacío" ForeColor="Red"/>
    <br />
        <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento"/>
        <asp:TextBox ID="txtFechaNacimiento" runat="server"/>
        <asp:RequiredFieldValidator ID="vldFechaNacimiento" runat="server" ControlToValidate="txtFechaNacimiento" ErrorMessage="Formato de fecha inválido" ForeColor="Red"/>
        <asp:CompareValidator
            id="dateValidator" runat="server" 
            Type="Date"
            Operator="DataTypeCheck"
            ControlToValidate="txtFechaNacimiento" 
            ErrorMessage="Formato de fecha inválido"
            ForeColor="Red">
        </asp:CompareValidator>
    <br />
        <asp:ValidationSummary ID="vldsFormPanel" runat="server" ForeColor="Red" />
    <br />
    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />
    </asp:Panel>
    <asp:Panel ID="panelActions" runat="server">
        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
    </asp:Panel>
</asp:Content>
