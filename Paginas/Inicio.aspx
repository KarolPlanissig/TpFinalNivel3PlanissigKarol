<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Paginas.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>

    <h1 class="text-center mb-4 text-primary" style="text-align: center; font-size: 2.5rem; margin-top: 50px;">Bienvenido</h1>
    <p style="text-align: center; font-size: 1.1rem; color: #555; margin-bottom: 30px;">Gracias por visitar nuestro catálogo. Esperamos que encuentres lo que estás buscando. </p>

    <br />
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="text-center">
                <asp:Label Text="Filtro por nombre: " ID="lblFiltro" runat="server" />
                <asp:TextBox AutoPostBack="true" ID="txtFiltro" OnTextChanged="Filtro_TextChanged" runat="server" />
            </div>
            <br />

            <div class="container">
                <div class="row justify-content-center">
                    <asp:Repeater ID="repRepetidorr" runat="server">
                        <ItemTemplate>
                            <div class="col-md-2 mb-3">
                                <div class="card h-100">
                                    <div class="card-body d-flex flex-column justify-content-between p-2">
                                        <span class="card-title text-center" style="font-size: 0.75rem;"><%# Eval("Nombre") %></span>
                                        <img src="<%# Eval("ImagenUrl") %>" class="card-img-top img-fluid d-block mx-auto my-2" style="max-width: 100%; height: 8rem; object-fit: contain;" alt="imagen del producto" onerror="this.src='https://ralfvanveen.com/wp-content/uploads/2021/06/Placeholder-_-Glossary.svg';" />
                                        <p class="card-text text-center mb-2">$<%# Eval("Precio") %></p>
                                        <asp:Button Text="Ver detalle" CssClass="btn btn-primary btn-sm mt-auto" ID="btnVerDetalle" OnClick="btnVerDetalle_Click" CommandArgument='<%#Eval("Id")%>' CommandName="ProductoId" runat="server" />
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>
