<%@ Page Title="" Language="C#" MasterPageFile="~/View/Backend/Master/masterBack.master" AutoEventWireup="true" CodeFile="~/Controller/Backend/listar_productos.aspx.cs" Inherits="View_Backend_listar_productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="pagination">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataSourceID="ODS_listar_productos" GridLines="None">
                    <Columns>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre Producto" />
                        <asp:BoundField DataField="serial_prod" HeaderText="Serial Producto" />
                        <asp:BoundField DataField="tipo_prod" HeaderText="Tipo producto" />
                        <asp:BoundField DataField="material" HeaderText="Material" />
                        <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                    </Columns>
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#33276A" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_listar_productos" runat="server" SelectMethod="listar_productos" TypeName="Datos"></asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

