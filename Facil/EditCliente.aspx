<%@ Page Title="EditCliente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCliente.aspx.cs" Inherits="Facil.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Novo Cliente</h1>
    <link rel="stylesheet" href="Content/EditCliente.css" />
    <div class="novoCliente">
      <asp:Label ID="lblNome" CssClass="lbl" runat="server"><b>Nome:</b></asp:Label>
      <asp:TextBox ID="txNome" runat="server"></asp:TextBox>
        <asp:Label ID="lblCpf" runat="server"><b>CPF/CNPJ:</b></asp:Label>
      <asp:TextBox ID="txCpf" runat="server"></asp:TextBox>
        <asp:Label ID="lblTipoCliente" runat="server"><b>Tipo de Cliente:</b></asp:Label>
        <asp:DropDownList ID="ddlTipoCliente" runat="server">
            <asp:ListItem Text="Física" Value="1"/>
            <asp:ListItem Text="Jurídica" Value="2"/>
        </asp:DropDownList>
        <asp:Label ID="lblSexo" runat="server"><b>Sexo:</b></asp:Label>
        <asp:DropDownList ID="ddlSexo" runat="server">
            <asp:ListItem Text="Masculino" Value="M"/>
            <asp:ListItem Text="Feminino" Value="F"/>
        </asp:DropDownList>
        <asp:Label ID="lblSituacaoCliente" runat="server"><b>Situação do Cliente:</b></asp:Label>
        <asp:DropDownList ID="ddlSituacaoCliente" runat="server">
            <asp:ListItem Text="Ativo" Value="1"/>
            <asp:ListItem Text="Inativo" Value="2"/>
        </asp:DropDownList>
    </div>
    <asp:Button ID="btnSalvar" CssClass="btnSalvar" Text="Salvar" runat="server" OnClick="btnSalvar_Click"/>
</asp:Content>
