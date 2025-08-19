<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="EliminarArticulo.aspx.cs" Inherits="Paginas.EliminarArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .btn-equal {
            width: 120px; 
        }
        .dang{
            background-color: red; 
        }
    </style>
    <br />
    <div class="text-center">
        <h3>Estas seguro de que deseas eliminar el articulo?</h3>
    </div>
    <div class="text-center mt-3">
        <asp:Button ID="btnConfirmar" Text="Confirmar" CssClass="btn btn-equal dang" OnClick="btnConfirmar_Click" runat="server" />
        <asp:Button ID="btnCancelar" Text="Cancelar" CssClass="btn btn-primary btn-equal" OnClick="btnCancelar_Click" runat="server" />
    </div>
</asp:Content>
