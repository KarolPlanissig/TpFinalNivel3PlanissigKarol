<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="Paginas.DetalleArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%if (articulo != null)
        { %>
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-10">
                <div class="card p-3 shadow-sm">
                    <div class="row g-3 align-items-center">

                        <div class="col-md-4 text-center">
                            <img src="<%:articulo.ImagenUrl%>" alt="Imagen del producto"
                                onerror="this.src='img/placeholder.jpg';"
                                class="img-fluid rounded" style="max-width: 100%; max-height: 300px;" />
                        </div>

                        <div class="col-md-8">
                            <h3 class="mb-3"><%:articulo.Nombre %></h3>

                            <h5 class="text-muted">Descripción</h5>
                            <p class="card-text text-secondary"><%:articulo.Descripcion %></p>

                            <div class="mt-3">
                                <p><strong>Marca:</strong> <%:articulo.Marcas.Descripcion %></p>
                                <p><strong>Categoría:</strong> <%:articulo.Categoria.Descripcion %></p>
                                <p class="text-success fw-bold" style="font-size: 1.2rem;">
                                    Precio: $<%:articulo.Precio %>
                                </p>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />

    <%     } %>

    <% if (Session["Usuario"] == null)
        { %>
    <div class="text-center">
        <div class="d-flex justify-content-center gap-2">
            <asp:Button Text="Regresar" ID="btnRegresar" CssClass="btn btn-primary" OnClick="btnRegresar_Click" runat="server" />
        </div>
    </div>
    <% } %>
    <%if (Session["Usuario"] != null && Session["ArticuloFavorito"] == null)
        { %>
    <div class="text-center">
        <div class="d-flex justify-content-center gap-2">
            <asp:Button Text="Agregar a favoritos 💖" CssClass="btn btn-primary" Style="color: white; background-color: red" ID="btnFavorito" OnClick="btnFavorito_Click" runat="server" />
            <asp:Button Text="Regresar" ID="btnRegresarArtNull" CssClass="btn btn-primary" OnClick="btnRegresar_Click" runat="server" />
        </div>
    </div>
    <%  } %>
    <%if (Session["Usuario"] != null && Session["ArticuloFavorito"] != null)
        { %>
    <div class="text-center">
        <div class="d-flex justify-content-center gap-2">
            <asp:Button Text="Regresar" ID="btnRegresarArtNotNull" CssClass="btn btn-primary" OnClick="btnRegresar_Click" runat="server" />
        </div>
    </div>
    <% } %>
    <br />

</asp:Content>
