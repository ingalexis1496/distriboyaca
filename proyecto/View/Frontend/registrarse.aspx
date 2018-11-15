<%@ Page Title="" Language="C#" MasterPageFile="~/View/Frontend/Master/masterFront.master" AutoEventWireup="true" CodeFile="~/Controller/Frontend/registrarse.aspx.cs" Inherits="View_Frontend_registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="row">
    <div id="fondoRegistrarse" class="col l6"></div>
    <div class="col l6" style="padding:40px">
      <div class="center-align">
        <h4>Registrarse:</h4>
      </div>
      <div class="input-field">
        <asp:TextBox ID="nombresTB" CssClass="validate" runat="server"></asp:TextBox>
        <label>Nombres:</label>
      </div>
      <div class="input-field">
        <asp:TextBox ID="userNameTB" CssClass="validate" runat="server"></asp:TextBox>
        <label>User name:</label>
      </div>
      <div class="input-field">
        <asp:TextBox ID="telefonoTB" CssClass="validate" TextMode="Phone" runat="server"></asp:TextBox>
        <label>Telefono:</label>
      </div>
      <div class="input-field">
        <asp:TextBox ID="correoTB" CssClass="validate" TextMode="Email" runat="server"></asp:TextBox>
        <label>Correo:</label>
      </div>
      <div class="input-field">
        <asp:TextBox ID="contrasenaTB" CssClass="validate" runat="server"></asp:TextBox>
        <label>Contraseña:</label>
      </div>
      <div class="center-align">
        <asp:Button ID="registrarseB" CssClass="btn-large waves-effect waves-light black" Text="Registrarse" runat="server" OnClick="registrarseB_Click"/>
      </div>
    </div>
  </div>
</asp:Content>

