<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Examen2_Progra2.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
   <h1>USUARIOS</h1> 
</div>
    <div>
      <br />
        <br />
    <asp:GridView runat="server" ID="datagrid" HorizontalAlign="Center"
        CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
        RowStyle-CssClass="rows" AllowPaging="True" />

    <br />
        <br />
        <br />

    

    <div class="container text-center">
        ID: <asp:TextBox ID="tID" class="form-control" runat="server"></asp:TextBox>
        Nombre: <asp:TextBox ID="tNombre" class="form-control" runat="server"></asp:TextBox>
        Email: <asp:TextBox ID="tEmail" class="form-control" runat="server"></asp:TextBox>
        Telefono: <asp:TextBox ID="tTelefono" class="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="container text-center">

        <asp:Button ID="Button1" class="btn btn-outline-primary" runat="server" Text="Consultar"  />
        <asp:Button ID="Button2" class="btn btn-outline-secondary" runat="server" Text="Borrar"  />
        <asp:Button ID="Button3" runat="server" class="btn btn-outline-danger" Text="Agregar" />
        <asp:Button ID="Bconsulta" runat="server" class="btn btn-outline-danger" Text="Actualizar"  />
     </div>
        </div>

</asp:Content>
