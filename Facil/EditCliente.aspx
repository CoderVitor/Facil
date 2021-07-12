<%@ Page Title="EditCliente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCliente.aspx.cs" Inherits="Facil.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblOpcaoCliente" runat="server">Deseja editar qual cliente?</asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Text="Ativo" Value="1"/>
            <asp:ListItem Text="Inativo" Value="2"/>
        </asp:DropDownList>
    <form>
      <asp:Label ID="lblNome" runat="server">Nome:</asp:Label>
      <asp:TextBox ID="txNome" runat="server"></asp:TextBox>
        <asp:Label ID="lblCpf" runat="server">CPF/CNPJ:</asp:Label>
      <asp:TextBox ID="txCpf" runat="server"></asp:TextBox>
        <asp:Label ID="lblTipoCliente" runat="server">Tipo de Cliente:</asp:Label>
        <asp:DropDownList ID="ddlTipoCliente" runat="server">
            <asp:ListItem Text="Física" Value="1"/>
            <asp:ListItem Text="Jurídica" Value="2"/>
        </asp:DropDownList>
        <asp:Label ID="lblSexo" runat="server">Sexo:</asp:Label>
        <asp:DropDownList ID="ddlSexo" runat="server">
            <asp:ListItem Text="Masculino" Value="M"/>
            <asp:ListItem Text="Feminino" Value="F"/>
        </asp:DropDownList>
        <asp:Label ID="lblSituacaoCliente" runat="server">Situação do Cliente:</asp:Label>
        <asp:DropDownList ID="ddlSituacaoCliente" runat="server">
            <asp:ListItem Text="Ativo" Value="1"/>
            <asp:ListItem Text="Inativo" Value="2"/>
        </asp:DropDownList>
    </form>
    <asp:Button ID="btnSalvar" Text="Salvar" runat="server" OnClick="btnSalvar_Click"/>
</asp:Content>
