<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mostrar.aspx.cs" Inherits="BibliotecaMusica.Mostrar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Mostrar</h1>
        </div>
        <p>
            Artista:
        </p>
        <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
        <br />
        <p>
            &nbsp;</p>
        <p>
            :<asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
        
</asp:Content>