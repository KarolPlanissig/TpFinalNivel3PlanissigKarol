<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PaginaAdmin.aspx.cs" Inherits="Paginas.PaginaAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <div class="text-center">
        <h2>¡Bienvenido, admin!</h2>
    </div>
    <br />

    <div class="container">
        <div class="row justify-content-center">
            <asp:Repeater ID="repRepetidorAdmin" runat="server">
                <ItemTemplate>
                    <div class="col-md-2 mb-3">
                        <div class="card h-100">
                            <div class="card-body d-flex flex-column justify-content-between p-2">
                                <span class="card-title text-center" style="font-size: 0.75rem;"><%# Eval("Nombre") %></span>
                                <img src="<%# Eval("ImagenUrl") %>" class="card-img-top img-fluid d-block mx-auto my-2" style="max-width: 100%; height: 8rem; object-fit: contain;" alt="imagen del producto" onerror="this.src='https://ralfvanveen.com/wp-content/uploads/2021/06/Placeholder-_-Glossary.svg';" />
                                <p class="card-text text-center mb-2">$<%# Eval("Precio") %></p>
                                <asp:Button Text="Ver detalle" CssClass="btn btn-primary btn-sm mt-auto mb-2" ID="btnVerDetalle" OnClick="btnVerDetalle_Click" CommandArgument='<%#Eval("Id")%>' CommandName="ProductoId" runat="server" />
                                <asp:Button Text="Modificar articulo" CssClass="btn btn-warning btn-sm mt-auto mb-2" ID="btnModificarArticulo" OnClick="btnModificarArticulo_Click" CommandArgument='<%#Eval("Id")%>' CommandName="ProductoId" runat="server" />
                                <asp:Button Text="Eliminar articulo" CssClass="btn btn-danger btn-sm mt-auto mb-2" ID="btnEliminarArticulo" OnClick="btnEliminarArticulo_Click" CommandArgument='<%#Eval("Id")%>' CommandName="ProductoId" runat="server" />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <br />
    <div class="text-center">
        <asp:Button ID="btnAgregarArticulo" OnClick="btnAgregarArticulo_Click" Text="¡Agregar Articulo!" CssClass="btn btn-primary" runat="server" />
    </div>


</asp:Content>
