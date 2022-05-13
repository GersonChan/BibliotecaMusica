<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="BibliotecaMusica.Update" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Actualizar</h1>
        </div>
        <p>
            Album::
        </p>
        <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar Album" />
        </p>
        <p>
            Nombre:
        </p>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <p>
            fecha de publicacion:</p>
        <p>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Alumo" OnClick="btnActualizar_Click" />

</asp:Content>