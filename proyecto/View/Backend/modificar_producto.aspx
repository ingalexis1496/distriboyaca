<%@ Page Title="" Language="C#" MasterPageFile="~/View/Backend/Master/masterBack.master" AutoEventWireup="true" CodeFile="~/Controller/Backend/modificar_producto.aspx.cs" Inherits="View_Backend_modificar_producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 119px;
        }
        .auto-style3 {
            width: 86px;
        }
        .auto-style5 {
            margin-bottom: 0;
        }
        .auto-style6 {
            width: 250px;
            height: 90px;
        }
        .auto-style8 {
            width: 86px;
            height: 90px;
        }
        .auto-style10 {
            width: 136%;
            height: 603px;
        }
        .auto-style12 {
            width: 266px;
            height: 90px;
        }
        .auto-style13 {
            width: 266px;
        }
        .auto-style14 {
            width: 90%
        }
        .auto-style15 {
            width: 76px;
        }
        .auto-style16 {
            width: 250px;
        }
        .auto-style17 {
            width: 108px;
            height: 90px;
        }
        .auto-style18 {
            width: 108px;
        }
        .auto-style19 {
            width: 415px;
            height: 90px;
        }
        .auto-style20 {
            width: 415px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style10">
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style6"></td>
            <td class="auto-style19">
                <asp:Label ID="LB_titulo" runat="server" Font-Size="XX-Large" Text="Modificar Producto:"></asp:Label>
            </td>
            <td class="auto-style8"></td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style18">
                &nbsp;</td>
            <td class="auto-style16">
                <asp:Label ID="LB_serial" runat="server" Font-Size="Large" Text="Serial Producto:"></asp:Label>
            </td>
            <td class="auto-style20">
                <asp:TextBox ID="TB_serial" runat="server" Width="104px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LB_nombre" runat="server" Font-Size="Large" Text="Nombre:"></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_nombre" runat="server" Width="85px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style20">
                <table class="pagination">
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style1">&nbsp;</td>
                        <td>
                            <asp:Button ID="BTN_buscar" CssClass="btn-large waves-effect waves-light black"  runat="server" Text="Buscar"  style="left: -15px; top: -6px; height: 46px; width: 129px" OnClick="BTN_buscar_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LB_seri" runat="server" Font-Size="Large" Text="Serial:"></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_seri" runat="server" CssClass="auto-style5" Width="90px"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="LB_tipo" runat="server" Font-Size="Large" Text="Tipo:"></asp:Label>
                <br />
            </td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_tipo" runat="server" Width="89px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="LB_material" runat="server" Font-Size="Large">Material:</asp:Label>
            </td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_material" runat="server" Width="92px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style13">
                <table class="auto-style14">
                    <tr>
                        <td class="auto-style15">&nbsp;</td>
                        <td>
                            <asp:Button ID="BTN_modificar" CssClass="btn-large waves-effect waves-light black" runat="server"  Text="Modificar"  style="left: -6px; top: 1px; height: 46px; width: 131px" OnClick="BTN_modificar_Click"  />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

