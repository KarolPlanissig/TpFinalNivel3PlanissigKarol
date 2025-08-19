<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="Paginas.CrearCuenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="card shadow-sm p-4">
                    <asp:Label Text="¡Hola, crea tu cuenta!" CssClass="text-center mb-4 text-primary h3" ID="lblText" runat="server" />
                    <div class="mb-3">
                        <asp:Label ID="lblNombre" Text="Nombre" CssClass="form-label" runat="server" />
                        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" />
                        <asp:RequiredFieldValidator ErrorMessage="¡El campo debe ser cargado!" CssClass="text-danger" ControlToValidate="txtNombre" runat="server" />
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="lblApellido" Text="Apellido" CssClass="form-label" runat="server" />
                        <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server" />
                        <asp:RequiredFieldValidator ErrorMessage="¡El campo debe ser cargado!" CssClass="text-danger" ControlToValidate="txtApellido" runat="server" />
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="lblCorreo" Text="Correo electrónico" CssClass="form-label" runat="server" />
                        <asp:TextBox ID="txtCorreo" CssClass="form-control" TextMode="Email" runat="server" />
                        <asp:RequiredFieldValidator ErrorMessage="¡El campo debe ser cargado!" CssClass="text-danger" ControlToValidate="txtCorreo" runat="server" />
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="lblPassword" Text="Contraseña" CssClass="form-label" runat="server" />
                        <asp:TextBox ID="txtPassword" CssClass="form-control" TextMode="Password" runat="server" />
                        <asp:RequiredFieldValidator ErrorMessage="¡El campo debe ser cargado!" CssClass="text-danger" ControlToValidate="txtPassword" runat="server" />
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="lblRepetir" Text="Repetir contraseña" CssClass="form-label" runat="server" />
                        <asp:TextBox ID="txtRepetir" CssClass="form-control" TextMode="Password" runat="server" />
                        <asp:RequiredFieldValidator ErrorMessage="¡El campo debe ser cargado!" CssClass="text-danger" ControlToValidate="txtRepetir" runat="server" />
                        <asp:CompareValidator ID="cvContraseña" ErrorMessage="Las contraseñas deben coincidir" CssClass="text-danger" Operator="Equal" Type="String" ControlToValidate="txtRepetir" ControlToCompare="txtPassword" runat="server" />
                    </div>
                    <div class="d-grid">
                        <asp:Button ID="btnCrearCuenta" Text="Crear cuenta" CssClass="btn btn-primary" OnClick="btnCrearCuenta_Click" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
