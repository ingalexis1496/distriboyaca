<%@ Page Title="" Language="C#" MasterPageFile="~/View/Backend/Master/masterBack.master" AutoEventWireup="true" CodeFile="~/Controller/Backend/formularioRegistro.aspx.cs" Inherits="View_Backend_formularioRegistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="row" style="padding:40px">
    <div class="col l12 m12 s12">
      <div class="row center-align">
        <asp:Label ID="tituloL" runat="server" Font-Size="XX-Large"></asp:Label>
      </div>
      <div class="row">
        <div class="col l6 s12">
          <div class="input-field">
            <asp:TextBox ID="nombresTB" CssClass="validate" runat="server"></asp:TextBox>
            <label>Nombres:</label>
          </div>
        </div>
        <div class="col l6 s12">
          <div class="input-field">
            <asp:TextBox ID="userNameTB" CssClass="validate" runat="server"></asp:TextBox>
            <label>User Name:</label>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col l6 s12">
          <div class="input-field">
            <asp:TextBox ID="telefonoTB" CssClass="validate" runat="server"></asp:TextBox>
            <label>Telefono:</label>
          </div>
        </div>
        <div class="col l6 s12">
          <div class="input-field">
            <asp:TextBox ID="correoTB" CssClass="validate" runat="server"></asp:TextBox>
            <label>Correo:</label>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col l12 12">
          <div class="input-field">
            <asp:TextBox ID="contrasenaTB" CssClass="validate" runat="server"></asp:TextBox>
            <label>Contrasena:</label>
          </div>
        </div>
      </div>
      <div class="row center-align">
          <asp:Button ID="registrarB" CssClass="btn-large waves-effect waves-light black" runat="server" Text="Registrar" OnClick="registrarB_Click"/>
        </div>
    </div>
  </div> 
</asp:Content>

