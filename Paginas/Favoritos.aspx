<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Favoritos.aspx.cs" Inherits="Paginas.Favoritos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-12 text-center my-3">
            <asp:Label class="text-primary h4" ID="lblBienvenida" Text="¡Bienvenido a tus favoritos! 💖" runat="server"  />
            
        </div>
    </div>




    <div class="container">
        <div class="row justify-content-center">
            <asp:Repeater ID="repFavoritos" runat="server">
                <ItemTemplate>
                    <div class="col-md-2 mb-3">
                        <div class="card h-100">
                            <div class="card-body d-flex flex-column justify-content-between p-2">
                                <span class="card-title text-center" style="font-size: 0.75rem;"><%# Eval("Nombre") %></span>
                                <img src="<%# Eval("ImagenUrl") %>" class="card-img-top img-fluid d-block mx-auto my-2" style="max-width: 100%; height: 8rem; object-fit: contain;" alt="imagen del producto" onerror="this.src='https://ralfvanveen.com/wp-content/uploads/2021/06/Placeholder-_-Glossary.svg';" />
                                <p class="card-text text-center mb-2">$<%# Eval("Precio") %></p>
                                <asp:Button Text="Ver detalle" CssClass="btn btn-primary btn-sm mt-auto" CommandArgument='<%#Eval("Id")%>' CommandName="ProductoId" OnClick="VerDetalle_Click" ID="VerDetalle" runat="server" />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
