<%@ Page Title="" Language="C#" MasterPageFile="~/View/Backend/Master/masterBack.master" AutoEventWireup="true" CodeFile="~/Controller/Backend/listar_empleados.aspx.cs" Inherits="View_Backend_listar_empleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="pagination">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="GV_Listar_empleados" runat="server" DataSourceID="OBD_lista_empleados" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="nombres" HeaderText="Nombre" />
                        <asp:BoundField DataField="user_name" HeaderText="Nombre Usuario" />
                        <asp:BoundField DataField="correo" HeaderText="Correo" />
                        <asp:BoundField DataField="contrasena" HeaderText="Contraseña" />
                        <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                        <%-- <asp:BoundField DataField="bloqueo" HeaderText="" /> --%>
                        <asp:TemplateField HeaderText="Estado">
                            <ItemTemplate>
                                <%# Convert.ToBoolean(Eval("bloqueo"))? "Activo" : "Inactivo"%>

                            </ItemTemplate>

                        </asp:TemplateField>
                         

              </Columns>                   
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
                <asp:ObjectDataSource ID="OBD_lista_empleados" runat="server" SelectMethod="listar_empleados" TypeName="Datos"></asp:ObjectDataSource>
            </td>
            <td></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

