<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BibliotecaMusica._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        
        <h1>Ingreso de Albunes:</h1>
        <h2>Artista:</h2>
        <p>
            nombre:
            <asp:TextBox ID="txtArtista" runat="server"></asp:TextBox>
        </p>
        <h2>Album:</h2>
        <p>
            titulo:&nbsp;
            <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
        </p>
        <h2>Cancion:</h2>
        <p>
            nombre de la cancion:
            <asp:TextBox ID="txtNomCancion" runat="server"></asp:TextBox>
        </p>
        <p>
            tiempo de duracion:
            <asp:TextBox ID="txtDuracion" runat="server"></asp:TextBox>
        </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <p>
            <asp:Button ID="btnCancion" runat="server" OnClick="btnCancion_Click" Text="Agregar cancion" />
        </p>
        <p>
            fecha de puclicacion:
            <asp:Calendar ID="CalendarFecha" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="btnAlbum" runat="server" OnClick="btnAlbum_Click" Text="Agregar album" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar Artista" />
        </p>
        
    </div>

</asp:Content>
