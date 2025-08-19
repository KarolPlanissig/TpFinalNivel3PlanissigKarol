<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Paginas.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-5">
                <div class="card shadow-sm p-4">
                    <h3 class="text-center mb-4 text-primary">Iniciar sesión</h3>

                        <div class="mb-3">
                            <asp:Label ID="lblUsuario" runat="server" Text="Usuario" CssClass="form-label" />
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Ingrese su usuario" />
                        </div>

                        <div class="mb-4">
                            <asp:Label ID="lblContraseña" runat="server" Text="Contraseña" CssClass="form-label" />
                            <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" TextMode="Password" placeholder="••••••••" />
                        </div>

                        <div class="d-grid">
                            <asp:Button ID="btnLogin" runat="server" Text="Iniciar sesión" OnClick="btnLogin_Click" CssClass="btn btn-primary" />
                        </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
