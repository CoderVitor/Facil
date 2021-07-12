<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TabelaClientes.aspx.cs" Inherits="Facil._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Content/TabelaClientes.css" />

    <div class="jumbotron">
        <h1>Tabela de Clientes</h1>
    </div>

    <div class="row">
        <asp:Button ID="btnNovoCliente" Text="Novo Cliente" runat="server" OnClick="btnNovoCliente_Click" />
        <asp:Button ID="btnEditar" Text="Editar" runat="server" OnClick="btnEditar_Click" />
        <asp:Table ID="myTable" runat="server" Width="100%"> 
            <asp:TableRow>
                <asp:TableCell>Nome</asp:TableCell>
                <asp:TableCell>CPF</asp:TableCell>
                <asp:TableCell>Sexo</asp:TableCell>
            </asp:TableRow>
        </asp:Table>  
    </div>

</asp:Content>
