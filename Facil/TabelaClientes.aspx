<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TabelaClientes.aspx.cs" Inherits="Facil._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Content/TabelaClientes.css" />
        <h1>Tabela de Clientes</h1>
    <div>
        <span id="MsgVazio" style="color:red;" runat="server" visible="false" class="msgVazio">Não há registros</span>
        <asp:GridView ID="ClienteGridView" CssClass="grdCliente" runat="server" ShowHeaderWhenEmpty="true" AutoGenerateColumns="False"
            AutoPostBack="true"
            DataKeyNames="IdCliente"
            onrowcancelingedit="ClienteGridView_RowCancelingEdit" 
            onrowediting="ClienteGridView_RowEditing"             
            onrowupdating="ClienteGridView_RowUpdating"
            onrowdeleting="ClienteGridView_RowDeleting"
            onrowdatabound="ClienteGridView_RowDataBound">
            <Columns>
                <asp:TemplateField HeaderText="Nome">
                    <ItemTemplate>    <%#Eval("nome") %>    </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNome" runat="server" CssClass="campo-transp" Text='<%#Eval("nome") %>'></asp:TextBox>
                        </EditItemTemplate>
                </asp:TemplateField>    
                <asp:TemplateField HeaderText="Cpf">
                    <ItemTemplate>    <%#Eval("cpf") %>    </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCpf" runat="server" CssClass="campo-transp" Text='<%#Eval("cpf") %>'></asp:TextBox>
                        </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tipo de Cliente">
                    <ItemTemplate>
                        <asp:DropDownList ID="ddlTipoCliente" runat="server"  CssClass="campo-transp" Enabled="false" Text='<%#Eval("idTipoCliente") %>'>
                            <asp:ListItem Text="Física" Value="1"/>
                            <asp:ListItem Text="Jurídica" Value="2"/>
                        </asp:DropDownList>
                    </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddlEditTipoCliente" runat="server" CssClass="campo-transp" Text='<%#Eval("idTipoCliente") %>'>
                                <asp:ListItem Text="Física" Value="1"/>
                                <asp:ListItem Text="Jurídica" Value="2"/>
                            </asp:DropDownList>
                        </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sexo">
                    <ItemTemplate>
                        <asp:DropDownList ID="ddlSexo" runat="server" CssClass="campo-transp" Enabled="false" Text='<%#Eval("sexo") %>'>
                            <asp:ListItem Text="Masculino" Value="M"/>
                            <asp:ListItem Text="Feminino" Value="F"/>
                        </asp:DropDownList>
                    </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddlEditSexo" runat="server" CssClass="campo-transp" Text='<%#Eval("sexo") %>'>
                                <asp:ListItem Text="Masculino" Value="M"/>
                                <asp:ListItem Text="Feminino" Value="F"/>
                            </asp:DropDownList>
                        </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Situação do Cliente">
                    <ItemTemplate>
                        <asp:DropDownList ID="ddlsituacaoCliente" runat="server" CssClass="campo-transp" Enabled="false" Text='<%#Eval("idSituacaoCliente") %>'>
                            <asp:ListItem Text="Ativo" Value="1"/>
                            <asp:ListItem Text="Inativo" Value="2"/>
                        </asp:DropDownList>
                    </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddlEditsituacaoCliente" runat="server" CssClass="campo-transp" Text='<%#Eval("idSituacaoCliente") %>'>
                                <asp:ListItem Text="Ativo" Value="1"/>
                                <asp:ListItem Text="Inativo" Value="2"/>
                            </asp:DropDownList>
                        </EditItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="true" ButtonType="Image" 
                    EditImageUrl="Imagens/editar.png" 
                    UpdateImageUrl="Imagens/aceitar.png"
                    CancelImageUrl="Imagens/cancelar.png" HeaderText="Editar" />
                <asp:CommandField ShowDeleteButton="true" ButtonType="Image" DeleteImageUrl="Imagens/excluir.png" HeaderText="Deletar" />
            </Columns>
            <EmptyDataTemplate>
                <div align="center">Nenhum registro encontrado.</div>
            </EmptyDataTemplate>
        </asp:GridView>
        <asp:Button ID="btnNovoCliente" Text="Novo Cliente" CssClass="btnCliente" runat="server" OnClick="btnNovoCliente_Click"/>
    </div>

</asp:Content>