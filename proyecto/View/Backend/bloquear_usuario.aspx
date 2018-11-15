<%@ Page Title="" Language="C#" MasterPageFile="~/View/Backend/Master/masterBack.master" AutoEventWireup="true" CodeFile="~/Controller/Backend/bloquear_usuario.aspx.cs" Inherits="View_Backend_bloquear_usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <style type="text/css">
        .auto-style1 {
            width: 691px;
            height: 429px;
        }
        .auto-style3 {
            width: 113px;
        }
        .auto-style4 {
            width: 111px;
        }
        .auto-style5 {
            width: 110px;
        }
        .auto-style8 {
            width: 99px;
        }
        .auto-style11 {
            width: 141px;
            height: 119px;
        }
        .auto-style12 {
            width: 141px;
        }
        .auto-style13 {
            width: 205px;
            height: 119px;
        }
        .auto-style14 {
            width: 205px;
        }
        .auto-style15 {
            width: 145px;
            height: 119px;
        }
        .auto-style16 {
            width: 145px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style13">
                <table class="pagination">
                    <tr>
                        <td class="auto-style5">&nbsp;</td>
                        <td>
                           
                           
                         <asp:Label ID="Lb_bloquear"  runat="server" Font-Size="XX-Large" Text="Bloquear Usuario" Width="258px"></asp:Label>
                        </td>
                        <td></td>
                    </tr>
                </table>
            </td>
            <td class="auto-style11"></td>
            <td class="auto-style15"></td>
        </tr>
        <tr>
            <td class="auto-style14">
                <table class="auto-style8">
                    <tr>
                        <td>
                            <asp:TextBox ID="TB_nombre_us" runat="server" Height="27px" Width="157px"></asp:TextBox>
                           
                         </td>
                        
                    </tr>
                </table>
&nbsp;&nbsp;
                <asp:Label ID="LB_nombre_us" runat="server" Text="Nombre Usuario"></asp:Label>
            </td>
            <td class="auto-style12">
                
                            <asp:DropDownList ID="DDL_estado" class='dropdown-trigger btn' runat="server" Height="27px" Width="142px">
                                <asp:ListItem>Activo</asp:ListItem>
                                <asp:ListItem>Inactivo</asp:ListItem>
                          </asp:DropDownList>
                            
            </td>
            <td class="auto-style16">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style4">
                            
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="BTN_Buscar" CssClass="btn-large waves-effect waves-light black" runat="server" Text="Buscar" Width="129px" OnClick="BTN_Buscar_Click" style="left: 0px; top: 0px; height: 48px" />
                          
                        </td>
                    </tr>
                </table>
            </td>
            <td class="auto-style12">
              
               
                &nbsp;</td>
            <td class="auto-style16">
              
               
                <asp:Button ID="BTN_cambiar" CssClass="btn-large waves-effect waves-light black" runat="server" Text="Cambiar" OnClick="BTN_cambiar_Click" style="left: -142px; top: -104px; height: 42px; width: 126px" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

