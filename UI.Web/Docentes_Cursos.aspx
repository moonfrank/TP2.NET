<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Docentes_Cursos.aspx.cs" Inherits="UI.Web.Docentes_Cursos" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="bodyContentPlaceHolder">
    <asp:Panel ID="gridPanel" runat="server" Height="177px">
        <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="IDDocente" HeaderText="ID Docente" SortExpression="IDDocente" />
                <asp:BoundField DataField="IDCurso" HeaderText="ID Curso" SortExpression="IDCurso" />
                <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo" />
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
    <asp:Panel ID="formPanel" runat="server" Height="91px" Visible="False">
        <asp:Label ID="lblIDDocente" runat="server" Text="ID Docente"></asp:Label>
        <asp:DropDownList ID="ddlIDDocente" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="validIDDocente" runat="server" ControlToValidate="ddlIDDocente" ErrorMessage="El ID del docente no puede estar vacío" ForeColor="Red" ValidationGroup="vgDocentesCursos">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblIDCurso" runat="server" Text="ID Curso"></asp:Label>
        <asp:DropDownList ID="ddlIDCurso" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="validIDCurso" runat="server" ControlToValidate="ddlIDCurso" ErrorMessage="El ID del curso no puede estar vacío" ForeColor="Red" ValidationGroup="vgDocentesCursos">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblCargo" runat="server" Text="Cargo"></asp:Label>
        <asp:DropDownList ID="ddlCargo" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="validCargo" runat="server" ControlToValidate="ddlCargo" ErrorMessage="El cargo no puede estar vacío" ForeColor="Red" ValidationGroup="vgDocentesCursos">*</asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="vgDocentesCursos" />   
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server" style="margin-top: 0px">
            <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" />
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
            <asp:Button ID="btnNuevo" runat="server" OnClick="btnNuevo_Click" Text="Nuevo" />
        </asp:Panel>
    <asp:Panel ID="formActionsPanel" runat="server">
                <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
                <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
            </asp:Panel>
</asp:Content>

