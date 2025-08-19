<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ModificarArticulo.aspx.cs" Inherits="Paginas.ModificarArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />

    <div class="container mt-4">
        <div class="card shadow">
            <div class="card-header bg-primary text-white">
                <h5 class="mb-0">Modificar Artículo</h5>
            </div>
            <div class="card-body">
                <div class="mb-3">
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="form-label" />
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblDescripcion" runat="server" Text="Descripción" CssClass="form-label" />
                    <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblCodigo" runat="server" Text="Código" CssClass="form-label" />
                    <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblImagen" runat="server" Text="Imagen" CssClass="form-label" />
                    <asp:TextBox ID="txtImagen" runat="server" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblMarca" runat="server" Text="Marca" CssClass="form-label" />
                    <asp:DropDownList ID="ddlMarca" CssClass="form-select" runat="server" />
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblCategoria" runat="server" Text="Marca" CssClass="form-label" />
                    <asp:DropDownList ID="ddlCategoria" CssClass="form-select" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="Debe cargar el campo" ControlToValidate="ddlCategoria" runat="server" />
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblPrecio" runat="server" Text="Precio" CssClass="form-label" />
                    <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" />
                </div>
                <div class="d-flex justify-content-end gap-2">
                    <asp:Button ID="btnCancelar" OnClick="btnCancelar_Click" runat="server" Text="Cancelar" CssClass="btn btn-secondary" />
                    <asp:Button ID="btnConfimar" runat="server" Text="Guardar Cambios" OnClick="btnConfimar_Click" CssClass="btn btn-success" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
