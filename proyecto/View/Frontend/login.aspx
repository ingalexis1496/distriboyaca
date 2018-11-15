<%@ Page Title="" Language="C#" MasterPageFile="~/View/Frontend/Master/masterFront.master" AutoEventWireup="true" CodeFile="~/Controller/Frontend/login.aspx.cs" Inherits="View_Frontend_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="fondoLogin">
    <div class="row" style="padding-top:40px">
      <div class="col l4 offset-l4 s12">
        <div class="card" style="background-color:rgba(0,0,0,0.9)">
          <div class="card-action indigo darken-4">
            <h4 class="white-text">Iniciar sesion</h4>
          </div>
          <div class="card-content">
            <div class="input-field">
              <asp:TextBox ID="usuarioTB" CssClass="validate white-text" runat="server"></asp:TextBox>
              <label>Usuario:</label>
            </div><br/>
            <div class="input-field">
              <asp:TextBox ID="contrasenaTB" CssClass="validate white-text" TextMode="Password" runat="server"></asp:TextBox>
              <label>Contraseña:</label>
            </div><br/>
            <div>
              <a href="#">¿olvido su contraseña?</a>
            </div><br/>
            <div>
              <asp:Label ID="noValidoL" CssClass="red-text" Visible="false" runat="server"></asp:Label>
            </div><br/>
            <div class="center-align">
              <asp:Button ID="ingresarB" CssClass="btn-large waves-effect waves-light indigo darken-4" Text="Ingresar" runat="server" OnClick="ingresarB_Click"/>
            </div><br/>
          </div>
        </div>
      </div>
    </div>
  </div>
</asp:Content>

