<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AgregarArticulo.aspx.cs" Inherits="Paginas.AgregarArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-5">
                <div class="card shadow-sm p-4">
                    <h3 class="text-center mb-4 text-primary">Agregar Artículo</h3>

                    <div class="mb-1">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="form-label" />
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Debe cargar el campo" ControlToValidate="txtNombre" runat="server" />
                    </div>
                    <div class="mb-1">
                        <asp:Label ID="lblDescripcion" runat="server" Text="Descripción" CssClass="form-label" />
                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Debe cargar el campo" ControlToValidate="txtDescripcion" runat="server" />
                    </div>
                    <div class="mb-1">
                        <asp:Label ID="lblCodigo" runat="server" Text="Código" CssClass="form-label" />
                        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ErrorMessage="Debe cargar el campo" ControlToValidate="txtCodigo" runat="server" />
                    </div>
                    <div class="mb-1">
                        <asp:Label ID="lblImagen" runat="server" Text="Imagen" CssClass="form-label" />
                        <asp:TextBox ID="txtImagen" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ErrorMessage="Debe cargar el campo" ControlToValidate="txtImagen" runat="server" />
                    </div>
                    <div class="mb-1">
                        <asp:Label ID="lblMarca" runat="server" Text="Marca" CssClass="form-label" />
                        <asp:DropDownList ID="ddlMarca" CssClass="form-select" runat="server" />
                    </div>
                    <div class="mb-1">
                        <asp:Label ID="lblCategoria" runat="server" Text="Marca" CssClass="form-label" />
                        <asp:DropDownList ID="ddlCategoria" CssClass="form-select" runat="server" />
                        <asp:RequiredFieldValidator ErrorMessage="Debe cargar el campo" ControlToValidate="ddlCategoria" runat="server" />
                    </div>
                    <div class="mb-1">
                        <asp:Label ID="lblPrecio" runat="server" Text="Precio" CssClass="form-label" />
                        <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ErrorMessage="Debe cargar el campo" ControlToValidate="txtPrecio" runat="server" />
                    </div>
                    <div class="d-flex justify-content-end gap-2">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-secondary" />
                        <asp:Button ID="btnConfimar" runat="server" Text="Agregar Articulo" OnClick="btnConfimar_Click" CssClass="btn btn-success" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />

</asp:Content>
