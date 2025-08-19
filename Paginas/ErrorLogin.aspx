<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ErrorLogin.aspx.cs" Inherits="Paginas.ErrorLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="text-center">
        <h3>Credenciales incorrectas</h3>
        <br />
        <br />  
        <asp:Button Text="Volver a intentar" CssClass="btn btn-primary" ID="btnReintentar" OnClick="btnReintentar_Click" runat="server" />
    </div>
</asp:Content>
