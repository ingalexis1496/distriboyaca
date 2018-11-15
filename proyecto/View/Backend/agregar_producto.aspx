<%@ Page Title="" Language="C#" MasterPageFile="~/View/Backend/Master/masterBack.master" AutoEventWireup="true" CodeFile="~/Controller/Backend/agregar_producto.aspx.cs" Inherits="View_Backend_agregar_producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 70px;
        }
        .auto-style2 {
            width: 141px;
        }
        .auto-style3 {
            height: 56px;
        }
        .auto-style4 {
            width: 70px;
            height: 56px;
        }
        .auto-style6 {
            width: 164px;
            height: 56px;
        }
        .auto-style7 {
            width: 308px;
        }
        .auto-style8 {
            height: 56px;
            width: 308px;
        }
        .auto-style9 {
            width: 164px;
        }
        .auto-style10 {
            width: 193px;
        }
        .auto-style11 {
            height: 56px;
            width: 193px;
        }
        .auto-style12 {
            width: 46px;
        }
        .auto-style13 {
            width: 46px;
            height: 56px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="pagination">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">
                <asp:Label ID="LB_regis_produc" runat="server" Font-Size="XX-Large" Font-Strikeout="False" Text="Registrar Producto:"></asp:Label>
            </td>
            <td class="auto-style12">
                &nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="LB_nombre" runat="server" Text="Nombre:"></asp:Label>
&nbsp; </td>
            <td class="auto-style7">
                <asp:TextBox ID="TB_nombre" runat="server" Width="109px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="auto-style12">
                <asp:Label ID="LB_cantidad" runat="server" Text="Cantidad:"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TB_cantidad" runat="server" Width="37px"></asp:TextBox>
            </td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="LB_serial" runat="server" Text="Serial:"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="TB_serial" runat="server" Width="104px"></asp:TextBox>
            </td>
            <td class="auto-style12">
                &nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4">
                <asp:Label ID="Label1" runat="server" Text="Tipo Producto"></asp:Label>
            </td>
            <td class="auto-style8">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server">Material</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="auto-style13">
                &nbsp;</td>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:DropDownList ID="DDL_tipo_producto" class='dropdown-trigger btn' runat="server" Height="24px" Width="127px">
                    <asp:ListItem  Enabled="true" Text="seleccione" Value="-1"></asp:ListItem>
                    <asp:ListItem Text="Galón" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Medio Galón " Value="2"></asp:ListItem>
                    <asp:ListItem Text="pequeño" Value="3"></asp:ListItem>
                                
                </asp:DropDownList>
            </td>
            <td class="auto-style7">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="DDL_material"  class='dropdown-trigger btn' runat="server" Height="29px" Width="135px">
                    <asp:ListItem  Enabled="true" Text="seleccione" Value="-1" ></asp:ListItem>
                    <asp:ListItem Text="Plastico" Value="1" ></asp:ListItem>
                    <asp:ListItem Text="Metal" Value="2" ></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style12">
                &nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style7">
                <table class="pagination">
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>
                            <asp:Button ID="BTN_registrar" runat="server" CssClass="btn-large waves-effect waves-light lime darken-3" Text="Registrar" OnClick="BTN_registrar_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td class="auto-style12">
                &nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

