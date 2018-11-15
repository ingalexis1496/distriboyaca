<%@ Page Title="" Language="C#" MasterPageFile="~/View/Backend/Master/masterBack.master" AutoEventWireup="true" CodeFile="~/Controller/Backend/modificarAdministrador.aspx.cs" Inherits="View_Backend_Master_modificarAdministrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 1px;
        }
        .auto-style4 {
            position: relative;
            margin-top: 1rem;
            width: 221px;
        }
        .auto-style7 {
            width: 78%;
            height: 11px;
        }
        .auto-style8 {
            width: 136%;
            height: 319px;
        }
        .auto-style9 {
            width: 143px;
        }
        .auto-style13 {
            width: 143px;
            height: 10px;
        }
        .auto-style15 {
            height: 10px;
        }
        .auto-style19 {
            position: relative;
            margin-top: 1rem;
            width: 221px;
            left: 0px;
            top: 354px;
            height: 78px;
        }
        .auto-style20 {
            width: 143px;
            height: 3px;
        }
        .auto-style22 {
            height: 3px;
        }
        .auto-style23 {
            width: 217px;
        }
        .auto-style24 {
            width: 100%;
            height: 92px;
        }
        .auto-style25 {
            height: 30px;
        }
        .auto-style26 {
            width: 217px;
            height: 30px;
        }
        .auto-style27 {
            height: 30px;
            width: 79px;
        }
        .auto-style28 {
            width: 79px;
        }
        .auto-style29 {
            width: 143px;
            height: 54px;
        }
        .auto-style31 {
            height: 54px;
        }
        .auto-style32 {
            width: 102px;
            height: 10px;
        }
        .auto-style33 {
            width: 102px;
            height: 3px;
        }
        .auto-style34 {
            width: 102px;
        }
        .auto-style35 {
            width: 102px;
            height: 54px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div  class="row" style="padding:40px">
        
              <div class="row center-align">
                   <asp:Label ID="LB_modificar" runat="server" Font-Size="XX-Large">Modificar Administrador </asp:Label>

                      <table class="auto-style8">
                          <tr>
                              <td class="auto-style4">
                                  <asp:Panel ID="Panel1" runat="server" Height="314px" Width="352px">
                                      <table class="auto-style24">
                                          <tr>
                                              <td class="auto-style27">&nbsp;</td>
                                              <td class="auto-style26">
                                                  <asp:Label ID="Label1" runat="server" Text="User Name:"></asp:Label>
                                              </td>
                                              <td class="auto-style25">
                                                  <asp:TextBox ID="TB_nombre_user" runat="server" Height="28px" Width="155px"></asp:TextBox>
                                              </td>
                                              <td class="auto-style25">&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style28">&nbsp;</td>
                                              <td class="auto-style23">
                                                  <asp:Label ID="lb_alerta" runat="server" ForeColor="Red"></asp:Label>
                                              </td>
                                              <td>
                                                  <asp:Button ID="BTN_listar" runat="server" CssClass="btn-large waves-effect waves-light black" style="left: 65px; top: -9px; height: 43px; width: 114px" Text="Listo" OnClick="BTN_listar_Click" />
                                              </td>
                                              <td>&nbsp;</td>
                                          </tr>
                                      </table>
                                  </asp:Panel>
                              </td>
                            
                              <td class="auto-style2">
                                  &nbsp;</td>
                              <td>
                                  <table class="auto-style7">
                                      <tr>
                                          <td class="auto-style13">
                                              <asp:Label ID="TB_datos" runat="server" Text="Datos:" Font-Size="X-Large" ForeColor="#3399FF"></asp:Label>
                                          </td>
                                          <td class="auto-style32"></td>
                                          <td class="auto-style15"></td>
                                      </tr>
                                      <tr>
                                          <td class="auto-style20">
                                              <asp:Label ID="LB_Nombres" runat="server" Text="Nombres:"></asp:Label>
                                             
                                           
                                          </td>

                                          <td class="auto-style33">
                                              <asp:TextBox ID="TB_nombres" runat="server" Width="144px"></asp:TextBox>
                                          </td>
                                          <td class="auto-style22"></td>
                                      </tr>
                                         
                                      <tr>
                                          <td class="auto-style9">
                                              <asp:Label ID="LB_user" runat="server" Text="User Name:"></asp:Label>
                                             
                                           
                                          </td>

                                          <td class="auto-style34">
                                              <asp:TextBox ID="TB_nomb_us" runat="server" Width="140px"></asp:TextBox>
                                          </td>
                                          <td>&nbsp;</td>
                                      </tr>
                                         
                                      <tr>
                                          <td class="auto-style9">
                                              <asp:Label ID="LB_tel" runat="server" Text="Telefono:"></asp:Label>
                                          </td>
                                          <td class="auto-style34">
                                              <asp:TextBox ID="TB_telefono" runat="server" Width="138px"></asp:TextBox>
                                          </td>
                                          <td>&nbsp;</td>
                                      </tr>
                                      <tr>
                                          <td class="auto-style9">
                                              <asp:Label ID="LB_correo" runat="server" Text="Correo:"></asp:Label>
                                          </td>
                                          <td class="auto-style34">
                                              <asp:TextBox ID="TB_correo" runat="server" Width="136px"></asp:TextBox>
                                          </td>
                                          <td>&nbsp;</td>
                                      </tr>
                                      <tr>
                                          <td class="auto-style29">
                                              <asp:Label ID="LB_contrase" runat="server" Text="Contraseña:"></asp:Label>
                                          </td>
                                          <td class="auto-style35">
                                              <asp:TextBox ID="TB_contrasse" runat="server" Width="131px"></asp:TextBox>
                                          </td>
                                          <td class="auto-style31"></td>
                                      </tr>
                                      <tr>
                                          <td class="auto-style9">&nbsp;</td>
                                          <td class="auto-style34">&nbsp;</td>
                                          <td>
                                                
                                                     <asp:Button ID="BTN_modificar"  CssClass="btn-large waves-effect waves-light black" runat="server" Text="Modificar" style="left: 0px; top: 0px; height: 49px; width: 144px;" OnClick="BTN_modificar_Click" />
                                                    
                                              
                                          </td>
                                      </tr>
                                  </table>
                                  <%--</td>--%>
                              <td>&nbsp;</td>
                          </tr>
                          <tr>
                              <td class="auto-style19">
                                  &nbsp;</td>
                            
                              <td class="auto-style2">
                                  &nbsp;</td>
                              <td>
                                  &nbsp;</td>
                              <td>&nbsp;</td>
                          </tr>
                   </table>

                      </div>
           <div class="row center-align">
        </div>
    </div>
              
    
               
          </div>


</asp:Content>

